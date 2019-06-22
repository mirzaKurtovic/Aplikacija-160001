using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Wellness.WebAPI.Database;
using Wellness.Model.Requests;
using Wellness.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;

namespace Wellness.WebAPI.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class OsobaController : ControllerBase
    {
        private readonly IOsobaService _service;

        public OsobaController(IOsobaService service)
        {
            this._service = service;
        }


        [HttpGet]
        public ActionResult<List<Model.Osoba>> Get([FromQuery]OsobaSearchReqeust request)
        {
            return _service.Get(request);
        }
        [HttpPost]
        public Model.Osoba Insert(OsobaInsertRequest request)
        {
            return _service.Insert(request);
        }
        [HttpGet("{id}")]
        public ActionResult<Model.Osoba> GetById(int id)
        {

            return _service.GetById(id);
        }
        [HttpPut("{id}")]
        public Model.Osoba Update(int id, OsobaInsertRequest request)
        {
            return _service.Update(id, request);
        }

    }
}