using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Wellness.Model.Requests;

namespace Wellness.WinUI.Clanarina
{
    public partial class frmClanarinaDetalji : Form
    {
        private readonly APIService _apiService = new APIService("Clanarina");
        private readonly APIService _apiService_Clan = new APIService("Clan");
        private readonly APIService _apiService_Paket = new APIService("Paket");
        private readonly Validation _validation = new Validation();
        private readonly int? _id;
        public frmClanarinaDetalji(int? id=null)
        {
            _id = id;

            InitializeComponent();
        }

        private async void FrmClanarinaDetalji_Load(object sender, EventArgs e)
        {
            var clanovi = await _apiService_Clan.Get<List<Model.Requests.ClanViewRequest>>(null);
            cbClan.DataSource = clanovi;
            cbClan.DisplayMember = "Display";
            cbClan.ValueMember = "Id";
            cbClan.DropDownStyle= ComboBoxStyle.DropDownList;

            var defaultPaket = new Model.Paket()
            {
                Id = 0,
                Naziv = "svi"
            };
            var paketi = await _apiService_Paket.Get<List<Model.Paket>>(null);
            cbPaket.DataSource = paketi;
            cbPaket.DisplayMember = "Display";
            cbPaket.ValueMember = "Id";

            cbPaket.DropDownStyle=ComboBoxStyle.DropDownList;
            

            if (_id.HasValue)
            {
                var clanarina = await _apiService.GetById<Model.Clanarina>(_id);

                txtUplataZaGodinu.Text = clanarina.UplataZaGodinu.ToString();
                txtUplataZaMjesec.Text = clanarina.UplataZaMjesec.ToString();
                txtIznos.Text = clanarina.IznosUplate.ToString();
                dateDatumUplate.Value = clanarina.DatumUplate;
                cbPaket.SelectedValue = clanarina.PaketId;
                cbClan.SelectedValue = clanarina.ClanId;

                //treba dodati paket i korisnika
            }
           
        }

        private  async void BtnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var request = new ClanarinaInsertRequest()
                {
                    UplataZaMjesec = int.Parse(txtUplataZaMjesec.Text),
                    UplataZaGodinu = int.Parse(txtUplataZaGodinu.Text),
                    IznosUplate = double.Parse(txtIznos.Text),
                    DatumUplate = dateDatumUplate.Value,
                    PaketID = (int)cbPaket.SelectedValue,
                    ClanID = (int)cbClan.SelectedValue
                };

                if (_id.HasValue)
                {

                    await _apiService.Update<Model.Clanarina>(_id, request);
                    MessageBox.Show("Uspjesno ste evidentirali novu clanarinu", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    await _apiService.Insert<Model.Clanarina>(request);
                    MessageBox.Show("Uspjesno ste azurirali clanarinu", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }

        }

        private void TxtUplataZaMjesec_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (_validation.Required(sender, e, ClanarineErrorProvider))
                if (_validation.IsNumberOnly(sender, e, ClanarineErrorProvider))
                    _validation.MinMaxValue(sender, e, ClanarineErrorProvider, 1, 12);


        }

        private void TxtUplataZaGodinu_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (_validation.Required(sender, e, ClanarineErrorProvider))
                if (_validation.IsNumberOnly(sender, e, ClanarineErrorProvider))
                    _validation.MinMaxValue(sender, e, ClanarineErrorProvider, 2000, 2100);
        }

        private void TxtIznos_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (_validation.Required(sender, e, ClanarineErrorProvider))
                if (_validation.IsNumberOnly(sender, e, ClanarineErrorProvider))
                    _validation.MinMaxValue(sender, e, ClanarineErrorProvider, 1, 1000);
        }

        private void FrmClanarinaDetalji_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
    }
}
