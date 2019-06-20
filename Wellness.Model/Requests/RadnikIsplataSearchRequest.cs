using System;
using System.Collections.Generic;
using System.Text;

namespace Wellness.Model.Requests
{
    public class RadnikIsplataSearchRequest
    {
        public int? radnikId { get; set; }
        public int? UplataZaMjesec { get; set; }
        public int? UplataZaGodinu { get; set; }
    }
}
