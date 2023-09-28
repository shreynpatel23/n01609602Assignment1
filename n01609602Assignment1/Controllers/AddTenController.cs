using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01609602Assignment1.Controllers
{
    public class AddTenController : ApiController
    {

        /// <summary>
        /// Add ten to the number added in the params
        /// </summary>
        /// <param name="id">number to be added to 10</param>
        /// <returns>
        /// GET api/AddTen/21 --> 31
        /// GET api/AddTen/0 --> 10
        /// GET api/AddTen/-9 --> 1
        /// </returns>
        public int Get(int id)
        {
            int numberPlusTen = id + 10;
            return numberPlusTen;
        }
    }
}
