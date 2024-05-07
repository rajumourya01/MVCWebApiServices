using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVCWebApiServices.Controllers
{
    public class TestController : ApiController
    {

       static List<string> Colors = new List<string>() { "red", "yellow", "Blue", "pink", "green" };

        public IEnumerable<string> Get()
        {
            return Colors;
        }

        public string Get(int id) 
        {
        return Colors[id];
        }

        public void Post([FromBody] string data)
        {
        Colors.Add(data);
        }

        public void Delete(int id)
        {
            Colors.Remove(Colors[id]);
        }

        public void Put(int id, [FromBody] string data)
        {
            Colors[id] = data;
        }


    }

    
}
