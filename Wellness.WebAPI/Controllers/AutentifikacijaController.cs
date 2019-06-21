using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Wellness.WebAPI.Database;
using Wellness.Model.Requests;
using Microsoft.EntityFrameworkCore;
using Wellness.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;

namespace Wellness.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutentifikacijaController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly _160001Context _context;
        private readonly IOsobaService _service;
        public AutentifikacijaController(_160001Context context, IMapper mapper,IOsobaService service)
        {
            this._mapper = mapper;
            this._context = context;
            this._service = service;
        }

        [HttpGet]
        public ActionResult<Wellness.Model.Osoba> Get([FromQuery]AutentifikacijaRequest request)
        {
            // vraca autentificarnu osobu ako je autentificiranja, ako nije null

            var result = _service.Authenticiraj(request.username, request.password);
            if (result == null) return null;


            var osoba = _context.Osoba.Where(o => o.Id == result.Id)
                .Include(o => o.Uloga)
                .FirstOrDefault();

            return _mapper.Map<Wellness.Model.Osoba>(osoba); 

            /*var radnik =  _mapper.Map<Wellness.Model.Radnik>(_context.Radnik.Where(c => c.OsobaId == osoba.Id)
                .Include(r => r.Osoba)
                .Include(t => t.Trener)
                .FirstOrDefault());
            
            return radnik;
            */



        }

    }
}
