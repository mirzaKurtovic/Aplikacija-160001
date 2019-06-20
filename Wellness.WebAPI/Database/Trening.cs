using System;
using System.Collections.Generic;

namespace Wellness.WebAPI.Database
{
    public partial class Trening
    {
        public Trening()
        {
            ClanPrisustvo = new HashSet<ClanPrisustvo>();
        }

        public int Id { get; set; }
        public DateTime DatumTreninga { get; set; }
        public DateTime VrijemePocetak { get; set; }
        public DateTime VrijemeKraj { get; set; }
        public int MaksimalnoPrisutnih { get; set; }
        public int TrenerId { get; set; }
        public int TipTreningaId { get; set; }
        public bool? Odrzan { get; set; }

        public virtual TipTreninga TipTreninga { get; set; }
        public virtual Trener Trener { get; set; }
        public virtual ICollection<ClanPrisustvo> ClanPrisustvo { get; set; }
    }
}
