using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using AutoMapper;
using AutoMapper.Configuration;
using Nodak.App_Start;
using Nodak.Dtos;
using Nodak.Models;

namespace Nodak
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //AutoMap.RegisterMappings();
            //AutoMapper.Re
           //Mapper.Initialize(c=>c.AddProfile<MapingProfile>);
           Mapper.Initialize(config =>
           {
               config.CreateMap<Student, StudentDto>();
               config.CreateMap<Teacher, TeacherDto>();
               config.CreateMap<Course, Course>();
           });

            GlobalConfiguration.Configure(WebApiConfig.Register);



           // var config = new MapperConfiguration(cfg => cfg.CreateMap<Student, StudentDto>());
        }
    }
}
