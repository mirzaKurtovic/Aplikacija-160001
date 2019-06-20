using System;
using System.Collections.Generic;

namespace Wellness.WebAPI.Database
{
    public partial class Radnik
    {
        public Radnik()
        {
            RadnikPlataHistorija = new HashSet<RadnikPlataHistorija>();
            Trener = new HashSet<Trener>();
        }

        public int Id { get; set; }
        public int OsobaId { get; set; }
        public decimal? Satnica { get; set; }
        public DateTime? DatumZaposlenja { get; set; }

        public virtual Osoba Osoba { get; set; }
        public virtual ICollection<RadnikPlataHistorija> RadnikPlataHistorija { get; set; }
        public virtual ICollection<Trener> Trener { get; set; }
    }
}
