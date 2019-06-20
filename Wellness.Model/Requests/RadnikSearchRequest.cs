using System;
using System.Collections.Generic;
using System.Text;

namespace Wellness.Model.Requests
{
    public class RadnikSearchRequest
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int? UlogaId { get; set; }
        public int? OsobaId { get; set; }
    }
}
