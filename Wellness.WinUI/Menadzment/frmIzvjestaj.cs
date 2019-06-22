using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Wellness.Model.Requests;

namespace Wellness.WinUI.Menadzment
{
    public partial class frmIzvjestaj : Form
    {

        APIService _apiService_Clanarin;
        APIService _apiService_ClanPrisustvo;
        APIService _apiService_TipTreninga;
        APIService _apiService_Paket;

        public frmIzvjestaj()
        {
            InitializeComponent();

            _apiService_Clanarin = new APIService("Clanarina");
            _apiService_ClanPrisustvo = new APIService("ClanPrisustvo");
            _apiService_TipTreninga = new APIService("TipTreninga");
            _apiService_Paket = new APIService("Paket");

        }



        private async void FrmIzvjestaj_Load(object sender, EventArgs e)
        {
            tabPage1.Text = "Zarada";
            tabPage2.Text = "Prisustvo";

            Tab2_dtpDatumPocetak.Enabled = false;
            Tab2_dtpDatumKraj.Enabled = false;

            Tab1_dtpDatumPocetak.Enabled = false;
            Tab1_dtpDatumKraj.Enabled = false;


            var tipTreningaList =await _apiService_TipTreninga.Get<List<Model.TipTreninga>>(null);
            var tt = new Model.TipTreninga() { Id = 0, TipTreninga1 = "svi" };
            tipTreningaList.Insert(0, tt);
            Tab2_cbTipTreninga.DataSource = tipTreningaList;
            Tab2_cbTipTreninga.DisplayMember = "TipTreninga1";
            Tab2_cbTipTreninga.ValueMember = "Id";
            Tab2_cbTipTreninga.DropDownStyle = ComboBoxStyle.DropDownList;

            var paketList = await _apiService_Paket.Get<List<Model.Paket>>(null);
            var pp = new Model.Paket() { Id = 0, Naziv = "svi" };
            paketList.Insert(0, pp);
            Tab1_cbPaket.DataSource = paketList;
            Tab1_cbPaket.DisplayMember = "Naziv";
            Tab1_cbPaket.ValueMember = "Id";
            Tab1_cbPaket.DropDownStyle = ComboBoxStyle.DropDownList;



        }

        private async void BtnUcitaj_Click_1(object sender, EventArgs e)
        {
            this.chart1.Series[0].Points.Clear();
            this.chart1.Series[1].Points.Clear();

            var ClanarinaSearchRequest = new ClanarinaSearchRequest();

            if (!string.IsNullOrEmpty(txtUplataZaGodinu.Text))
                ClanarinaSearchRequest.UplataZaGodinu = Convert.ToInt32(txtUplataZaGodinu.Text);
            if ((int)Tab1_cbPaket.SelectedValue != 0)
                ClanarinaSearchRequest.PaketID = (int)Tab1_cbPaket.SelectedValue;

            var cl = await _apiService_Clanarin.Get<List<Model.Clanarina>>(ClanarinaSearchRequest);
            var clanarine = cl.OrderBy(c => c.UplataZaMjesec).ToList();
            if (Tab1_cbOmoguci_DatumPocetak.Checked)
                clanarine = clanarine.Where(cp => cp.DatumUplate >= Tab1_dtpDatumPocetak.Value).ToList();

            if (Tab1_cbOmoguci_DatumKraj.Checked)
                clanarine = clanarine.Where(cp => cp.DatumUplate <= Tab1_dtpDatumKraj.Value).ToList();







            var clanarineGodine = clanarine.GroupBy(c => c.UplataZaMjesec).ToList();
            foreach (var x in clanarineGodine)
            {



                var month = DateTimeFormatInfo.CurrentInfo.GetAbbreviatedMonthName(x.Last().UplataZaMjesec);

                this.chart1.Series["Zarada"].Points.AddXY(month, x.Sum(y => y.IznosUplate));
                this.chart1.Series["Prodano Paketa"].Points.AddXY(month, x.Count());

            }
        }

        private async void BtnUcitaj2_Click(object sender, EventArgs e)
        {
            this.chart2.Series[0].Points.Clear();
            this.chart2.Series[1].Points.Clear();


            var clanPrisustvo = await _apiService_ClanPrisustvo.Get<List<Model.ClanPrisustvo>>(null);

            if (Tab2_cbOmoguci_DatumPocetak.Checked)
                clanPrisustvo = clanPrisustvo.Where(cp => cp.Trening.DatumTreninga >= Tab2_dtpDatumPocetak.Value).ToList();

            if (Tab2_cbOmoguci_DatumKraj.Checked)
                clanPrisustvo = clanPrisustvo.Where(cp => cp.Trening.DatumTreninga <= Tab2_dtpDatumKraj.Value).ToList();

            if((int)Tab2_cbTipTreninga.SelectedValue!=0)
                clanPrisustvo = clanPrisustvo.Where(cp => cp.Trening.TipTreningaId== (int)Tab2_cbTipTreninga.SelectedValue).ToList();


            var clanPrisustvoGroup = clanPrisustvo.GroupBy(cp => cp.Trening.DatumTreninga.DayOfWeek);

            foreach (var x in clanPrisustvoGroup)
            {
                var danSedmice = (x.Last().Trening.DatumTreninga.DayOfWeek).ToString();


                this.chart2.Series[0].Points.AddXY(danSedmice,x.Count());
                this.chart2.Series[1].Points.AddXY(danSedmice, x.Where(cp=>cp.Prisustvovao==true).Count());

            }
        }

        private void Tab2_cbOmoguci_DatumPocetak_CheckedChanged(object sender, EventArgs e)
        {
            if (Tab2_cbOmoguci_DatumPocetak.Checked)
                Tab2_dtpDatumPocetak.Enabled = true;
            else
                Tab2_dtpDatumPocetak.Enabled = false;
        }

        private void Tab2_cbOmoguci_DatumKraj_CheckedChanged(object sender, EventArgs e)
        {
            if (Tab2_cbOmoguci_DatumKraj.Checked)
                Tab2_dtpDatumKraj.Enabled = true;
            else
                Tab2_dtpDatumKraj.Enabled = false;
        }

        private void Tab1_cbOmoguci_DatumPocetak_CheckedChanged(object sender, EventArgs e)
        {
            
            if (Tab1_cbOmoguci_DatumPocetak.Checked)
                Tab1_dtpDatumPocetak.Enabled = true;
            else
                Tab1_dtpDatumPocetak.Enabled = false;
        }

        private void Tab1_cbOmoguci_DatumKraj_CheckedChanged(object sender, EventArgs e)
        {
            if (Tab1_cbOmoguci_DatumKraj.Checked)
                Tab1_dtpDatumKraj.Enabled = true;
            else
                Tab1_dtpDatumKraj.Enabled = false;
        }
    }
}
