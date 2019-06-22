using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Wellness.Model;
using Wellness.Model.Requests;
using Wellness.WebAPI.Database;

namespace Wellness.WebAPI.Services
{
    public class OsobaService : IOsobaService
    {
        private readonly _160001Context _context;
        private readonly IMapper _mapper;
        public OsobaService(_160001Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public List<Wellness.Model.Osoba> Get(OsobaSearchReqeust request)
        {
            var query = _context.Osoba.AsQueryable();

            if (request != null)
            {
                if(request.Username!=null)
                {
                    query = query.Where(o => o.KorisnickoIme == request.Username);

                }
            }

            var list = query.ToList();

            return _mapper.Map<List<Wellness.Model.Osoba>>(list);
        }


        public Wellness.Model.Osoba Authenticiraj(string username, string pass)
        {
            var user = _context.Osoba
                .Include(o=>o.Uloga)
                .FirstOrDefault(x => x.KorisnickoIme == username);

            if (user != null)
            {
                var newHash = GenerateHash(user.LozinkaSalt, pass);

                if (newHash == user.LozinkaHash)
                {
                    return _mapper.Map<Wellness.Model.Osoba>(user);
                }
            }
            return null;
        }

        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }

        public Model.Osoba GetById(int id)
        {

            var osoba = _context.Osoba.Where(o => o.Id == id)
           .Include(o => o.Uloga)
           .FirstOrDefault();

            return _mapper.Map<Model.Osoba>(osoba);
        }

        public Wellness.Model.Osoba Insert(OsobaInsertRequest request)
        {
            var entity = _mapper.Map<Wellness.WebAPI.Database.Osoba>(request);

            if (request.Password != request.PasswordPotvrda)
            {
                throw new Exception("Passwordi se ne slažu");
            }

            entity.LozinkaSalt = GenerateSalt();
            entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);

            _context.Osoba.Add(entity);
            _context.SaveChanges();

            /*
            foreach (var uloga in request.Uloge)
            {
                Wellness.WebAPIDatabase.KorisniciUloge korisniciUloge = new Database.KorisniciUloge();
                korisniciUloge.KorisnikId = entity.KorisnikId;
                korisniciUloge.UlogaId = uloga;
                korisniciUloge.DatumIzmjene = DateTime.Now;
                _context.KorisniciUloge.Add(korisniciUloge);
            }
            _context.SaveChanges();
            */

            entity = _context.Osoba.Where(o => o.Id == entity.Id)
    .Include(o => o.Uloga)
    .FirstOrDefault();

            return _mapper.Map<Wellness.Model.Osoba>(entity);
        }


        public Model.Osoba Update(int id, OsobaInsertRequest request)
        {
            var osoba = _context.Osoba.Where(o => o.Id == id)
                .Include(o => o.Uloga)
                .FirstOrDefault();
            _mapper.Map(request, osoba);
            _context.SaveChanges();

            return _mapper.Map<Model.Osoba>(osoba);
        }

    }
}

