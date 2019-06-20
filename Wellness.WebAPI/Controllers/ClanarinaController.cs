using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wellness.Model.Requests;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Wellness.WebAPI.Database;
using Wellness.WebAPI.Services;

namespace Wellness.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ClanarinaController : ControllerBase
    {
        private readonly IClanarinaService _service;
        public ClanarinaController(IClanarinaService service)
        {

            this._service = service;
        }

        [HttpGet]
        public ActionResult<List<Model.Clanarina>> Get([FromQuery]ClanarinaSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpGet("{id}")]
        public ActionResult<Model.Clanarina> GetById(int id)
        {
            return _service.GetById(id);
        }


        [HttpPost]
        public Model.Clanarina Insert(ClanarinaInsertRequest request)
        {
            return _service.Insert(request);
        }

        [HttpPut("{id}")]
        public Model.Clanarina Update(int id,ClanarinaInsertRequest request)
        {
            return _service.Update(id, request);
        }

    }
}