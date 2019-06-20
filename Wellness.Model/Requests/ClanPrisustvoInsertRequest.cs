using System;
using System.Collections.Generic;
using System.Text;

namespace Wellness.Model.Requests
{
    public class ClanPrisustvoInsertRequest
    {
        public ClanPrisustvoInsertRequest()
        {
            Prisustvovao = false;
        }

        public int ClanId { get; set; }
        public int TreningId { get; set; }
        public bool? Prisustvovao { get; set; }
        public int? Ocjena { get; set; }

    }
}
