using AutoMapper;
using DAL_EF.DTO;
using KnowledgeTestingSystemWebAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KnowledgeTestingSystemWebAPI.AutoMapper
{
    public static class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<AnswerVM, AnswerDTO>();
                cfg.CreateMap<TestVM, TestDTO>();
                cfg.CreateMap<QuestionVM, QuestionDTO>();
            });
        }
    }
}