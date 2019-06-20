using System;
using System.Collections.Generic;
using System.Text;

namespace Wellness.Mobile.Models
{
    public enum MenuItemType
    {
        Opis,
        TreningPage,
        Clanarine,
        MojProfil
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
