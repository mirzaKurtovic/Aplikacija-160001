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
    public partial class ClanarinaPage : ContentPage
    {
        private Model.Requests.ClanViewRequest _clan;
        private ClanarinaViewModel model;
        public ClanarinaPage(Model.Requests.ClanViewRequest clan)
        {
          
            InitializeComponent();

            _clan = clan;
            BindingContext = model = new ClanarinaViewModel(_clan);
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();

        }

    }
}