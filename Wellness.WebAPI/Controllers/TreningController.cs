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
using Wellness.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;

namespace Wellness.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class TreningController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly _160001Context _context;
        private readonly ITreningService _service;
        public TreningController(_160001Context context, IMapper mapper, ITreningService service)
        {
            this._mapper = mapper;
            this._context = context;
            this._service = service;
        }

        [HttpGet]
        public ActionResult<List<Model.Trening>> Get([FromQuery]TreningSearchRequest request)
        {
           return _service.Get(request);
        }

        [HttpGet("{id}")]
        public ActionResult<Model.Trening> GetById(int id)
        {
           return _service.GetById(id);
        }

        [HttpPost]
        public Model.Trening Insert(TreningInsertRequest request)
        {
           return _service.Insert(request);
        }
        [HttpPut("{id}")]
        public void Update(int id, TreningInsertRequest request)
        {
            _service.Update(id, request);
        }


    }
}