using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI_Practice.Controllers
{
    public class WebAPIController : ApiController
    {


        private static List<string> studentNames = new List<string> { "Guru" ,"Lisa", "Karen" };




        //To retrieve values as it is .........................

        [HttpGet]
        public IEnumerable<string> GetNames()
        {
            return studentNames;
        }

        


        //To retrive values based on index stored used id parameters..........
        [HttpGet]
        public string GetNamesById(int id)
        {
            return studentNames[id];
        }
    }
}
