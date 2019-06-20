using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Wellness.Model.Requests;
using Wellness.WebAPI.Database;

namespace Wellness.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class RadnikPlataHistorijaController : ControllerBase
    {

        private readonly IMapper _mapper;
        private readonly _160001Context _context;
        public RadnikPlataHistorijaController(_160001Context context, IMapper mapper)
        {
            this._mapper = mapper;
            this._context = context;
        }


        // GET: api/RadnikPlataHistorija
        [HttpGet]
        public List<Model.RadnikPlataHistorija> Get([FromQuery]RadnikIsplataSearchRequest search)
        {
            var query = _context.RadnikPlataHistorija
                .Include(r => r.Radnik)
                .ThenInclude(r => r.Osoba)
                .ThenInclude(o => o.Uloga)
                .OrderByDescending(r=>r.DatumUplate)
                .AsQueryable();


            if (search != null)
            {
                if (search.radnikId != null && search.radnikId!=0)
                    query = query.Where(q => q.RadnikId == search.radnikId);
                if(search.UplataZaGodinu!=null)
                    query = query.Where(q => q.UplataZaGodinu == search.UplataZaGodinu);
                if (search.UplataZaMjesec != null)
                    query = query.Where(q => q.UplataZaMjesec == search.UplataZaMjesec);
            }

            var list = query.ToList();


            return _mapper.Map<List<Model.RadnikPlataHistorija>>(list);
        }

        // GET: api/RadnikPlataHistorija/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/RadnikPlataHistorija
        [HttpPost]
        public Model.RadnikPlataHistorija Insert(RadnikIsplataInsertRequest request)
        {
            var rph = _mapper.Map<Database.RadnikPlataHistorija>(request);

            _context.RadnikPlataHistorija.Add(rph);
            _context.SaveChanges();

            return _mapper.Map<Model.RadnikPlataHistorija>(rph);
        }

        // PUT: api/RadnikPlataHistorija/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
