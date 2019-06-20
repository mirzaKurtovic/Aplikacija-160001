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
    public class TrenerController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly _160001Context _context;
        public TrenerController(_160001Context context, IMapper mapper)
        {
            this._mapper = mapper;
            this._context = context;
        }

        [HttpGet]
        public ActionResult<List<Model.Trener>> Get([FromQuery]TrenerSearchRequest request)
        {
            var query = _context.Trener
                .Include(t => t.Radnik)
                .ThenInclude(r => r.Osoba)
                .ThenInclude(o => o.Uloga)
                .AsQueryable();

            if (request != null)
            {
                if (request.OsobaId != null)
                {
                    query = query.Where(o => o.Radnik.OsobaId == request.OsobaId);
                }
            }
            var list = query.ToList();

            return _mapper.Map<List<Model.Trener>>(list);
        }

        [HttpPost]
        public Model.Trener Insert(TrenerInsertRequest request)
        {
            var trener = _mapper.Map<Trener>(request);


            _context.Trener.Add(trener);
            _context.SaveChanges();
            return _mapper.Map<Model.Trener>(trener);

        }

        [HttpPut("{id}")]
        public Model.Trener Update(int id,TrenerInsertRequest request)
        {

            var trener = _context.Trener.Where(t => t.Id == id);

            _mapper.Map(request, trener);
            _context.SaveChanges();


            return _mapper.Map<Model.Trener>(trener);

        }
    }
}