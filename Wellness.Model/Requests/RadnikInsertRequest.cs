using System;
using System.Collections.Generic;
using System.Text;

namespace Wellness.Model.Requests
{
    public class RadnikInsertRequest
    {
        public RadnikInsertRequest()
        {
            DatumZaposlenja = DateTime.Now;
        }

        public int OsobaId { get; set; }
        public decimal Satnica { get; set; }
        public DateTime DatumZaposlenja { get; set; }
    }
}
