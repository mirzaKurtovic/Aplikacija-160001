using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wellness.Model.Requests;
using Wellness.WebAPI.Database;

namespace Wellness.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipTreningaController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly _160001Context _context;
        public TipTreningaController(_160001Context context, IMapper mapper)
        {
            this._mapper = mapper;
            this._context = context;
        }

        [HttpGet]
        public ActionResult<List<Model.TipTreninga>> Get()
        {
            var list = _context.TipTreninga.ToList();
            return _mapper.Map<List<Model.TipTreninga>>(list);
        }
        [HttpPost]
        public ActionResult<Model.TipTreninga> Insert(TipTreningaInsertRequest request)
        {
            var tipTreninga = _mapper.Map<Database.TipTreninga>(request);

            var result = _context.TipTreninga.Add(tipTreninga);
            _context.SaveChanges();
          

            return _mapper.Map<Model.TipTreninga>(tipTreninga);

        }


    }
}