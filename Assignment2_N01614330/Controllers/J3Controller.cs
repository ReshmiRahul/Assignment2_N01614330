using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2_N01614330.Controllers
{
    [RoutePrefix("api/J3")]
    public class J3Controller : ApiController
    {
        /// <summary>
        /// Encrypts a string using a simple Caesar cipher with a fixed shift.
        /// </summary>
        /// <param name="input">The string to encrypt</param>
        /// <param name="shift">The number of positions to shift each character</param>
        /// <returns>The encrypted string</returns>
        /// <example>
        /// GET ../api/J3/Encrypt/hello/2 -> "jgnnq"
        /// GET ../api/J3/Encrypt/abc/1 -> "bcd"
        /// </example>
        
        [HttpGet]
        [Route("Encrypt/{input}/{shift}")]
        public string Get(string input, int shift)
        {
            char[] buffer = input.ToCharArray();
            for (int i = 0; i < buffer.Length; i++)
            {
                char letter = buffer[i];
                letter = (char)(letter + shift);
                if (letter > 'z')
                {
                    letter = (char)(letter - 26);
                }
                else if (letter < 'a')
                {
                    letter = (char)(letter + 26);
                }
                buffer[i] = letter;
            }
            return new string(buffer);
        }
    }
}

       