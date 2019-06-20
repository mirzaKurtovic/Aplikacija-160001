using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Wellness.Model.Requests;
using Xamarin.Forms;

namespace Wellness.Mobile.ViewModels
{
    public class ClanarinaViewModel:BaseViewModel
    {
        private readonly APIService _apiService;
        private readonly Model.Requests.ClanViewRequest _clan;
        public ClanarinaViewModel(Model.Requests.ClanViewRequest clan)
        {
            _apiService = new APIService("Clanarina");
            _clan = clan;
            InitCommand = new Command(async () => await Init());
        }
        public ClanarinaViewModel()
        {

        }


        public ObservableCollection<Wellness.Mobile.Models.ClanarinaModel> clanarine { get; set; } = new ObservableCollection<Wellness.Mobile.Models.ClanarinaModel>();


        public ICommand InitCommand { get; set; }
        public async Task Init()
        {
           


            var clanarinaSearchRequest = new ClanarinaSearchRequest()
            {
                ClanID = _clan.Id
            };

        var clanarinaList = await _apiService.Get<IEnumerable<Model.Clanarina>>(clanarinaSearchRequest);
            clanarine.Clear();
            foreach (Model.Clanarina x in clanarinaList)
            {
                var clanarina = new Wellness.Mobile.Models.ClanarinaModel()
                {
                    DatumUplate = x.DatumUplate.ToString("dd.MM.yyyy"),
                    IznosUplate = Math.Round(x.IznosUplate, 2).ToString(),
                    Paket = x.Paket.Naziv,
                    UplataZaMjesec = x.UplataZaMjesec.ToString(),
                    UplataZaGodinu = x.UplataZaMjesec.ToString()
                };

                clanarine.Add(clanarina);
            }
        }


    }
}
