using System;
using System.Collections.Generic;

namespace Wellness.WebAPI.Database
{
    public partial class Grad
    {
        public Grad()
        {
            Osoba = new HashSet<Osoba>();
        }

        public int Id { get; set; }
        public string Grad1 { get; set; }

        public virtual ICollection<Osoba> Osoba { get; set; }
    }
}
