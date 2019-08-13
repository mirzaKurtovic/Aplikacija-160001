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
    public partial class frmRadniciDetalji : Form
    {

        private readonly int? _id;
        private bool isTrener = false;
        private bool isRadnik = false;
        private readonly Validation _validation = new Validation();
        private readonly APIService _apiService = new APIService("Osoba");
        private readonly APIService _apiService_Clan = new APIService("Clan");
        private readonly APIService _apiService_Grad = new APIService("Grad");
        private readonly APIService _apiService_Uloga = new APIService("Uloga");
        private readonly APIService _apiService_Radnik = new APIService("Radnik");
        private readonly APIService _apiService_Trener = new APIService("Trener");
        public frmRadniciDetalji(int? id=null)
        {
            InitializeComponent();
            if(id!=null)
            this._id = id;
        }
        private async void BtnRegister_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {

                var osobaRequest = new Wellness.Model.Requests.OsobaInsertRequest();

                osobaRequest.Ime = txtIme.Text;
                osobaRequest.Prezime = txtPrezime.Text;
                osobaRequest.DatumRodenja = dtpDatumRodenja.Value;
                osobaRequest.Spol = (cbSpol.SelectedValue.ToString().Substring(0, 1).ToUpper());
                osobaRequest.GradId = (int)cbMjestoBoravka.SelectedValue;
                osobaRequest.Jmbg = txtJMBG.Text;
                osobaRequest.Email = txtEmail.Text;
                osobaRequest.BrojTelefona = txtBrojTelefona.Text;
                osobaRequest.KorisnickoIme = txtUserName.Text;
                osobaRequest.UlogaId = (int)cbUloga.SelectedValue;

                Wellness.Model.Osoba osoba = null;
                Wellness.Model.Radnik radnik = null;



                if (_id == null)
                {
                    osobaRequest.Password = txtPassword.Text;
                    osobaRequest.PasswordPotvrda = txtPasswordPotvrda.Text;



                    osoba = await _apiService.Insert<Wellness.Model.Osoba>(osobaRequest);

                    if (osoba.Uloga.Naziv != "Clan")
                    {

                        var radnikRequest = new Wellness.Model.Requests.RadnikInsertRequest()
                        {

                            Satnica = decimal.Parse(txtSatnica.Text),
                            OsobaId = osoba.Id
                        };

                        radnik = await _apiService_Radnik.Insert<Wellness.Model.Radnik>(radnikRequest);


                        if (osoba.Uloga.Naziv == "Trener")
                        {
                            var trenerRequest = new TrenerInsertRequest()
                            {
                                Specializacija = txtSpecijalizacija.Text,
                                RadnikId = radnik.Id
                            };

                            var trener = await _apiService_Trener.Insert<Model.Trener>(trenerRequest);
                        }
                    }
                    else
                    {

                        var clanInsertRequest = new ClanInsertRequest() {

                            Aktivan=true,
                            DatumRegistracije=DateTime.Now,
                            OsobaId=osoba.Id
                        };
                        var clan = await _apiService_Clan.Insert<Wellness.Model.Clan>(clanInsertRequest);
                    }

                    MessageBox.Show("Uspjesno ste dodali novog korisnika", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();


                }
                else
                {
                    osoba = await _apiService.Update<Wellness.Model.Osoba>(_id, osobaRequest);
                    if (osoba.Uloga.Naziv != "Clan")
                    {
                        var radnikRequest = new Wellness.Model.Requests.RadnikInsertRequest()
                        {

                            Satnica = decimal.Parse(txtSatnica.Text),
                            OsobaId = osoba.Id
                        };

                        var radnikSearchRequest = new RadnikSearchRequest()
                        {
                            OsobaId = radnikRequest.OsobaId
                        };

                        var radnikList = await _apiService_Radnik.Get<List<Wellness.Model.Radnik>>(radnikSearchRequest);

                        radnik = await _apiService_Radnik.Update<Wellness.Model.Radnik>(radnikList[0].Id, radnikRequest);


                        if (osoba.Uloga.Naziv == "Trener")
                        {

                            var trenerRequest = new TrenerInsertRequest()
                            {
                                RadnikId = radnik.Id,
                                Specializacija = txtSpecijalizacija.Text
                            };

                            var trenerList = await _apiService_Trener.Get<List<Model.Trener>>(new TrenerSearchRequest() { OsobaId = osoba.Id });

                            var trener = _apiService_Trener.Update<Model.Trener>(trenerList[0].Id, trenerRequest);

                        }
                    }


                    MessageBox.Show("Uspjesno ste ažurirali korisnika", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }


            }
        }
        //treba implementirat trenera u apiu
        private async void FrmRadniciDetalji_Load(object sender, EventArgs e)
        {
            var spol = new List<Spol>();

            spol.Add(new Spol()
            {
                spol = "M"
            });
            spol.Add(new Spol()
            {
                spol = "Z"
            });


            cbSpol.DataSource = spol;
            cbSpol.ValueMember = "spol";
            cbSpol.DisplayMember = "spol";

            //------------------Grad
            List<Model.Grad> gradovi =await _apiService_Grad.Get<List<Model.Grad>>(null);
            cbMjestoBoravka.DataSource = gradovi;
            cbMjestoBoravka.DisplayMember = "Grad1";
            cbMjestoBoravka.ValueMember = "id";
            //------------------
            //------------------TipKorisnika
            var uloge = await _apiService_Uloga.Get<List<Wellness.Model.Uloga>>(null);
            cbUloga.DataSource = uloge;
            cbUloga.DisplayMember = "Naziv";
            cbUloga.ValueMember = "Id";
            //------------------

            if (_id != null)
            {
                var Osoba = await _apiService.GetById<Wellness.Model.Osoba>(_id);
                var radnikList =await _apiService_Radnik.Get<List<Wellness.Model.Radnik>>(new RadnikSearchRequest() { OsobaId=Osoba.Id});
                var Radnik = radnikList[0];

                if (Osoba.Ime != null)txtIme.Text = Radnik.Osoba.Ime;
                if(Osoba.Prezime != null)txtPrezime.Text = Radnik.Osoba.Prezime;
                if (Osoba.Spol != null) cbSpol.SelectedValue = Radnik.Osoba.Spol;
                if (Osoba.GradId != null) cbMjestoBoravka.SelectedValue = Radnik.Osoba.GradId;
                if (Osoba.Jmbg != null) txtJMBG.Text = Radnik.Osoba.Jmbg;
                if (Osoba.Email != null) txtEmail.Text = Radnik.Osoba.Email;
                if (Osoba.BrojTelefona != null) txtBrojTelefona.Text = Radnik.Osoba.BrojTelefona;
                if (Osoba.KorisnickoIme != null) txtUserName.Text = Radnik.Osoba.KorisnickoIme;
                txtPassword.Enabled=false;
                txtPasswordPotvrda.Enabled = false;
                cbUloga.SelectedValue = Radnik.Osoba.UlogaId;
                cbUloga.DropDownStyle = ComboBoxStyle.DropDownList;
                cbSpol.DropDownStyle = ComboBoxStyle.DropDownList;
                cbMjestoBoravka.DropDownStyle = ComboBoxStyle.DropDownList;
                if (cbUloga.SelectedItem.ToString() == "Clan")
                {
                    txtSpecijalizacija.Visible = false;
                    lblSpecijalizacija.Visible = false;

                    txtSatnica.Visible = false;
                    lblSatnica.Visible = false;
                }
                else
                {
                    txtSatnica.Visible = true;
                    lblSatnica.Visible = true;
                    txtSatnica.Text = Math.Round(Radnik.Satnica,0).ToString();
                }

                if (cbUloga.SelectedItem.ToString() == "Trener")
                {
                    txtSpecijalizacija.Visible = true;
                    txtSpecijalizacija.Enabled = true;
                    lblSpecijalizacija.Visible = true;
                    isTrener = true;
                }
                else
                {

                    txtSpecijalizacija.Visible = false;
                    txtSpecijalizacija.Enabled = false;
                    lblSpecijalizacija.Visible = false;
                    isTrener = false;
                }
                if (cbUloga.SelectedItem.ToString() != "Clan")
                {
                    txtSatnica.Visible = true;
                    txtSatnica.Enabled = true;
                    lblSatnica.Visible = true;
                    isRadnik = true;
                }
                else
                {

                    txtSatnica.Visible = false;
                    txtSatnica.Enabled = false;
                    lblSatnica.Visible = false;
                    isRadnik = false;
                }

                cbUloga.Enabled = false;
            }

        }

        private void TxtIme_Validating(object sender, CancelEventArgs e)
        {
            if (_validation.Required(sender, e, radniciDetaljiErrorProvider))
                if (_validation.IsLetterOnly(sender, e, radniciDetaljiErrorProvider))
                    _validation.MinMaxLength(sender, e, radniciDetaljiErrorProvider, 3, 32);
        }

        private void TxtPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (_validation.Required(sender, e, radniciDetaljiErrorProvider))
                if (_validation.IsLetterOnly(sender, e, radniciDetaljiErrorProvider))
                    _validation.MinMaxLength(sender, e, radniciDetaljiErrorProvider, 3, 32);
        }

        private void TxtJMBG_Validating(object sender, CancelEventArgs e)
        {
            if (_validation.Required(sender, e, radniciDetaljiErrorProvider))
                if (_validation.IsNumberOnly(sender, e, radniciDetaljiErrorProvider))
                    _validation.MinMaxLength(sender, e, radniciDetaljiErrorProvider, 13, 13);
        }

        private void TxtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (_validation.Required(sender, e, radniciDetaljiErrorProvider))
                    _validation.MinMaxLength(sender, e, radniciDetaljiErrorProvider, 6, 64);
        }

        private void TxtBrojTelefona_Validating(object sender, CancelEventArgs e)
        {
            if (_validation.Required(sender, e, radniciDetaljiErrorProvider))
                if (_validation.IsNumberOnly(sender, e, radniciDetaljiErrorProvider))
                    _validation.MinMaxLength(sender, e, radniciDetaljiErrorProvider, 3, 16);
        }

        private async void TxtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (_validation.Required(sender, e, radniciDetaljiErrorProvider))
                if (_validation.MinMaxLength(sender, e, radniciDetaljiErrorProvider, 3, 32))
                {
                    var clanList =await _apiService.Get<List<Model.Osoba>>(new OsobaSearchReqeust() { Username = txtUserName.Text });

                    if(_id==null)
                    {
                        if (clanList.Count > 0)
                        {
                            ((TextBox)sender).Focus();
                            e.Cancel = true;
                            radniciDetaljiErrorProvider.SetError(((TextBox)sender),"Korisnicko ime je vec iskoristeno");
                        }
                    }

                }
        }

        private void TxtPassword_Validating(object sender, CancelEventArgs e)
        {
            if(_id == null)
             if (_validation.Required(sender, e, radniciDetaljiErrorProvider))
                    _validation.MinMaxLength(sender, e, radniciDetaljiErrorProvider, 5, 32);
        }

        private void TxtSatnica_Validating(object sender, CancelEventArgs e)
        {
            if(isRadnik)
             if (_validation.Required(sender, e, radniciDetaljiErrorProvider))
                if (_validation.IsNumberOnly(sender, e, radniciDetaljiErrorProvider))
                    _validation.MinMaxValue(sender, e, radniciDetaljiErrorProvider, 1, 100);
        }

        private void TxtSpecijalizacija_Validating(object sender, CancelEventArgs e)
        {
            if(isTrener)
            if (_validation.Required(sender, e, radniciDetaljiErrorProvider))
                if (_validation.IsLetterOnly(sender, e, radniciDetaljiErrorProvider))
                    _validation.MinMaxLength(sender, e, radniciDetaljiErrorProvider, 1, 100);
        }

        private void TxtPasswordPotvrda_Validating(object sender, CancelEventArgs e)
        {
            if (_id == null)
                if (_validation.Required(sender, e, radniciDetaljiErrorProvider))
                    if (_validation.MinMaxLength(sender, e, radniciDetaljiErrorProvider, 5, 32))
                    {
                        if (txtPassword.Text != txtPasswordPotvrda.Text)
                        {
                            e.Cancel = true;
                            //radniciDetaljiErrorProvider.SetError((TextBox)sender, null);
                            MessageBox.Show("Passwor-i se ne poklapaju");
                            
                            return;
                        }
                        else
                        {
                            e.Cancel = false;
                            radniciDetaljiErrorProvider.SetError((TextBox)sender, null);
                        }

                    }
        }


        private void CbUloga_SelectedIndexChanged(object sender, EventArgs e)
        {
            var obj = (Wellness.Model.Uloga)cbUloga.SelectedItem;
            
            if (obj.Naziv == "Trener")
            {
                txtSpecijalizacija.Visible = true;
                txtSpecijalizacija.Enabled = true;
                lblSpecijalizacija.Visible = true;
                isTrener = true;
            }
            else
            {
                txtSpecijalizacija.Visible = false;
                txtSpecijalizacija.Enabled = false;
                lblSpecijalizacija.Visible = false;
                isTrener = false;
            }

            if (obj.Naziv != "Clan")
            {
                txtSatnica.Visible = true;
                txtSatnica.Enabled = true;
                lblSatnica.Visible = true;
                isRadnik = true;
            }
            else
            {
                txtSatnica.Visible = false;
                txtSatnica.Enabled = false;
                lblSatnica.Visible = false;
                isRadnik = false;
            }

        }

        private void FrmRadniciDetalji_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }







    }
    public class Spol {

        public string spol { get; set; }

    }
}
