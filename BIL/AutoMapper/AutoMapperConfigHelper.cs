﻿using AutoMapper;
using AutoMapper.Configuration;
using BIL.DTO;
using BIL.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIL.AutoMapper
{
    public static class MapperInitializer
    {
        public static void Init()
        {
            Mapper.Initialize(Configuration);
        }

        public static void myInit()
        {
            MapperInitializer.Configuration.CreateMap(typeof(AnswerDTO), typeof(Answer));
            MapperInitializer.Configuration.CreateMap(typeof(TestDTO), typeof(Test));
            MapperInitializer.Configuration.CreateMap(typeof(QuestionDTO), typeof(Question));
        }


        public static MapperConfigurationExpression Configuration { get; } = new MapperConfigurationExpression();
    }
}
