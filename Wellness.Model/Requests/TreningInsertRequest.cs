using System;
using System.Collections.Generic;
using System.Text;

namespace Wellness.Model.Requests
{
    public class TreningInsertRequest
    {
    

        //public int Id { get; set; }
        public DateTime DatumTreninga { get; set; }
        public DateTime VrijemePocetak { get; set; }
        public DateTime VrijemeKraj { get; set; }
        public int MaksimalnoPrisutnih { get; set; }
        public int TrenerId { get; set; }
        public int TipTreningaId { get; set; }
        public bool? Odrzan { get; set; }






    }
}
