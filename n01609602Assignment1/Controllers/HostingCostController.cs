using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01609602Assignment1.Controllers
{
    public class HostingCostController : ApiController
    {
        /// <summary>
        /// computes the total cost of the hosting service based on the number of days present in the params
        /// </summary>
        /// <param name="id">number of days the person uses our hosting service </param>
        /// <returns>
        /// GET api/HostingService/0 -->  1 fortnights at $5.50/FN = $5.50 CAD, HST 13% = $0.72 CAD, Total = $6.22 CAD
        /// GET api/HostingService/14 -->  2 fortnights at $5.50/FN = $11.00 CAD, HST 13% = $1.43 CAD, Total = $12.43 CAD
        /// GET api/HostingService/15 -->  2 fortnights at $5.50/FN = $11.00 CAD, HST 13% = $1.43 CAD, Total = $12.43 CAD
        /// GET api/HostingService/21 -->  2 fortnights at $5.50/FN = $11.00 CAD, HST 13% = $1.43 CAD, Total = $12.43 CAD
        /// GET api/HostingService/28 -->  3 fortnights at $5.50/FN = $16.50 CAD, HST 13% = $2.15 CAD, Total = $18.65 CAD
        /// </returns>
        public IEnumerable<string> Get(double id)
        {
            int oneFortNight = 14;
            double oneFortNightCharge = 5.50;
            double tax = 0.13;
            // divide the number of days to oneFortNight + 1 to get the total number of days to charge
            double totalNumberOfDays = Math.Floor(id / oneFortNight) + 1;

            // multiply the oneFortNightCharge to totalNumberOfDays to get the totalChargeCost
            double totalChargingCost = totalNumberOfDays * oneFortNightCharge;

            // compute the totalTax by multiplying the totalChargeCost with tax
            double totalTax = totalChargingCost * tax;

            // add the totalChargeCost with totalTax to get the hosting cost
            double totalHostingCost = totalChargingCost + totalTax;

            return new string[] {
                totalNumberOfDays + " fortnights at $5.50 / FN = $" + totalChargingCost.ToString("0.00") + " CAD",
                "HST 13 % = $" + totalTax.ToString("0.00") + " CAD",
                "Total = $" + totalHostingCost.ToString("0.00") + " CAD",
            };
        }
    }
}
