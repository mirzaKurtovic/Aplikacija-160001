using System;
using System.Collections.Generic;
using System.Text;

namespace Wellness.Model.Requests
{
    public class TipTreningaInsertRequest
    {
        public string TipTreninga1 { get; set; }
        public string Opis { get; set; }
        public byte[] Image { get; set; }
    }
}
