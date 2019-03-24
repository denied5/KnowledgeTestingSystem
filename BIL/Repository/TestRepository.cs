﻿using BIL.Entitys;
using BIL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIL.Repository
{
    class TestRepository: ITestRepository
    {
        private IContext db;

        public TestRepository(IContext context)
        {
            db = context;
        }

        public IQueryable<Test> GetAll()
        {
            return db.Tests;
        }

        public Test Get(int id)
        {
            return db.Tests.Find(id);
        }

        public void Create(Test Test)
        {
            db.Tests.Add(Test);
        }

        public void Update(Test Test)
        {
            ((DBContext)db).Entry(Test).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Test test = db.Tests.Find(id);
            if (test != null)
                db.Tests.Remove(test);
        }

        public IQueryable<Test> GetAllIncluding()
        {
            return db.Tests.Include("Questions");
        }
    }
}