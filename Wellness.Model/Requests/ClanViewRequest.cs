using System;
using System.Collections.Generic;
using System.Text;

namespace Wellness.Model.Requests
{
    public class ClanViewRequest
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int? OsobaId { get; set; }
        public string Display
        {
            get
            {
                if (Id != 0)
                    return Ime + " " + Prezime + " #" + Id.ToString();
                else
                    return Ime;

            }
        }
    }
}
