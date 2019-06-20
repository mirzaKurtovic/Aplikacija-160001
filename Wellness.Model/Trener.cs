using System;
using System.Collections.Generic;

namespace Wellness.Model
{
    public partial class Trener
    {

        public int Id { get; set; }
        public int RadnikId { get; set; }
        public string Specializacija { get; set; }

        public virtual Radnik Radnik { get; set; }

    }
}
