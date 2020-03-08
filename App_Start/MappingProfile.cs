using AutoMapper;
using SchoolPortal.Dtos;
using SchoolPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolPortal.App_Start
{
    public class MappingProfile : Profile
    {
        public  MappingProfile()
        {
            Mapper.CreateMap<Student, StudentDto>();
            Mapper.CreateMap<StudentDto, Student>();

        }

    }
}