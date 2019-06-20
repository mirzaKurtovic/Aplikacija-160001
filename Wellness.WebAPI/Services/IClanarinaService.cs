using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wellness.Model.Requests;

namespace Wellness.WebAPI.Services
{
    public interface IClanarinaService
    {
        List<Model.Clanarina> Get(ClanarinaSearchRequest request);
         Model.Clanarina GetById(int id);
         Model.Clanarina Update(int id, ClanarinaInsertRequest request);
         Model.Clanarina Insert(ClanarinaInsertRequest request);

    }
}
