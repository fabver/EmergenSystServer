using BLL;
using Entities;
using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;

namespace RestfulApi.Hubs
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class EmergencyCallHub : Hub
    {
        ctrHistoriaClinica ctrHC = new ctrHistoriaClinica();
        public void sendEmergencyCall(GeoLocation latlng)
        {
            HistoriaClinica hc;
            hc = ctrHC.getHistoriaClinca(latlng.cedula);
            Clients.All.newNotify(latlng, hc);
        }
    }
}