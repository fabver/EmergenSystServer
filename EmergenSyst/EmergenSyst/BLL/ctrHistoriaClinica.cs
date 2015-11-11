using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;

namespace BLL
{
    public class ctrHistoriaClinica
    {
        PersonaDAO pDAO = new PersonaDAO();
        ClinicalDataDAO cdDAO = new ClinicalDataDAO();
        public string getHistoriaClinca(string cod)
        {
            HistoriaClinica hc = new HistoriaClinica();
            hc.persona = pDAO.select(cod);
            hc.datosClinicos = cdDAO.getDatosClinicos(cod);
            return Newtonsoft.Json.JsonConvert.SerializeObject(hc);
        }
    }
}
