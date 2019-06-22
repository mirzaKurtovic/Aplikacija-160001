using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wellness.Model;
using Wellness.Model.Requests;
namespace Wellness.WinUI.Menadzment
{
    public partial class frmRadnici : Form
    {
        private readonly Radnik _radnik;
        private readonly APIService _apiService_radnik = new APIService("Radnik");
        private readonly APIService _apiService_uloga = new APIService("Uloga");

        public frmRadnici(Radnik radnik = null)
        {
            InitializeComponent();
            _radnik = radnik;
        }

        private async void FrmRadnici_Load(object sender, EventArgs e)
        {
           
            var uloge = await _apiService_uloga.Get<List<Model.Uloga>>(null);
            var svi = new Wellness.Model.Uloga()
            {
                Id = 0,
                Naziv = "svi"
            };
            uloge.Insert(0, svi);
            cbUloga.DataSource = uloge;
            cbUloga.ValueMember = "Id";
            cbUloga.DisplayMember = "Naziv";
            cbUloga.DropDownStyle = ComboBoxStyle.DropDownList;
            var search = new RadnikSearchRequest()
            {
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text,
                UlogaId = cbUloga.SelectedIndex
            };

            var radnici = await _apiService_radnik.Get<List<Wellness.Model.Radnik>>(search);
            dgvRadnici.DataSource = radnici;
            foreach (DataGridViewRow row in dgvRadnici.Rows)
            {
                Model.Radnik obj = (Model.Radnik)row.DataBoundItem;
                row.Cells[1].Value = obj.Osoba.Ime;
                row.Cells[2].Value = obj.Osoba.Prezime;
                row.Cells[3].Value = obj.Osoba.Uloga.Naziv;
                
            }


        }

        private async void BtnTrazi_Click(object sender, EventArgs e)
        {
            var search = new RadnikSearchRequest()
            {
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text,
                UlogaId = cbUloga.SelectedIndex
            };

            var radnici = await _apiService_radnik.Get<List<Wellness.Model.Radnik>>(search);
            dgvRadnici.DataSource = radnici;
            foreach (DataGridViewRow row in dgvRadnici.Rows)
            {
                Model.Radnik obj = (Model.Radnik)row.DataBoundItem;
                row.Cells[1].Value = obj.Osoba.Ime;
                row.Cells[2].Value = obj.Osoba.Prezime;
                row.Cells[3].Value = obj.Osoba.Uloga.Naziv;
            }
        }

        private void DgvRadnici_DoubleClick(object sender, EventArgs e)
        {
            Model.Osoba osoba =(Model.Osoba)dgvRadnici.SelectedRows[0].Cells[6].Value;
            frmRadniciDetalji frm = new frmRadniciDetalji(osoba.Id);
            frm.Show();
        }
    }
}
