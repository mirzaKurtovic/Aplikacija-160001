using System;
using System.Collections.Generic;
using System.Text;

namespace Wellness.Model.Requests
{
    public class TreningSearchRequest
    {
        public int TipTreningaID { get; set; }

        public int? TrenerID { get; set; }

        public DateTime DatumTreninga { get; set; }

        public DateTime? VrijemePocetak { get; set; }
        public DateTime? VrijemeKraj { get; set; }
    }
}
