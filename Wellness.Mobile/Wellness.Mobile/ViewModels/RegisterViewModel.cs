using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
