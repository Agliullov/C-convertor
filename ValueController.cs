using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ValueController : ApiController
    {
        private readonly List<ValueRate> list;
        public ValueController()
        {
            list = new List<ValueRate>
            {
                new ValueRate() {value = Value.Foot, sizeval = 1.0 },
                new ValueRate() {value = Value.Metr, sizeval = 5.0 },
                new ValueRate() {value = Value.Mile, sizeval = 10.0 },
                new ValueRate() {value = Value.Yard, sizeval = 100.0 },
            };

        }

        [HttpGet]
        [Route("abc")]
        public double CalcVal(Value from, Value to, double magnityde)
        {
            var cons = list.ToDictionary(x => x.value);
            if (magnityde <= 0) return 0;
            else return magnityde * (cons[to].sizeval / cons[from].sizeval);
        }
    }
}
