using System;
using System.Collections.Generic;
using System.Text;

namespace Wellness.Model.Requests
{
    public class RadnikIsplataInsertRequest
    {
        public int UplataZaGodinu { get; set; }
        public int UplataZaMjesec { get; set; }
        public DateTime DatumUplate { get; set; }
        public int RadnihSati { get; set; }
        public decimal Satnica { get; set; }
        public int RadnikId { get; set; }
    }
}
