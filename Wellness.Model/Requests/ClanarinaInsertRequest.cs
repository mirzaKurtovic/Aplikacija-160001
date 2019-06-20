using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Wellness.Model.Requests
{
    public class ClanarinaInsertRequest
    {
        public int UplataZaMjesec { get; set; }
        public int UplataZaGodinu { get; set; }
        public DateTime DatumUplate { get; set; }
        public double IznosUplate { get; set; }
        public int PaketID { get; set; }
        public int ClanID { get; set; }
    }
}
