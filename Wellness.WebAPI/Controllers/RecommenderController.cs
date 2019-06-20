using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wellness.WebAPI.Util;

namespace Wellness.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class RecommenderController : ControllerBase
    {

        private readonly IMapper _mapper;
        public RecommenderController(IMapper mapper)
        {
            this._mapper = mapper;
        }


        // GET: api/Recommender
        [HttpGet("{id}")]
        public List<Model.Trening> GetById(int id)
        {
            Recommender recommender = new Recommender();

            List<Database.Trening> list = recommender.GetSlicneTreninge(id);
            if (list.Count > 3)
                list = list.GetRange(0, 3);
            return _mapper.Map<List<Wellness.Model.Trening>>(list);
        }


    }
}
