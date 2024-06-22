using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2_N01614330.Controllers
{
    /// <summary>
    /// Controller for solving the J3 problem - Temperature conversion between Celsius and Fahrenheit
    /// </summary>
    [RoutePrefix("api/J3")]
    public class J3Controller : ApiController
    {
        /// <summary>
        /// Converts a temperature from Celsius to Fahrenheit or Fahrenheit to Celsius.
        /// </summary>
        /// <param name="temp">The temperature to convert</param>
        /// <param name="scale">The scale to convert from (C for Celsius, F for Fahrenheit)</param>
        /// <returns>The converted temperature</returns>
        /// <example>
        /// GET ../api/J3/ConvertTemp/100/C -> "212 F"
        /// GET ../api/J3/ConvertTemp/32/F -> "0 C"
        /// </example>
        [HttpGet]
        [Route("ConvertTemp/{temp}/{scale}")]
        public string Get(float temp, string scale)
        {
            string result;

            if (scale.ToUpper() == "C")
            {
                // Convert Celsius to Fahrenheit
                float fahrenheit = (temp * 9 / 5) + 32;
                result = $"{temp} C is {fahrenheit} F";
            }
            else if (scale.ToUpper() == "F")
            {
                // Convert Fahrenheit to Celsius
                float celsius = (temp - 32) * 5 / 9;
                result = $"{temp} F is {celsius} C";
            }
            else
            {
                // Invalid scale input
                result = "Invalid scale. Please use 'C' for Celsius or 'F' for Fahrenheit.";
            }

            return result;
        }
    }
}
