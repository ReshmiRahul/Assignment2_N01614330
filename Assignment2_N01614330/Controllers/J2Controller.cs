using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;

namespace Assignment2_N01614330.Controllers
{
    [RoutePrefix("api/J2")]
    public class J2Controller : ApiController
    {
        /// <summary>
        /// Determines how many ways two dice can roll the value of 10.
        /// </summary>
        /// <param name="m">Number of sides on the first die</param>
        /// <param name="n">Number of sides on the second die</param>
        /// <returns>Number of ways to get the sum of 10</returns>
        /// <example>
        /// GET ../api/J2/DiceGame/6/8 -> "There are 5 total ways to get the sum 10."
        /// GET ../api/J2/DiceGame/12/4 -> "There are 4 ways to get the sum 10."
        /// </example>
        [HttpGet]
        [Route("DiceGame/{m}/{n}")]
        public string Get(int m, int n)
        {
            int count = 0;
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i + j == 10)
                    {
                        count++;
                    }
                }
            }

            return $"There are {count} total ways to get the sum 10.";
        }
    }
}