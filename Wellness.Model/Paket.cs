using System;
using System.Collections.Generic;

namespace Wellness.Model
{
    public partial class Paket
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public decimal Cijena { get; set; }
        public string Opis { get; set; }

        public string Display
        {
            get
            {
                if (Id != 0)
                    return Naziv + " " + Math.Round(Cijena,2) + " KM";
                else
                    return Naziv;
            }
        }
    }
}
