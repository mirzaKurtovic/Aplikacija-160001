using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Wellness.Mobile.AsyncHelper;
using Wellness.Mobile.Views;
using Wellness.Model.Requests;
using Xamarin.Forms;

namespace Wellness.Mobile.ViewModels
{
    public class RegisterViewModel : BaseViewModel
    {

        public RegisterModel  registerModel { get; set; }
        public APIService _apiService;
        public APIService _apiService_Clan;
        public Model.Osoba _osoba { get; set; }
        public Model.Requests.ClanViewRequest _clan { get; set; }
        public RegisterViewModel(ClanViewRequest clan = null)
        {
            

            _apiService = new APIService("Osoba");
            _apiService_Clan = new APIService("Clan");
            registerModel = new RegisterModel();
            RegisterCommand = new Command(async () => await Register());
            if (clan != null)
            {
                var Osoba = AsyncHelpers.RunSync<Wellness.Model.Osoba>(() => _apiService.GetById<Wellness.Model.Osoba>(clan.OsobaId));
                _osoba = Osoba;
                _clan = clan;
                registerModel.Ime = Osoba.Ime;
                registerModel.Prezime = Osoba.Prezime;
                registerModel.KorisnickoIme = Osoba.KorisnickoIme;
                registerModel.BrojTelefona = Osoba.BrojTelefona;
                registerModel.Email = Osoba.Email;
                registerModel.JMBG = Osoba.Jmbg;

            }



        }
        public RegisterViewModel()
        {

        }



        

        /*
        var clanInsertRequest = new Model.Requests.ClanInsertRequest()
        {
            Aktivan = true,
            DatumRegistracije=DateTime.Now,
            

        };
        */
        public ICommand RegisterCommand { get; set; }
        public async Task Register()
        {
            IsBusy = true;


            #region primitiveValidation
            if (registerModel.Ime != null)
            {
                if (registerModel.Ime.Length > 32)
                {
                    await PopupNavigation.Instance.PushAsync(new PopupView("Error", "Ime ne smije biti duze od 32 karaktera"));
                    return;
                }
            }
            else
            {
                await PopupNavigation.Instance.PushAsync(new PopupView("Error", "Ime obavezno"));
                return;
            }

            if (registerModel.Prezime != null)
            {
                if (registerModel.Prezime.Length > 32)
                {
                    await PopupNavigation.Instance.PushAsync(new PopupView("Error", "Prezime ne smije biti duze od 32 karaktera"));
                    return;
                }
            }
            else
            {
                await PopupNavigation.Instance.PushAsync(new PopupView("Error", "Preziem obavezno"));
                return;
            }

            if (registerModel.BrojTelefona != null)
            {
                if (!registerModel.BrojTelefona.Any(char.IsDigit))
                {
                    await PopupNavigation.Instance.PushAsync(new PopupView("Error", "Broj telefona mora biti sastavljen od brojeva"));
                    return;
                }
            }
            else
            {
                await PopupNavigation.Instance.PushAsync(new PopupView("Error", "Broj telefona obavezan"));
                return;
            }

            if (registerModel.JMBG!= null)
            {
                if (registerModel.JMBG.Length != 13)
                {
                    await PopupNavigation.Instance.PushAsync(new PopupView("Error", "JMBG mora biti 13 karaktera"));
                    return;
                }
            }
            else
            {
                await PopupNavigation.Instance.PushAsync(new PopupView("Error", "JMBG obavezan"));
                return;
            }

            if (registerModel.JMBG != null)
            {
                if (!registerModel.JMBG.Any(char.IsDigit))
                {
                    await PopupNavigation.Instance.PushAsync(new PopupView("Error", "JMBG mora biti sastavljen od brojeva"));
                    return;
                }
            }

            if (string.IsNullOrEmpty(registerModel.KorisnickoIme))
            {
                await PopupNavigation.Instance.PushAsync(new PopupView("Error", "Korisnicko ime obavezno"));
                return;
            }

           

            var clanList = await _apiService.Get<List<Wellness.Model.Osoba>>(new OsobaSearchReqeust() { Username = registerModel.KorisnickoIme });


            if (_clan == null)
            {
                if (clanList.Count != 0)
                {
                    await PopupNavigation.Instance.PushAsync(new PopupView("Error", "Korisnicko ime vec iskoristeno"));
                    return;
                }

                if(registerModel.Password==null || registerModel.PasswordPotvrda==null)
                {
                    await PopupNavigation.Instance.PushAsync(new PopupView("Error", "Password/Password-potvrda obavezni !"));
                    return;
                }
                if (registerModel.Password != registerModel.PasswordPotvrda)
                {
                    await PopupNavigation.Instance.PushAsync(new PopupView("Error", "Password-i se ne podudaraju"));
                    return;
                }
            }
            

            #endregion primitiveValidation


            Model.Requests.OsobaInsertRequest osobaInsertRequest = new Model.Requests.OsobaInsertRequest()
            {

                Ime = registerModel.Ime,
                Prezime = registerModel.Prezime,
                BrojTelefona = registerModel.BrojTelefona,
                KorisnickoIme=registerModel.KorisnickoIme,
                Jmbg=registerModel.JMBG,
                Email=registerModel.Email,
                UlogaId = 4//moguci bug nece uvjek biti 4 u bazi
            };

            if (_osoba == null)
            {



                osobaInsertRequest.Password = registerModel.Password;
                osobaInsertRequest.PasswordPotvrda = registerModel.PasswordPotvrda;


                var osoba = await _apiService.Insert<Model.Osoba>(osobaInsertRequest);

                Model.Requests.ClanInsertRequest clanInsertRequest = new Model.Requests.ClanInsertRequest()
                {
                    Aktivan = true,
                    DatumRegistracije = DateTime.Now,
                    OsobaId = osoba.Id,
                };
                var clan = await _apiService_Clan.Insert<Model.Requests.ClanViewRequest>(clanInsertRequest);
                _clan = clan;

                APIService._username = osobaInsertRequest.KorisnickoIme;
                APIService._password = osobaInsertRequest.Password;

                await PopupNavigation.Instance.PushAsync(new PopupView("Success", "Uspjesna registracija"));
            }
            else
            {
                var osoba = await _apiService.Update<Model.Osoba>(_osoba.Id,osobaInsertRequest);
                await PopupNavigation.Instance.PushAsync(new PopupView("Success", "Uspjesno ste azurirali profil"));
            }
            Application.Current.MainPage = new MainPage(_clan);

            IsBusy = false;

            //popup za uspjesnu registraciju
            //redirect na main page

        }

    }
    public class RegisterModel
    {
        public string _Ime { get; set; }
        public string Ime
        {
            get { return _Ime; }
            set {
                _Ime = value;
            }
        }
        public string Prezime { get;
            set; }

        public string BrojTelefona { get; set; }

        public string Password { get; set; }

        public string PasswordPotvrda { get; set; }
        public string JMBG { get; set; }
        public string Email { get; set; }
        public string KorisnickoIme { get; set; }



    }

}
