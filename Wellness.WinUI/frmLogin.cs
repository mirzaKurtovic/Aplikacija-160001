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
using Wellness.WinUI.Menadzment;

namespace Wellness.WinUI
{
    public partial class frmLogin : Form
    {
        APIService _apiService = new APIService("Osoba");
        APIService _apiService_Autentifikacija = new APIService("Autentifikacija");
        APIService _apiService_Radnik = new APIService("Radnik");
        APIService _apiService_Trener = new APIService("Trener");

        public frmLogin()
        {
            InitializeComponent();
        }

        private async void BtnPrijava_Click(object sender, EventArgs e)
        {
            var password = txtSifra.Text;
            var userName = txtUserName.Text;
            APIService._username = userName;
            APIService._password = password;

            var request = new AutentifikacijaRequest()
            {
                username = userName,
                password = password
            };

            Wellness.Model.Osoba osoba = await _apiService_Autentifikacija.Get<Wellness.Model.Osoba>(request);



            if (osoba != null)
            {
                if (osoba.Uloga.Naziv == "Menadzer" || osoba.Uloga.Naziv == "Recepcionar" || osoba.Uloga.Naziv == "Trener")
                {
                    var RadnikSearchRequest = new RadnikSearchRequest()
                    {
                        OsobaId = osoba.Id
                    };


                    var radnikList = await _apiService_Radnik.Get<List<Wellness.Model.Radnik>>(RadnikSearchRequest);
                    var radnik = radnikList[0];
                    frmIndex frm = new frmIndex(radnik);
                    frm.Show();
                    MessageBox.Show("Uspjesna prijava", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                }
                else
                {
                    MessageBox.Show("Niste autorizovani", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                }

            }
            else
            {
                MessageBox.Show("Pogresan Username ili Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }


        }
    }
}
