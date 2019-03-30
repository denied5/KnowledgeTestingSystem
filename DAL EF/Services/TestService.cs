using System.Collections.Generic;
using AutoMapper;
using BIL.Entitys;
using BIL.Interfaces;
using DAL_EF.DTO;
using DAL_EF.Infrastructure;
using DAL_EF.Interfaces;

namespace DAL_EF.Services
{
    public class TestService : ITestService
    {
        IUnitOfWork _unitOfWork { get; set; }

        public TestService(IUnitOfWork unitOfWork)
        {

            _unitOfWork = unitOfWork;
        }

        public void AddTest(TestDTO testDTO)
        {
            if (testDTO == null)
                throw new BILException("test null", "");

            _unitOfWork.Test.Create(Mapper.Map<Test>(testDTO));
        }

        public void DeleteTest(int? id)
        {
            if (id == null)
                throw new BILException("we don't have this id", "");
            else
                _unitOfWork.Test.Delete(id.GetValueOrDefault());
        }

        public void Dispose()
        {
            _unitOfWork.Dispose();
        }

        public TestDTO GetTest(int? id)
        {
            if (id == null)
                throw new BILException("we don't have this id", "");

            return Mapper.Map<TestDTO>(_unitOfWork.Test.Get(id.GetValueOrDefault()));
        }

        public IEnumerable<TestDTO> GetTests()
        {
            return Mapper.Map<IEnumerable<TestDTO>>(_unitOfWork.Test.GetAll());
        }
    }
}
