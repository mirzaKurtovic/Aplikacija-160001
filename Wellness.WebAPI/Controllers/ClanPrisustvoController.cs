using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wellness.Model.Requests;
using Microsoft.EntityFrameworkCore;
using Wellness.WebAPI.Database;
using Microsoft.AspNetCore.Authorization;

namespace Wellness.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ClanPrisustvoController : ControllerBase
    {

        private readonly IMapper _mapper;
        private readonly _160001Context _context;
        public ClanPrisustvoController(_160001Context context, IMapper mapper)
        {
            this._mapper = mapper;
            this._context = context;
        }



        [HttpGet]
        public ActionResult<List<Model.ClanPrisustvo>> Get([FromQuery]ClanPrisustvoSearchRequest request)
        {
            var query = _context.ClanPrisustvo
             .Include(cp => cp.Clan)
             .ThenInclude(c => c.Osoba)
             .Include(cp=>cp.Trening)
             .ThenInclude(cp=>cp.TipTreninga)
             .AsQueryable();

            if (request != null)
            {
                if (request.ClanId != 0)
                {
                    query = query.Where(q => q.ClanId == request.ClanId);
                }
                if (request.TreningId != 0)
                {
                    query = query.Where(q => q.TreningId == request.TreningId);
                }
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.ClanPrisustvo>>(list);
        }

        [HttpPut("{id}")]//popravit, nema smisla...
        public void Update(int id, ClanPrisustvoInsertRequest request)
        {
            var prisustvo = _context.ClanPrisustvo.Where(cp => cp.ClanId == request.ClanId && cp.TreningId == request.TreningId).FirstOrDefault();
            _mapper.Map(request, prisustvo);
            _context.SaveChanges();


        }
        [HttpPost]//popravit, nema smisla...
        public ActionResult<Model.ClanPrisustvo> Insert(ClanPrisustvoInsertRequest request)
        {

            var prisustvo = _mapper.Map<Database.ClanPrisustvo>(request);
            var prisustvoCheck = _context.ClanPrisustvo.Where(cp => cp.ClanId == prisustvo.ClanId && cp.TreningId == prisustvo.TreningId).FirstOrDefault();
            if (prisustvoCheck != null)
             return  _mapper.Map<Wellness.Model.ClanPrisustvo>(prisustvoCheck);

            prisustvo.DatumPrijave = DateTime.Now;
            _context.ClanPrisustvo.Add(prisustvo);
            _context.SaveChanges();
            var result = _mapper.Map<Wellness.Model.ClanPrisustvo>(prisustvo);
            return result;
        }
        [HttpDelete("{id}")]//popravit, nema smisla...
        public bool Delete(int id)
        {
            // 
            var prisustvo = _context.ClanPrisustvo.Where(cp => cp.Id==id).FirstOrDefault();
            
            if (prisustvo == null) return false;
            _context.ClanPrisustvo.Remove(prisustvo);
            _context.SaveChanges();
            return true;
        }

    }
}


/*[HttpGet]
        public ActionResult<List<Model.ClanPrisustvo>> Get(int id)
        {
            var list = _context.ClanPrisustvo.Where(cp => cp.TreningId == id)
                .Include(cp=>cp.Clan)
                .ThenInclude(c=>c.Osoba)
                .ToList();
            return _mapper.Map<List<Model.ClanPrisustvo>>(list);
        }
        */
