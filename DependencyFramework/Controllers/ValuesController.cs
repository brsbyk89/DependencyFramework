using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyFramework.Business;
using Microsoft.AspNetCore.Mvc;

namespace DependencyFramework.Controllers
{
    public class ValuesController : Controller
    {
        private ITestEngine _testEngine;

        public ValuesController(ITestEngine testEngine)
        {
            _testEngine = testEngine;
        }

        [HttpGet]
        public string Test()
        {
            return _testEngine.Test();
        }
    }
}
