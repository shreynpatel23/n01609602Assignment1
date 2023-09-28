using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01609602Assignment1.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// performs four mathematical operations to the number added in query params
        /// </summary>
        /// <param name="id">number on which the mathematical operations needs to be performed</param>
        /// <returns>
        /// GET api/NumberMachine/10 --> 34
        /// GET api/NumberMachine/-5 --> 4
        /// GET api/NumberMachine/30 --> 74
        /// </returns>
        public int Get(int id)
        {
            int add = id + 10;
            int subtract = add - 3;
            int multiple = subtract * 4;
            int result = multiple / 2;
            return result;
        }
    }
}
