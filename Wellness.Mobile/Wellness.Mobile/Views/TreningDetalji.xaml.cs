using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wellness.Mobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Wellness.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TreningDetalji : ContentPage
    {
        Model.Requests.ClanViewRequest _clan;
        APIService _apiService_Trening;

        public TreningDetalji(Wellness.Model.Trening trening,Wellness.Model.Requests.ClanViewRequest clan)
        {
            InitializeComponent();

            _clan = clan;
            _apiService_Trening = new APIService("Trening");
            BindingContext = new TreningDetaljiViewModel(trening,clan);
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Wellness.Mobile.Models.TreningModel;
            var trening = await _apiService_Trening.GetById<Wellness.Model.Trening>(item.Id);




            await Navigation.PushAsync(new TreningDetalji(trening, _clan));
        }
    }
}