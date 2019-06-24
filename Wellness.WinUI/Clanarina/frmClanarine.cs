using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flurl;
using Flurl.Http;
using Wellness.Model.Requests;

namespace Wellness.WinUI.Clanarina
{
    public partial class frmClanarine : Form
    {
        private readonly APIService _apiService= new APIService("clanarina");
        private readonly APIService _apiService_Clan = new APIService("Clan");
        private readonly APIService _apiService_Paket = new APIService("Paket");
        public frmClanarine()
        {
            InitializeComponent();
        }

        private async void BtnTrazi_Click(object sender, EventArgs e)
        {
            var search = new ClanarinaSearchRequest();
            if (!string.IsNullOrWhiteSpace(txtUplataZaMjesec.Text))
                search.UplataZaMjesec = Convert.ToInt32(txtUplataZaMjesec.Text);
            else search.UplataZaMjesec = null;

            if (!string.IsNullOrWhiteSpace(txtUplataZaGodinu.Text))
                search.UplataZaGodinu = Convert.ToInt32(txtUplataZaGodinu.Text);
            else search.UplataZaGodinu = null;

            search.PaketID =(int)cbPaket.SelectedValue;
            search.ClanID =(int)cbClan.SelectedValue;

            //--------------------------------------------------------------------

            var result = await _apiService.Get<List<Model.Clanarina>>(search);
            dgvClanarina.DataSource = result;
           

            foreach (DataGridViewRow row in dgvClanarina.Rows)
            {
                Model.Clanarina obj = (Model.Clanarina)row.DataBoundItem;
                row.Cells[5].Value = obj.Clan.Osoba.Ime + " " + obj.Clan.Osoba.Prezime + " #" + obj.Clan.Id;
                row.Cells[6].Value = obj.Paket.Naziv;
            }

        }

        
        private void DgvClanarina_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = int.Parse(dgvClanarina.SelectedRows[0].Cells[0].Value.ToString());
            frmClanarinaDetalji frm = new frmClanarinaDetalji(id);
            frm.Show();
        }

        private async void FrmClanarine_Load(object sender, EventArgs e)
        {
            var search = new Model.Requests.ClanarinaSearchRequest()
            {
                UplataZaGodinu = null,
                UplataZaMjesec = null,
                PaketID = 0,
                ClanID = 0
            };

            var result = await _apiService.Get<List<Model.Clanarina>>(search);
            dgvClanarina.DataSource = result;
            var defaultClan = new Model.Requests.ClanViewRequest()
            {
                Id = 0,
                Ime = "Svi",
                Prezime = ""
            };
            var clanovi = await _apiService_Clan.Get<List<Model.Requests.ClanViewRequest>>(null);
            clanovi.Insert(0, defaultClan);
            cbClan.DataSource = clanovi;
            cbClan.DisplayMember = "Display";
            cbClan.ValueMember = "Id";
            cbClan.DropDownStyle = ComboBoxStyle.DropDownList;

            var defaultPaket = new Model.Paket()
            {
                Id = 0,
                Naziv = "svi"
            };
            var paketi = await _apiService_Paket.Get<List<Model.Paket>>(null);
            paketi.Insert(0, defaultPaket);
            cbPaket.DataSource = paketi;
            cbPaket.DisplayMember = "Display";
            cbPaket.ValueMember = "Id";
            cbPaket.DropDownStyle = ComboBoxStyle.DropDownList;

            foreach (DataGridViewRow row in dgvClanarina.Rows)
            {
                Model.Clanarina obj = (Model.Clanarina)row.DataBoundItem;
                row.Cells[5].Value = obj.Clan.Osoba.Ime + " " + obj.Clan.Osoba.Prezime + " #" + obj.Clan.Id;
                row.Cells[6].Value = obj.Paket.Naziv;
            }
        }
    }
}
