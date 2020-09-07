using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SimpleBlog.Controllers
{
    public class ValuesController : ControllerBase
    {
        // GET: api/<controller>
        [HttpGet]
        [Route("api/[controller]/GetAll")]
        public IEnumerable<string> GetAll()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet]
        [Route("api/[controller]/GetFirst")]
        public string GetFirst()
        {
            return "I'm first";
        }
    }
}