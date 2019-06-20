using System;
using System.Collections.Generic;

namespace Wellness.WebAPI.Database
{
    public partial class Clan
    {
        public Clan()
        {
            ClanPrisustvo = new HashSet<ClanPrisustvo>();
            Clanarina = new HashSet<Clanarina>();
        }

        public int Id { get; set; }
        public bool? Aktivan { get; set; }
        public DateTime? DatumRegistracije { get; set; }
        public int OsobaId { get; set; }

        public virtual Osoba Osoba { get; set; }
        public virtual ICollection<ClanPrisustvo> ClanPrisustvo { get; set; }
        public virtual ICollection<Clanarina> Clanarina { get; set; }
    }
}
