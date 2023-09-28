using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01609602Assignment1.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        /// prints greeting message to number of people present in the query params
        /// </summary>
        /// <param name="id">number  of people</param>
        /// <returns>
        /// GET api/Greeting/3 --> Greeting to 3 people!
        /// GET api/Greeting/6 --> Greeting to 6 people!
        /// GET api/Greeting/0 --> Greeting to 0 people!
        /// </returns>
        public string Get(int id)
        {
            return "Greetings to " + id + " people!";
        }

        /// <summary>
        /// simple post method to understand the syntax
        /// </summary>
        /// <returns>
        /// POST /api/Greeting --> Returns a string called Hello World!
        /// </returns>
        public string Post()
        {
            return "Hello World";
        }
    }
}
