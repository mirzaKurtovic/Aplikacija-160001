using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wellness.Model.Requests;

namespace Wellness.WinUI.Trening
{
   
    public partial class frmTreningDetalji : Form
    {

        private readonly APIService _apiService_TipTreninga = new APIService("TipTreninga");
        private readonly APIService _apiService_Trening = new APIService("Trening");
        private readonly Validation _validation = new Validation();
        private readonly int? _id = null;
        private Wellness.Model.Trener _trener;
        public frmTreningDetalji(int? id, Wellness.Model.Trener trener)
        {
            _id = id;
            _trener = trener;
            InitializeComponent();
        }



        private async void BtnSnimi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var request = new TreningInsertRequest()
                {
                    TipTreningaId = Convert.ToInt32(cbTipTreninga.SelectedValue),
                    DatumTreninga = new DateTime(dtpDatumTreninga.Value.Year, dtpDatumTreninga.Value.Month, dtpDatumTreninga.Value.Day,0,0,0,0),
                    VrijemePocetak = new DateTime(dtpDatumTreninga.Value.Year, dtpDatumTreninga.Value.Month, dtpDatumTreninga.Value.Day,dtpPocetak.Value.Hour,dtpPocetak.Value.Minute,0,0),
                    VrijemeKraj = new DateTime(dtpDatumTreninga.Value.Year, dtpDatumTreninga.Value.Month, dtpDatumTreninga.Value.Day, dtpKraj.Value.Hour, dtpKraj.Value.Minute, 0,0),
                    MaksimalnoPrisutnih = int.Parse(txtMaxPrisutnih.Text),
                    TrenerId = _trener.Id,
                };

