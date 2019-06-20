using System;
using System.Collections.Generic;
using System.Text;

namespace Wellness.Mobile.Models
{
    public class PrisutniModel
    {
        public string DatumPrijave { get; set; }

        public string Ime { get; set; }
        public string Prezime { get; set; }
        public bool? Prisustvovao { get; set; }
        public int Id { get; set; }
        public int? Ocjena { get; set; }



        public string OcjenaIspis { get { if (Ocjena == null) return " - "; else return Ocjena.ToString(); } }
        public string PrisustvovaoIspis { get { if(Prisustvovao==null) return " - "; else return Prisustvovao.ToString(); } }
        public string ImePrezime { get { return Ime + " " + Prezime; } }
    }
}
