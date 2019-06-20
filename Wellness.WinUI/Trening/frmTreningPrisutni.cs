using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wellness.Model.Requests;

namespace Wellness.WinUI.Trening
{
    public partial class frmTreningPrisutni : Form
    {
        private readonly int _id;
        private Model.Trening _trening;
        private readonly APIService _apiService = new APIService("ClanPrisustvo");
        private readonly APIService _apiService_Trening = new APIService("Trening");
        public frmTreningPrisutni(object id)
        {
            _id = Convert.ToInt32(id);
            InitializeComponent();
        }

        private async void FrmTreningPrisutni_Load(object sender, EventArgs e)
        {

            _trening = await _apiService_Trening.GetById<Model.Trening>(_id);

            if (_trening.Odrzan!=null)
                if(_trening.Odrzan!=false)
                btnSacuvaj.Enabled = false;
            


            var search = new ClanPrisustvoSearchRequest()
            {
                TreningId = _id
            };
            dgvClanoviPrisustvo.DataSource = await _apiService.Get<List<Model.ClanPrisustvo>>(search);
            foreach (DataGridViewRow row in dgvClanoviPrisustvo.Rows)
            {
                //row.Cells[0].Value = "test";

                Model.ClanPrisustvo obj =(Model.ClanPrisustvo)row.DataBoundItem;
                row.Cells[0].Value = obj.Clan.Osoba.Display;
            }
            
        }

        private async void BtnSacuvaj_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvClanoviPrisustvo.Rows)
            {
                var request = new ClanPrisustvoInsertRequest()
                {
                    ClanId = Convert.ToInt32(row.Cells[3].Value),
                    TreningId = Convert.ToInt32(row.Cells[4].Value),
                    Prisustvovao = Convert.ToBoolean(row.Cells[1].Value),
                };

                await _apiService.Update<Model.ClanPrisustvo>(request.ClanId,request);
                this.Close();
                MessageBox.Show("Lista prisutnih uspješno ažurirana !");
            }


           
            _trening.Odrzan = true;
            var treningInsertRequest = new TreningInsertRequest()
            {

                DatumTreninga = _trening.DatumTreninga,
                MaksimalnoPrisutnih = _trening.MaksimalnoPrisutnih,
                TipTreningaId = _trening.TipTreningaId,
                TrenerId = _trening.TrenerId,
                VrijemeKraj = _trening.VrijemeKraj,
                VrijemePocetak = _trening.VrijemePocetak,
                Odrzan=true
            };
            await _apiService_Trening.Update<Model.Trening>(_id, treningInsertRequest);

        }

        private void BtnPonisti_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