                if (_id.HasValue)
                {
                    //request.Id = Convert.ToInt32(_id);
                    await _apiService_Trening.Update<Model.Trening>(_id, request);
                    this.Close();
                    MessageBox.Show("Uspješna promjena !");
                }
                else
                {
                    await _apiService_Trening.Insert<Model.Trening>(request);
                    this.Close();
                    MessageBox.Show("Uspješna ste dodali novi trening !");
                }
            }
        }
        private async void FrmTreningDetalji_Load(object sender, EventArgs e)
        {
            btnPogledajPrisutne.Hide();

            var tipTreninga = await _apiService_TipTreninga.Get<List<Model.TipTreninga>>(null);

            cbTipTreninga.DataSource = tipTreninga;
            cbTipTreninga.ValueMember = "Id";
            cbTipTreninga.DisplayMember = "TipTreninga1";


            if (_id.HasValue)
            {
                var trening = await _apiService_Trening.GetById<Model.Trening>(_id);
                cbTipTreninga.SelectedValue = trening.TipTreningaId;
                dtpDatumTreninga.Value = trening.DatumTreninga;
                dtpPocetak.Value = trening.VrijemePocetak;
                dtpKraj.Value = trening.VrijemeKraj;
                txtMaxPrisutnih.Text = trening.MaksimalnoPrisutnih.ToString();
                btnPogledajPrisutne.Show();
            }
        }
        private void BtnPogledajPrisutne_Click(object sender, EventArgs e)
        {
            frmTreningPrisutni frm =new frmTreningPrisutni(_id);
            frm.Show();
        }
        private async void VecPostojiTrening(object sender,TreningSearchRequest TreningSearch,CancelEventArgs e)
        {
           
            var treningList = await _apiService_Trening.Get<List<Model.Trening>>(TreningSearch);

            if (_id != null)
            {
                //var tr =await _apiService_Trening.GetById<Model.Trening>(_id);
                treningList = treningList.Where(t => t.Id != _id).ToList();
            }

            if (treningList.Count != 0)
            {
                var trening = treningList[0];
                e.Cancel = true;
                var ele = (DateTimePicker)sender;
                
                   
                    epTreningDetalji.SetError(ele, "Vec postoji trening u intervalu  -> " + trening.VrijemePocetak.ToShortTimeString() + " - " + trening.VrijemeKraj.ToShortTimeString());
                    btnSnimi.Enabled = false;
               
            }
            else
            {
                e.Cancel = false;
                epTreningDetalji.SetError(dtpPocetak, null);
                epTreningDetalji.SetError(dtpKraj, null);
                btnSnimi.Enabled = true;
            }



        }

        private void DatumVeciOd(DateTime datumOd, DateTime datumDo, CancelEventArgs e)
        {


            DateTime pocetniSatiMinute = new DateTime(1,1,1,datumOd.Hour,datumDo.Minute, 0,0);
            DateTime krajnjiSatiMinute = new DateTime(1, 1, 1, datumDo.Hour, datumDo.Minute, 0,0);


            if (pocetniSatiMinute >= krajnjiSatiMinute)
            {
                e.Cancel = true;

            
                dtpDatumTreninga.Focus();
                epTreningDetalji.SetError(dtpPocetak, "Pocetak treninga ne smije biti poslije kraja !");
                
            }
            else
            {
                e.Cancel = false;
                epTreningDetalji.SetError(dtpPocetak, null);
                
            }
        }

        


        private void DtpPocetak_Validating(object sender, CancelEventArgs e)
        {
            var TreningSearch = new TreningSearchRequest()
            {
                TipTreningaID = 0,
                TrenerID = _trener.Id
            };
            var datumTreninga = dtpDatumTreninga.Value;
            var vrijemePocetak = dtpPocetak.Value;
            var vrijemeKraj = dtpKraj.Value;
            TreningSearch.DatumTreninga = new DateTime(datumTreninga.Year, datumTreninga.Month, datumTreninga.Day, 0, 0, 0, 0);
            TreningSearch.VrijemePocetak = new DateTime(datumTreninga.Year, datumTreninga.Month, datumTreninga.Day, vrijemePocetak.Hour, vrijemePocetak.Minute, 0, 0);
            TreningSearch.VrijemeKraj = new DateTime(datumTreninga.Year, datumTreninga.Month, datumTreninga.Day, vrijemeKraj.Hour, vrijemeKraj.Minute, 0, 0);
            VecPostojiTrening(sender,TreningSearch, e);
            //DatumVeciOd(dtpPocetak.Value, dtpKraj.Value, e);

        }

        private void DtpKraj_Validating(object sender, CancelEventArgs e)
        {
            var TreningSearch = new TreningSearchRequest()
            {
                TipTreningaID = 0,
                TrenerID = _trener.Id
            };
            var datumTreninga = dtpDatumTreninga.Value;
            var vrijemePocetak = dtpPocetak.Value;
            var vrijemeKraj = dtpKraj.Value;
            TreningSearch.DatumTreninga = new DateTime(datumTreninga.Year, datumTreninga.Month, datumTreninga.Day, 0, 0, 0, 0);
            TreningSearch.VrijemePocetak = new DateTime(datumTreninga.Year, datumTreninga.Month, datumTreninga.Day, vrijemePocetak.Hour, vrijemePocetak.Minute, 0, 0);
            TreningSearch.VrijemeKraj = new DateTime(datumTreninga.Year, datumTreninga.Month, datumTreninga.Day, vrijemeKraj.Hour, vrijemeKraj.Minute, 0, 0);
            VecPostojiTrening(sender,TreningSearch, e);
            //DatumVeciOd(dtpPocetak.Value, dtpKraj.Value, e);
        }

        private void TxtMaxPrisutnih_Validating(object sender, CancelEventArgs e)
        {
            if (_validation.Required(sender, e, epTreningDetalji))
                if (_validation.IsNumberOnly(sender, e, epTreningDetalji))
                    _validation.MinMaxValue(sender, e, epTreningDetalji, 1, 150);
        }

        private void BtnPonisti_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
