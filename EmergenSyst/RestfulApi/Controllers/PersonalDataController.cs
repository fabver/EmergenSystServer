using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Entities;
using BLL;


namespace RestfulApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class PersonalDataController : ApiController
    {
        ctrPersona ctrP = new ctrPersona();
        // GET api/personaldata
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2", "value3" };
        }

        // GET api/personaldata/5
        public string Get(int id)
        {
            return ctrP.setPersona(Convert.ToString(id));
        }

        // POST api/personaldata
        public string Post([FromBody]Persona person)
        {
            return ctrP.insertar(person);
        }

        // PUT api/personaldata/5
        public string Put(int id, [FromBody]Persona person)
        {
            return ctrP.modificar(person);
        }

        // DELETE api/personaldata/5
        public void Delete(int id)
        {
        }
    }
}
