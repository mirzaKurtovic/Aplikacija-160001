using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Wellness.Model.Requests
{
    public class ClanarinaSearchRequest
    {
        public int? UplataZaMjesec { get; set; }
        public int? UplataZaGodinu { get; set; }
        public int PaketID { get; set; }
        public int ClanID { get; set; }
    }
}
