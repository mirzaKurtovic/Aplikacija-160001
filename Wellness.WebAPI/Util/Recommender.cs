using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wellness.WebAPI.Database;

namespace Wellness.WebAPI.Util
{
    public class Recommender
    {
        _160001Context _context = new _160001Context();
        Dictionary<Trening, List<ClanPrisustvo>> treningDictionary = new Dictionary<Trening, List<ClanPrisustvo>>();

        public List<Trening> GetSlicneTreninge(int treningId)
        {
            UcitajTreninge(treningId);

            List<ClanPrisustvo> ocjenePosmatranogTreninga = _context.ClanPrisustvo.Where(cp => cp.Prisustvovao == true && cp.Ocjena != null && cp.TreningId == treningId).OrderBy(cp => cp.ClanId).ToList();

            List<ClanPrisustvo> zajedniceOcjene1 = new List<ClanPrisustvo>();
            List<ClanPrisustvo> zajedniceOcjene2 = new List<ClanPrisustvo>();

            List<Trening> preporuceniTreninzi = new List<Trening>();

            foreach (var item in treningDictionary)
            {
                foreach (ClanPrisustvo x in ocjenePosmatranogTreninga)
                {

                    if (item.Value.Where(cp => cp.ClanId == x.ClanId).Count() > 0)
                    {
                        zajedniceOcjene1.Add(x);
                        zajedniceOcjene2.Add(item.Value.Where(cp => cp.ClanId == x.ClanId).FirstOrDefault());
                    }

                }


                double slicnost = GetSlicnost(zajedniceOcjene1, zajedniceOcjene2);
                if (slicnost > 0.5)
                {
                    preporuceniTreninzi.Add(item.Key);
                }
                zajedniceOcjene1.Clear();
                zajedniceOcjene2.Clear();






            }


            return preporuceniTreninzi;
        }

        public List<Model.Trening> UcitajTreninge(int treningId)
        {
            var trening = _context.Trening.Where(t => t.Id == treningId).FirstOrDefault();
            

            var treningList = _context.Trening.Where(
                t=>t.Id!=treningId
                && t.Odrzan==true
                )
                .Include(tl=>tl.TipTreninga)
                .Include(tl=>tl.Trener)
                .ThenInclude(t=>t.Radnik)
                .ThenInclude(r=>r.Osoba)
                .ToList();

            
            
  


            foreach(Trening x in treningList)
            {
                var ocjene = _context.ClanPrisustvo.Where(cp => cp.Prisustvovao == true && cp.Ocjena != null)
                    .Where(cp=>cp.TreningId==x.Id)
                    .OrderBy(cp=>cp.ClanId)
                    .Include(cp => cp.Trening)
                    .ToList();
                //&& cp.Trening.TipTreninga == x.TipTreninga && cp.Trening.DatumTreninga.DayOfWeek == x.DatumTreninga.DayOfWeek
                if (ocjene.Count > 0)
                {
                    treningDictionary.Add(x,ocjene);
                }

            }


            return null;
        }


        private double GetSlicnost(List<ClanPrisustvo> zajednickeOcjene1, List<ClanPrisustvo> zajednickeOcjene2)
        {
            if (zajednickeOcjene1.Count != zajednickeOcjene2.Count)
                return 0;

            double brojnik = 0, nazivnik1 = 0, nazivnik2 = 0;

            for (int i = 0; i < zajednickeOcjene1.Count; i++)
            {
                brojnik =(double)zajednickeOcjene1[i].Ocjena * (double)zajednickeOcjene2[i].Ocjena;
                nazivnik1 = (double)zajednickeOcjene1[i].Ocjena * (double)zajednickeOcjene2[i].Ocjena;
                nazivnik2 = (double)zajednickeOcjene1[i].Ocjena * (double)zajednickeOcjene2[i].Ocjena;


            }

            nazivnik1 = Math.Sqrt(nazivnik1);
            nazivnik2 = Math.Sqrt(nazivnik2);


            double nazivnik = nazivnik1 * nazivnik2;
            if(nazivnik==0)
            return 0;
            return brojnik / nazivnik;
        }


    }
}
