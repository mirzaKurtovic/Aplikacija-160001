using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wellness.WebAPI.Database;

namespace Wellness.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PaketController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly _160001Context _context;
        public PaketController(_160001Context context, IMapper mapper)
        {
            this._mapper = mapper;
            this._context = context;
        }

        [HttpGet]
        public ActionResult<List<Model.Paket>> Get()
        {
            var list = _context.Paket.ToList();

            return _mapper.Map<List<Model.Paket>>(list);
        }
    }
}