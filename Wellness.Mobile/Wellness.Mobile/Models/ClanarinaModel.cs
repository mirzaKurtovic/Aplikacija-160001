using System;
using System.Collections.Generic;
using System.Text;

namespace Wellness.Mobile.Models
{
    public class ClanarinaModel
    {
        public string UplataZaMjesec { get; set; }
        public string UplataZaGodinu { get; set; }
        public string DatumUplate { get; set; }
        public string IznosUplate { get; set; }
        public string Paket { get; set; }

        public string UplataMjesecGodina { get { return "Uplata za " + UplataZaMjesec + ". mjesec " + UplataZaGodinu + " godine"; }  }
        public string PaketIznosUplate { get { return Paket + "  " + IznosUplate + " KM"; } }
    }
}
