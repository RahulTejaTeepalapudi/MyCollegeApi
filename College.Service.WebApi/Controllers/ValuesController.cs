using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace College.Service.WebApi.Controllers
{
    [Authorize]
    public class ValuesController : ApiController
    {
        /// <summary>
        /// Gets all the values
        /// </summary>
        /// <returns> Array of Values </returns>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// Gets a value based on id
        /// </summary>
        /// <param name="id"> id to get value </param>
        /// <returns> string value </returns>
        public string Get(int id)
        {
            return "value";
        }

        /// <summary>
        /// post bulk values to database
        /// </summary>
        /// <param name="value"> value to be saved</param>
        public void Post([FromBody]string value)
        {
        }

       /// <summary>
       /// save specific value to database based on id
       /// </summary>
       /// <param name="id"></param>
       /// <param name="value"></param>
        public void Put(int id, [FromBody]string value)
        {
        }

        /// <summary>
        /// Delete a specific value based on id
        /// </summary>
        /// <param name="id"> id to be deleted </param>
        public void Delete(int id)
        {
        }
    }
}
