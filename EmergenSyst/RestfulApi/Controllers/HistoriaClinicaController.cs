﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using BLL;
using Entities;

namespace RestfulApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class HistoriaClinicaController : ApiController
    {
        ctrHistoriaClinica ctrHC = new ctrHistoriaClinica();
        // GET api/historiaclinica
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/historiaclinica/5
        public string Get(int id)
        {
            HistoriaClinica hc;
            hc = ctrHC.getHistoriaClinca(Convert.ToString(id));
            return Newtonsoft.Json.JsonConvert.SerializeObject(hc); ;
        }

        // POST api/historiaclinica
        public void Post([FromBody]string value)
        {
        }

        // PUT api/historiaclinica/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/historiaclinica/5
        public void Delete(int id)
        {
        }
    }
}
