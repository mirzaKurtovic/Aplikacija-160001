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
    public partial class frmTrening : Form
    {
        private readonly APIService _apiService = new APIService("trening");
        private readonly APIService _apiService_TipTreninga = new APIService("TipTreninga");
        private Wellness.Model.Trener _trener;
        public frmTrening(Wellness.Model.Trener trener)
        {
            _trener = trener;
            InitializeComponent();
            
        }



        private async void FrmTrening_Load(object sender, EventArgs e)
        {
            var search = new TreningSearchRequest()
            {
                TipTreningaID = 0,
                DatumTreninga = DateTime.MinValue,
                TrenerID = _trener.Id
            };

            var treninzi = await _apiService.Get<List<Model.Trening>>(search);
            dgvTreninzi.DataSource = treninzi;

            foreach (DataGridViewRow row in dgvTreninzi.Rows)
            {
                Model.Trening obj = (Model.Trening)row.DataBoundItem;
                row.Cells[1].Value = obj.TipTreninga.TipTreninga1;
            }

            //---------------------------------------------------
            Model.TipTreninga svi = new Model.TipTreninga()
            {
                Id = 0,
                TipTreninga1 = "svi",
            };
            cbTipTreninga.Text = "svi";
            
            var TipTreninga = await _apiService_TipTreninga.Get<List<Model.TipTreninga>>(null);
            TipTreninga.Insert(0,svi);           
            cbTipTreninga.DataSource = TipTreninga;
            cbTipTreninga.DisplayMember = "TipTreninga1";
            cbTipTreninga.ValueMember = "id";
            cbTipTreninga.SelectedValue = svi.Id;
            //---------------------------------------------------
            dtpDatumTreninga.Enabled = false;
            cbSviDatumi.Checked = true;

        }

        private void DgvTreninzi_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = int.Parse(dgvTreninzi.SelectedRows[0].Cells[0].Value.ToString());
            frmTreningDetalji frm = new frmTreningDetalji(id,_trener);
            frm.Show();
        }

        private async void BtnTrazi_Click(object sender, EventArgs e)
        {
            DateTime  dt;
            if (cbSviDatumi.Checked)
            {
                
                dt = DateTime.MinValue;
            }
            else
            {
                dt = dtpDatumTreninga.Value;
            }
           

            var search = new TreningSearchRequest()
            {
                TipTreningaID = Convert.ToInt32(cbTipTreninga.SelectedValue),
                DatumTreninga = dt,
                TrenerID = _trener.Id
            };


            var treninzi = await _apiService.Get<List<Model.Trening>>(search);
            dgvTreninzi.DataSource = treninzi;

            foreach (DataGridViewRow row in dgvTreninzi.Rows)
            {
                Model.Trening obj = (Model.Trening)row.DataBoundItem;
                row.Cells[1].Value = obj.TipTreninga.TipTreninga1;
            }

        }

        private void CbSviDatumi_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSviDatumi.Checked)
            {
                dtpDatumTreninga.Enabled = false;
            }
            else
            {
                dtpDatumTreninga.Enabled = true;
            }
        }
        

    }
}
