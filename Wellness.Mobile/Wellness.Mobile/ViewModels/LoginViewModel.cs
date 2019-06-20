using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Wellness.Mobile.Views;
using Wellness.Model.Requests;
using Xamarin.Forms;

namespace Wellness.Mobile.ViewModels
{
    class LoginViewModel:BaseViewModel
    {
        APIService _apiService=new APIService("Autentifikacija");
        APIService _apiService_Clan = new APIService("Clan");

        public LoginViewModel()
        {

            LoginCommand = new Command(async () => await Login());
            RegisterCommand = new Command(async () => await Register());
        }
        string _username = string.Empty;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }

        string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        public ICommand LoginCommand { get; set; }
        public ICommand RegisterCommand { get; set; }

        async Task Register()
        {

            Application.Current.MainPage = new RegisterPage(null);

        }

        async Task Login()
        {
            IsBusy = true;

            APIService._username = Username;
            APIService._password = Password;
            var request = new AutentifikacijaRequest()
            {
                password = Password,
                username = Username
            };


            if (!string.IsNullOrEmpty(Password) && !string.IsNullOrEmpty(Username))
            {
                var osoba = await _apiService.Get<Wellness.Model.Osoba>(request);
                if (osoba == null)
                {
                    await PopupNavigation.Instance.PushAsync(new PopupView("Error", "Pogresan Username ili Password"));
                }
                else
                {
                    if (osoba.Uloga.Naziv == "Clan")
                    {
                        var ClanSearchRequest = new ClanSearchRequest()
                        {

                            OsobaId = osoba.Id,
                        };

                        var ClanList = await _apiService_Clan.Get<List<Model.Requests.ClanViewRequest>>(ClanSearchRequest);
                        var clan = ClanList[0];
                        Application.Current.MainPage = new MainPage(clan);

                    }
                    else
                    {
                        await PopupNavigation.Instance.PushAsync(new PopupView("Error", "Niste autorizovani"));
                    }
                }
            }
            else
            {
                if(string.IsNullOrEmpty(Password))
                    await PopupNavigation.Instance.PushAsync(new PopupView("Error", "Password obavezan"));
                else
                if (string.IsNullOrEmpty(Username))
                    await PopupNavigation.Instance.PushAsync(new PopupView("Error", "Username obavezan"));

            }
        }
    }



    
}
