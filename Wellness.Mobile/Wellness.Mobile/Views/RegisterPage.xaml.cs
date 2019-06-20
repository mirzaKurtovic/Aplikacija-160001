using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wellness.Mobile.ViewModels;
using Wellness.Model.Requests;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Wellness.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage(ClanViewRequest clan)
        {
            InitializeComponent();

            BindingContext = new RegisterViewModel(clan);


            if (clan != null)
            {

                EntryPassword.IsVisible = false;
                LabelPasswor.IsVisible = false;
                EntryPasswordPotvrda.IsVisible = false;
                LabelPasswordPotvrda.IsVisible = false;
                RegisterButton.Text = "Spasi";
            }

    }

        private void Button_Clicked(object sender, EventArgs e)
        {
            
        }
    }
}