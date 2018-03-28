using DependencyFramework.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyFramework.Business
{
    public class TestEngine : ITestEngine
    {
        private ITestRepository _testRepository;
        
        public TestEngine(ITestRepository testRepository)
        {
            _testRepository = testRepository;
        }
        public string Test()
        {
          return  _testRepository.Test();
        }
    }
}
