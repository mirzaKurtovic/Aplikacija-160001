using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wellness.Model.Requests;
using Wellness.WebAPI.Database;

namespace Wellness.WebAPI.Services
{
    public class ClanarinaService:IClanarinaService
    {
        private readonly _160001Context _context;
        private readonly IMapper _mapper;
        public ClanarinaService(_160001Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public List<Model.Clanarina> Get(ClanarinaSearchRequest request)
        {
            var query = _context.Clanarina
                .Include(c => c.Clan)
                .ThenInclude(c => c.Osoba)
                .Include(c => c.Paket)
                .OrderByDescending(c => c.DatumUplate)
                .AsQueryable();

            #region search
            if (request.UplataZaMjesec != null)
            {
                query = query.Where(q => q.UplataZaMjesec == request.UplataZaMjesec);
            }
            if (request.UplataZaGodinu != null)
            {
                query = query.Where(q => q.UplataZaGodinu == request.UplataZaGodinu);
            }
            if (request.ClanID != 0)
            {
                query = query.Where(q => q.ClanId == request.ClanID);
            }
            if (request.PaketID != 0)
            {
                query = query.Where(q => q.PaketId == request.PaketID);
            }
            #endregion search

            var list = query.ToList();
            return _mapper.Map<List<Model.Clanarina>>(list);
        }

        public Model.Clanarina GetById(int id)
        {
            var clanarina = _context.Clanarina.Find(id);

            return _mapper.Map<Model.Clanarina>(clanarina);
        }


        public Model.Clanarina Insert(ClanarinaInsertRequest request)
        {
            var clanarina = _mapper.Map<Clanarina>(request);

            _context.Clanarina.Add(clanarina);
            _context.SaveChanges();
            return _mapper.Map<Model.Clanarina>(clanarina);
        }

        public Model.Clanarina Update(int id, ClanarinaInsertRequest request)
        {
            var clanarina = _context.Clanarina.Find(id);
            _mapper.Map(request, clanarina);
            _context.SaveChanges();

            return _mapper.Map<Model.Clanarina>(clanarina);
        }

    }
}
