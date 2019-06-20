using System;
using System.Collections.Generic;
using System.Text;

namespace Wellness.Mobile.Models
{
    public class TreningDetaljiModel
    {
        public TreningModel TreningModel { get; set; }

        public List<TreningModel> RecommendedTrening { get; set; }

        public string RecommenderText { get { return "recommended"; }  }

        public List<PrisutniModel> PrisutniModel { get; set; }
    }
}
