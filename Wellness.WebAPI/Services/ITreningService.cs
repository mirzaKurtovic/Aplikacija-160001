using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wellness.Model.Requests;

namespace Wellness.WebAPI.Services
{
    public interface ITreningService
    {
         List<Model.Trening> Get(TreningSearchRequest request);
        Model.Trening GetById(int id);
        Model.Trening Insert(TreningInsertRequest request);
        void Update(int id, TreningInsertRequest request);
    }
}
