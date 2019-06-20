using System;
using System.Collections.Generic;

namespace Wellness.WebAPI.Database
{
    public partial class Uloga
    {
        public Uloga()
        {
            Osoba = new HashSet<Osoba>();
        }

        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }

        public virtual ICollection<Osoba> Osoba { get; set; }
    }
}
