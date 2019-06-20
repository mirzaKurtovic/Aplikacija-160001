using System;
using System.Collections.Generic;

namespace Wellness.Model
{
    public partial class Clanarina
    {
        public int Id { get; set; }
        public int UplataZaMjesec { get; set; }
        public int UplataZaGodinu { get; set; }
        public DateTime DatumUplate { get; set; }
        public decimal IznosUplate { get; set; }
        public int ClanId { get; set; }
        public int PaketId { get; set; }

        public virtual Clan Clan { get; set; }
        public virtual Paket Paket { get; set; }
    }
}
