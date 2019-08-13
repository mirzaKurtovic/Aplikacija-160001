using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Wellness.Mobile.AsyncHelper;
using Wellness.Model.Requests;
using Xamarin.Forms;

namespace Wellness.Mobile.ViewModels
{
    public class ClanarinaViewModel:BaseViewModel
    {
        private readonly APIService _apiService;
        private readonly Model.Requests.ClanViewRequest _clan;

        public ICommand InitCommand { get; set; }

        public ObservableCollection<Wellness.Mobile.Models.ClanarinaModel> clanarine { get; set; } = new ObservableCollection<Wellness.Mobile.Models.ClanarinaModel>();
        public ObservableCollection<int> UplataZaGodinu { get; set; } = new ObservableCollection<int>();
        public ObservableCollection<int> UplataZaMjesec { get; set; } = new ObservableCollection<int>();
        public ObservableCollection<string> SortirajPo { get; set; } = new ObservableCollection<string>();
        private int? SelectedUplataZaMjesec { get; set; }
        public int? _SelectedUplataZaMjesec
        {
            get { return SelectedUplataZaMjesec; }
            set
            {
                SelectedUplataZaMjesec = value;
                if(value!=null)
                InitCommand.Execute(null);
            }
        }
        private int? SelectedUplataZaGodinu { get; set; }
        public int? _SelectedUplataZaGodinu
        {
            get { return SelectedUplataZaGodinu; }
            set
            {
                SelectedUplataZaGodinu = value;
                if (value != null)
                    InitCommand.Execute(null);
            }
        }

        private string SelectedSortirajPo { get; set; }
        public string _SelectedSortirajPo
        {
            get { return SelectedSortirajPo; }
            set
            {

                SelectedSortirajPo = value;
                if (value != null)
                {
                    InitCommand.Execute(null);
                }
            }
        }


        public ClanarinaViewModel(Model.Requests.ClanViewRequest clan)
        {
            _apiService = new APIService("Clanarina");
            _clan = clan;

            #region filters
            //UplataZaGodinu.Add(0);
            //UplataZaMjesec.Add(0);
            SortirajPo.Add("Cijena rast.");
            SortirajPo.Add("Cijena opad.");
            SortirajPo.Add("Datum uplate rast.");
            SortirajPo.Add("Datum uplate opad.");

            
            List<int> upG = new List<int>();
            List<int> upM = new List<int>();
            var clanarinaFilter = AsyncHelpers.RunSync<List<Wellness.Model.Clanarina>>(() => _apiService.Get<List<Model.Clanarina>>(null));

            clanarinaFilter=clanarinaFilter.OrderBy(c => c.UplataZaGodinu).ToList();
            upG = clanarinaFilter.Select(c => c.UplataZaGodinu).Distinct().ToList();

            clanarinaFilter = clanarinaFilter.OrderBy(c => c.UplataZaMjesec).ToList();
            upM = clanarinaFilter.Select(c => c.UplataZaMjesec).Distinct().ToList();


            foreach (int x in upG)
            {
                UplataZaGodinu.Add(x);
            }

            foreach (int x in upM)
            {
                UplataZaMjesec.Add(x);
            }
            #endregion filters



            InitCommand = new Command(async () => await Init());


            if (UplataZaGodinu[0] != 0)
                _SelectedUplataZaGodinu = UplataZaGodinu[0];
            if (UplataZaMjesec[0] != 0)
                _SelectedUplataZaMjesec = UplataZaMjesec[0];
            _SelectedSortirajPo = SortirajPo[0];


           


           



        }
        public ClanarinaViewModel()
        {

        }








        public async Task Init()
        {



            var clanarinaSearchRequest = new ClanarinaSearchRequest()
            {
                ClanID = _clan.Id
            };

            var clanarinaList = await _apiService.Get<IEnumerable<Model.Clanarina>>(clanarinaSearchRequest);




            if (_SelectedSortirajPo == "Cijena rast.")
                clanarinaList=clanarinaList.OrderBy(c=>c.IznosUplate);
            if (_SelectedSortirajPo == "Cijena opad.")
                clanarinaList = clanarinaList.OrderByDescending(c => c.IznosUplate);
            if (_SelectedSortirajPo == "Datum uplate rast.")
                clanarinaList = clanarinaList.OrderBy(c=>c.DatumUplate);
            if (_SelectedSortirajPo == "Datum uplate opad.")
                clanarinaList = clanarinaList.OrderByDescending(c => c.DatumUplate);

            clanarine.Clear();
            foreach (Model.Clanarina x in clanarinaList)
            {
                if (x.UplataZaMjesec == _SelectedUplataZaMjesec && x.UplataZaGodinu == _SelectedUplataZaGodinu)
                {
                    var clanarina = new Wellness.Mobile.Models.ClanarinaModel()
                    {
                        DatumUplate = x.DatumUplate.ToString("dd.MM.yyyy"),
                        IznosUplate = Math.Round(x.IznosUplate, 2).ToString(),
                        Paket = x.Paket.Naziv,
                        UplataZaMjesec = x.UplataZaMjesec.ToString(),
                        UplataZaGodinu = x.UplataZaGodinu.ToString()
                    };

                    clanarine.Add(clanarina);
                }
            }
        }


    }
}
