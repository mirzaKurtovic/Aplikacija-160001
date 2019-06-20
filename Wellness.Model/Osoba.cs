using System;
using System.Collections.Generic;

namespace Wellness.Model
{
    public partial class Osoba
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime? DatumRodenja { get; set; }
        public string Spol { get; set; }
        public string Jmbg { get; set; }
        public string Email { get; set; }
        public string BrojTelefona { get; set; }
        public int? GradId { get; set; }
        public string KorisnickoIme { get; set; }
        public string Display { get { return Ime + " " + Prezime; } }
        public int UlogaId { get; set; }

        public virtual Uloga Uloga { get; set; }

    }
}
