using System;
using System.Collections.Generic;

namespace Wellness.Model
{
    public partial class Radnik
    {
    
        public int Id { get; set; }
        public int OsobaId { get; set; }
        public decimal Satnica { get; set; }
        public DateTime DatumZaposlenja { get; set; }

        public virtual Osoba Osoba { get; set; }

        public string Display
        {
            get
            {
                if (Id == 0)
                    return "svi";
                if (Osoba != null)
                    return Osoba.Ime + " " + Osoba.Prezime;
                else
                    return "-";
            }

        }
    }
}
