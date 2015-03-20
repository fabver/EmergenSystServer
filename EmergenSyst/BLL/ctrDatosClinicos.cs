using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace BLL
{
    public class ctrDatosClinicos
    {
        CreatorDatosClinicosDAO creator = new CreatorDatosClinicosDAO();
        ClinicalDataDAO cdDAO = new ClinicalDataDAO();
        public string insertar(List<DatosClinicos> lstDC)
        {
            string r = "Datos guardados satisfactoriamente";
            bool band = true;
            int result=0;
            //foreach (DatosClinicos DC in lstDC)
            //{
            //    if (!esDatoValido(DC))
            //    {
            //        band = false;
            //        r = "Los datos no cumplen las especificaciones dadas.";
            //        break;
            //    }
            //}
            if (band)
            {
                result = cdDAO.insertar(lstDC); 
            }
            if (result == -2)
            {
                r = "Se produjo un error al guardar los datos";
            }
            else if (result == -1)
            {
                r = "Error al conectar con la base de datos";
            }
            else if (result == 1)
            {
                r = "Guardado satisfactoriamente";
            }
            return r;
        }

        public string getDatosClinicos(string cod)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(cdDAO.getDatosClinicos(cod));
        }

        private bool esDatoValido(DatosClinicos DC)
        {
            bool r = true;
            if (r && DC.cedula.Length < 10 || DC.cedula.Length > 15)
            {
                r = false;
            }
            if (r && (DC.descripcion.Length < 3 || DC.descripcion.Length > 255))
            {
                r = false;
            }
            return r;
        }
    }
}
