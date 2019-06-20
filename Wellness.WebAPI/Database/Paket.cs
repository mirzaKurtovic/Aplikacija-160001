using System;
using System.Collections.Generic;

namespace Wellness.WebAPI.Database
{
    public partial class Paket
    {
        public Paket()
        {
            Clanarina = new HashSet<Clanarina>();
        }

        public int Id { get; set; }
        public string Naziv { get; set; }
        public decimal? Cijena { get; set; }
        public string Opis { get; set; }

        public virtual ICollection<Clanarina> Clanarina { get; set; }
    }
}
