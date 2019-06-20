using System;
using System.Collections.Generic;

namespace Wellness.WebAPI.Database
{
    public partial class Osoba
    {
        public Osoba()
        {
            Clan = new HashSet<Clan>();
            Radnik = new HashSet<Radnik>();
        }

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
        public string LozinkaSalt { get; set; }
        public string LozinkaHash { get; set; }
        public int? UlogaId { get; set; }

        public virtual Grad Grad { get; set; }
        public virtual Uloga Uloga { get; set; }
        public virtual ICollection<Clan> Clan { get; set; }
        public virtual ICollection<Radnik> Radnik { get; set; }
    }
}
