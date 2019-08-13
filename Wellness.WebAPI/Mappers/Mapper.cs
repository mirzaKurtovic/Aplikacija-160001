using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wellness.Model;
using Wellness.WebAPI.Database;
namespace Wellness.WebAPI.Mappers
{
    public class Mapper:Profile
    {
        public Mapper()
        {
            CreateMap<Database.Clanarina, Model.Clanarina>();
            CreateMap<Model.Requests.ClanarinaInsertRequest, Database.Clanarina>();
            CreateMap<Database.Trening, Model.Trening>();
            CreateMap<Model.Trening, Database.Trening>();
            CreateMap<Model.Requests.TreningInsertRequest,Database.Trening>();
            CreateMap<Database.TipTreninga, Model.TipTreninga>();
            CreateMap<Database.ClanPrisustvo, Model.ClanPrisustvo>();
            CreateMap<Database.Clan, Model.Requests.ClanViewRequest>();
            CreateMap<Database.Osoba, Model.Requests.ClanViewRequest>();
            CreateMap<Database.Paket, Model.Paket>();
            CreateMap<Database.Grad, Model.Grad>();
            CreateMap<Database.Uloga, Model.Uloga>();
            CreateMap<Database.Osoba, Model.Osoba>();
            CreateMap<Database.Radnik, Model.Radnik>();
            CreateMap<Database.Trener, Model.Trener>();
            CreateMap<Database.TipTreninga, Model.TipTreninga>();
            CreateMap<Database.RadnikPlataHistorija, Model.RadnikPlataHistorija>();
            CreateMap<Model.Requests.ClanPrisustvoInsertRequest, Database.ClanPrisustvo>();
            CreateMap<Model.Requests.OsobaInsertRequest, Database.Osoba>();
            CreateMap<Model.Requests.RadnikInsertRequest, Database.Radnik>();
            CreateMap<Model.Requests.TrenerInsertRequest, Database.Trener>();
            CreateMap<Model.Requests.ClanarinaInsertRequest, Database.Clan>();
            CreateMap<Model.Requests.ClanInsertRequest, Database.Clan>();
            CreateMap<Model.Requests.RadnikIsplataInsertRequest, Database.RadnikPlataHistorija>();
            CreateMap<Model.Requests.TipTreningaInsertRequest, Database.TipTreninga>();


            //test

        }
    }
}
