using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Wellness.WebAPI.Database;
using Wellness.Model.Requests;
using Microsoft.AspNetCore.Authorization;

namespace Wellness.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class RadnikController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly _160001Context _context;
        public RadnikController(_160001Context context, IMapper mapper)
        {
            this._mapper = mapper;
            this._context = context;
        }

        [HttpGet]
        public ActionResult<List<Model.Radnik>> Get([FromQuery]RadnikSearchRequest request)
        {
            var query = _context.Radnik
                .Include(r => r.Osoba)
                .ThenInclude(o => o.Uloga)
                .AsQueryable();

            if(request!=null)
            {

                if(!string.IsNullOrWhiteSpace(request.Ime))
                {
                    query = query.Where(o => o.Osoba.Ime.StartsWith(request.Ime));
                }
                if (!string.IsNullOrWhiteSpace(request.Prezime))
                {
                    query = query.Where(o => o.Osoba.Prezime.StartsWith(request.Prezime));
                }
                if (request.UlogaId != 0 && request.UlogaId!=null)
                {
                    query = query.Where(o => o.Osoba.UlogaId == request.UlogaId);
                }
                if (request.OsobaId != null)
                {
                    query = query.Where(o => o.OsobaId == request.OsobaId);
                }
            }
            var list = query.ToList();

            return _mapper.Map<List<Model.Radnik>>(list);
        }


        [HttpGet("{id}")]
        public ActionResult<Model.Radnik> GetById(int id)
        {
            var radnik = _context.Radnik
                .Where(r=>r.Id==id)
                .Include(r => r.Osoba)
                .ThenInclude(r => r.Uloga)
                .FirstOrDefault();

            return _mapper.Map<Model.Radnik>(radnik);
        }
        [HttpPost]
        public Model.Radnik Insert(RadnikInsertRequest request)
        {
            var radnik = _mapper.Map<Radnik>(request);

            _context.Radnik.Add(radnik);
            _context.SaveChanges();
            return _mapper.Map<Model.Radnik>(radnik);
        }

        [HttpPut("{id}")]
        public Model.Radnik Update(int id, RadnikInsertRequest request)
        {
            var radnik = _context.Radnik.Find(id);
            _mapper.Map(request, radnik);
            _context.SaveChanges();

            return _mapper.Map<Model.Radnik>(radnik);
        }

    }
}