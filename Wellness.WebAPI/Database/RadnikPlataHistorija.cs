using System;
using System.Collections.Generic;

namespace Wellness.WebAPI.Database
{
    public partial class RadnikPlataHistorija
    {
        public int UplataZaGodinu { get; set; }
        public int UplataZaMjesec { get; set; }
        public DateTime DatumUplate { get; set; }
        public int RadnihSati { get; set; }
        public decimal Satnica { get; set; }
        public int RadnikId { get; set; }

        public virtual Radnik Radnik { get; set; }
    }
}
