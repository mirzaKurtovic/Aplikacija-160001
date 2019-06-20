using System;
using System.Collections.Generic;

namespace Wellness.WebAPI.Database
{
    public partial class Trener
    {
        public Trener()
        {
            Trening = new HashSet<Trening>();
        }

        public int Id { get; set; }
        public int RadnikId { get; set; }
        public string Specializacija { get; set; }

        public virtual Radnik Radnik { get; set; }
        public virtual ICollection<Trening> Trening { get; set; }
    }
}
