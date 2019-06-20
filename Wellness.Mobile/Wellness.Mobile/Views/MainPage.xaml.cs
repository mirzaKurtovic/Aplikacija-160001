using Wellness.Mobile.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Wellness.Mobile.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        Model.Requests.ClanViewRequest _clan = null;
        public MainPage(Model.Requests.ClanViewRequest clan)
        {
            InitializeComponent();

            _clan = clan;

            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.Opis, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Opis:
                        MenuPages.Add(id, new NavigationPage(new ItemsPage()));
                        break;
                    case (int)MenuItemType.TreningPage:
                        MenuPages.Add(id, new NavigationPage(new TreningPage(_clan)));
                        break;
                    case (int)MenuItemType.Clanarine:
                        MenuPages.Add(id, new NavigationPage(new ClanarinaPage(_clan)));
                        break;
                    case (int)MenuItemType.MojProfil:
                        MenuPages.Add(id, new NavigationPage(new RegisterPage(_clan)));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}