using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01609602Assignment1.Controllers
{
    public class SquareController : ApiController
    {

        /// <summary>
        /// performs square of the number added in query params
        /// </summary>
        /// <param name="id">number to be squared</param>
        /// <returns>
        /// GET api/Square/2 --> 4
        /// GET api/Square/-2 --> 4
        /// GET api/Square/10 --> 100
        /// </returns>
        public double Get(double id)
        {
            double square = Math.Pow(id, 2);
            return square;
        }
    }
}
