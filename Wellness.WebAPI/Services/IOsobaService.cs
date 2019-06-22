using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wellness.Model.Requests;

namespace Wellness.WebAPI.Services
{
    
    public interface IOsobaService
    {
        Wellness.Model.Osoba Authenticiraj(string username, string pass);

        List<Wellness.Model.Osoba> Get(OsobaSearchReqeust request);
        Wellness.Model.Osoba GetById(int id);

        Wellness.Model.Osoba Insert(OsobaInsertRequest request);

        Wellness.Model.Osoba Update(int id, OsobaInsertRequest request);
    }
    
}
