using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Nodak.Dtos;
using Nodak.Models;

namespace Nodak.App_Start
{
    public class MapingProfile : Profile
    {
        public MapingProfile()
        {
            //Mapper.Configuration<Student, StudentDto>;
        }  
    }
}