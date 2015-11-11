using Entities;
using RestfulApi.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using NotSignalR;

namespace RestfulApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class EmergencyCallController : ApiController
    {
        EmergencyCallHub ecHub = new EmergencyCallHub();
        public INotificadorSignalR Notificador;
        // POST api/emergencycall
        public string Post([FromBody]string data)
        {
            Notificador.Notificar(data);
            //ecHub.sendMessage(data);
            return "Listo";
        }

    }
}
