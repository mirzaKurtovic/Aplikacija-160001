using System;
using System.Collections.Generic;
using System.Text;

namespace Wellness.Model.Requests
{
    public class ClanInsertRequest
    {
        public bool? Aktivan { get; set; }
        public DateTime? DatumRegistracije { get; set; }
        public int OsobaId { get; set; }

    }
}
