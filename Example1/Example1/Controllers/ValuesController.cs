using Example1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Example1.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public List<Value> Get()
        {
            List<Value> valuesList = new List<Value>();
            valuesList.Add(new Value().GetValue());
            return valuesList;
        }

        // GET api/values/5
        public string Get(int id)
        {
            //var stringbla = string.Format("{ \"Name\" : \"carel\" }"
            return "[{\"text\": \"Daar\",\"nodetype\": \"Action\",\"id\": \"2\",\"nodes\": [{\"text\": \"Step2\",\"nodetype\": \"ActionStep\",\"id\": \"3\",\"nodes\": [{\"text\": \"TestDocument\",\"nodetype\": \"DocumentType\",\"id\": \"1\"}]},{\"text\": \"Step3\",\"nodetype\": \"ActionStep\",\"id\": \"4\"}]}]";
        }

        // POST api/values
        public void Post(Value value)
        {
        }

        // PUT api/values/5
        public void Put(int id, Value value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
