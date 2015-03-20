using BLL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace RestfulApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ClinicalDataController : ApiController
    {
        ctrDatosClinicos ctrDC = new ctrDatosClinicos();
        // GET api/clinicaldata
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/clinicaldata/5
        public string Get(int id)
        {
            return ctrDC.getDatosClinicos(Convert.ToString(id));
        }

        // POST api/clinicaldata
        public string Post([FromBody]List<DatosClinicos> lstDC)
        {
            return ctrDC.insertar(lstDC);
        }

        // PUT api/clinicaldata/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/clinicaldata/5
        public void Delete(int id)
        {
        }
    }
}
