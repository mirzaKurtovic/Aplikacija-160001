using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Wellness.Mobile.ViewModels
{
    public class PopupViewModel
    {
        public PopupModel PopupModel { get; set; }


        public PopupViewModel(string type,string text)
        {
            PopupModel = new PopupModel()
            {
                text = text,
                type = type
            };
            CloseCommand = new Command(async () => await Close());
        }
        public PopupViewModel()
        {

        }

        public ICommand CloseCommand { get; set; }
        public async Task Close()
        {
          //  await Application.Current.MainPage.Navigation.PopAsync();
        }



    }
    public class PopupModel
    {
       public string type { get; set; }
       public string text { get; set; }

    }
}
