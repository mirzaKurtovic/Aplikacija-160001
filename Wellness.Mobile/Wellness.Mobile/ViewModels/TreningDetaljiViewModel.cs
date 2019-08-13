using System;
using System.Collections.Generic;
using System.Text;
using Wellness.Mobile.AsyncHelper;
using Wellness.Model.Requests;

namespace Wellness.Mobile.ViewModels
{
    class TreningDetaljiViewModel
    {
        public Wellness.Model.Trening _trening { get; set; }
        public Wellness.Model.Requests.ClanViewRequest _clan { get; set; }
        public Wellness.Mobile.Models.TreningDetaljiModel treningDetaljiModel { get;set; }

        public Wellness.Mobile.Models.TreningModel TreningMod { get; set; }

        APIService _apiService_ClanPrisustvo;
        APIService _apiService_Recommender;
        public TreningDetaljiViewModel(Wellness.Model.Trening trening,Wellness.Model.Requests.ClanViewRequest clan)
        {
            _apiService_ClanPrisustvo = new APIService("ClanPrisustvo");
            _apiService_Recommender = new APIService("Recommender");
            treningDetaljiModel = new Wellness.Mobile.Models.TreningDetaljiModel();
            _trening = trening;
            _clan = clan;


            var trenutnoPrisutnih = AsyncHelpers.RunSync<List<Wellness.Model.ClanPrisustvo>>(() => _apiService_ClanPrisustvo.Get<List<Model.ClanPrisustvo>>(new ClanPrisustvoSearchRequest() { TreningId = trening.Id }));
            var TreningRecommended = AsyncHelpers.RunSync<List<Wellness.Model.Trening>>(() => _apiService_Recommender.GetById<List<Model.Trening>>(trening.Id));
            var treningModel = new Wellness.Mobile.Models.TreningModel()
            {

                Id = trening.Id,
                DatumTreninga = trening.DatumTreninga.ToString("dd.MM.yyyy"),
                pocetak = trening.VrijemePocetak,
                kraj = trening.VrijemeKraj,
                MaxPrisutnih = trening.MaksimalnoPrisutnih,
                Trener = trening.Trener.Radnik.Osoba.Ime + " " + trening.Trener.Radnik.Osoba.Prezime,
                TipTreninga = trening.TipTreninga.TipTreninga1,
                ClanId = clan.Id,
                TrenutnoPrisutnih = trenutnoPrisutnih.Count
            };
            treningDetaljiModel.TreningModel = treningModel;
            TreningMod = treningModel;



            var prisustvo = AsyncHelpers.RunSync<List<Wellness.Model.ClanPrisustvo>>(() => _apiService_ClanPrisustvo.Get<List<Model.ClanPrisustvo>>(new ClanPrisustvoSearchRequest() { TreningId = trening.Id, ClanId = clan.Id }));


            if (prisustvo.Count > 0)
            {
                treningModel.ClanPrisustvovaoTreningu = prisustvo[0].Prisustvovao;
                treningModel._Prisustvuje = true;
                treningModel.PrisustvoId = prisustvo[0].Id;
                if (prisustvo[0].Ocjena != null)
                {
                    treningModel._Ocjena = (int)prisustvo[0].Ocjena;
                    treningModel.Ocjenjen = true;
                }
                else
                {
                    treningModel._Ocjena = 0;
                    treningModel.Ocjenjen = false;
                }
            }
            else
            {
                if (prisustvo.Count == 0)
                {
                    treningModel.ClanPrisustvovaoTreningu = false;
                    treningModel._Prisustvuje = false;
                    treningModel.Ocjenjen = false;
                    treningModel.PrisustvoId = 0;
                    treningModel._Ocjena = 0;
                }
            }






            List<Wellness.Mobile.Models.PrisutniModel> prisutni = new List<Wellness.Mobile.Models.PrisutniModel>();
            foreach (Wellness.Model.ClanPrisustvo x in trenutnoPrisutnih)
            {
                Wellness.Mobile.Models.PrisutniModel p = new Wellness.Mobile.Models.PrisutniModel()
                {
                    DatumPrijave = ((DateTime)x.DatumPrijave).ToString("dd.MM.yyyy"),
                    Ime = x.Clan.Osoba.Ime,
                    Prezime = x.Clan.Osoba.Prezime,
                    Ocjena = x.Ocjena,
                    Prisustvovao = x.Prisustvovao,
                    Id = x.Id,
                };

                prisutni.Add(p);
            }
            treningDetaljiModel.PrisutniModel = prisutni;



            treningDetaljiModel.RecommendedTrening = new List<Mobile.Models.TreningModel>();
            foreach (Wellness.Model.Trening x in TreningRecommended)
            {
                var tr = new Wellness.Mobile.Models.TreningModel()
                {
                    Id = x.Id,
                    DatumTreninga = x.DatumTreninga.ToString("dd.MM.yyyy"),
                    pocetak = x.VrijemePocetak,
                    kraj = x.VrijemeKraj,
                    MaxPrisutnih = x.MaksimalnoPrisutnih,
                    Trener = x.Trener.Radnik.Osoba.Ime + " " + x.Trener.Radnik.Osoba.Prezime,
                    TipTreninga = x.TipTreninga.TipTreninga1,
                    ClanId = clan.Id
                };
                treningDetaljiModel.RecommendedTrening.Add(tr);
            }

          


        }
        public TreningDetaljiViewModel()
        {

        }




    }
}
