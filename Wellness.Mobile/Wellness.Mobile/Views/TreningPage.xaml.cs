using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wellness.Mobile.Models;
using Wellness.Mobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Wellness.Model.Requests;
using Rg.Plugins.Popup.Services;

namespace Wellness.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TreningPage : ContentPage
    {
        private TreningViewModel model = null;
        Model.Requests.ClanViewRequest _clan = null;
        APIService _apiService_Trening = new APIService("Trening");
        APIService _apiService_ClanPrisustvo = new APIService("ClanPrisustvo");
        public TreningPage(Model.Requests.ClanViewRequest clan)
        {
            InitializeComponent();

            _clan = clan;
            BindingContext = model = new TreningViewModel(clan);

            

        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();

            
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            var item = e.SelectedItem as Wellness.Mobile.Models.TreningModel;
            var trening = await _apiService_Trening.GetById<Wellness.Model.Trening>(item.Id);




            await Navigation.PushAsync(new TreningDetalji(trening,_clan));
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var item  = (TreningModel)((Button)sender).CommandParameter;

            if (item.Ocjena < 1 || item.Ocjena > 5)
            {
                await PopupNavigation.Instance.PushAsync(new PopupView("Error", "Ocjena mora biti izmedju 1 i 5"));
            }
            else
            {
                var clanPrisustvoInsertRequest = new Wellness.Model.Requests.ClanPrisustvoInsertRequest()
                {
                    ClanId = item.ClanId,
                    Ocjena = item._Ocjena,
                    Prisustvovao = true,
                    TreningId = item.Id
                };

                var result =await _apiService_ClanPrisustvo.Update<Wellness.Model.ClanPrisustvo>(item.PrisustvoId,clanPrisustvoInsertRequest);


                ((Button)sender).IsEnabled = false;
                item.Ocjenjen = true;

            }

        }

    }
}