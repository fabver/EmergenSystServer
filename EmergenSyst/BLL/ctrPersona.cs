using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;
using Newtonsoft.Json;

namespace BLL
{
    public class ctrPersona
    {
        PersonaDAO pDAO = new PersonaDAO();
        public string insertar(Persona p)
        {
            string r="";
            bool band = true;
            if (!esCedulaValida(p.cedula))
            {
                r += "Cedula ";
                band = false;
            }
            if (!esNombreValido(p.nombres))
            {
                r += "Nombres ";
                band = false;
            }
            if (!esApellidoValido(p.apellidos))
            {
                r += "Apellidos ";
                band = false;
            }
            if (!esFechaValida(p.fNacimiento))
            {
                r += "Fecha ";
                band = false;
            }
            if (band)
            {
                int result = pDAO.insertar(p);
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
            }
            else
            {
                r = "Los siguientes datos no cumplen las especificaciones dadas: " + r;
            }
            return r;
        }

        public string modificar(Persona p)
        {
            string r = "";
            bool band = true;
            if (!esCedulaValida(p.cedula))
            {
                r += "Cedula ";
                band = false;
            }
            if (!esNombreValido(p.nombres))
            {
                r += "Nombres ";
                band = false;
            }
            if (!esApellidoValido(p.apellidos))
            {
                r += "Apellidos ";
                band = false;
            }
            if (!esFechaValida(p.fNacimiento))
            {
                r += "Fecha ";
                band = false;
            }
            if (band)
            {
                int result = pDAO.update(p, p.cedula);
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
            }
            else
            {
                r = "Los siguientes datos no cumplen las especificaciones dadas: " + r;
            }
            return r;
        }

        public string setPersona(string cod)
        { 
            string persona;
            persona = Newtonsoft.Json.JsonConvert.SerializeObject(pDAO.select(cod));
            return persona;
            
        }

        private bool esCedulaValida(string ced)
        {
            bool r = false;
            if (ced.Length >= 10 && ced.Length <= 15)
            {
                r = true;
            }
            return r;
        }

        private bool esNombreValido(string nom)
        {
            bool r = false;
            if (nom.Length >= 3 && nom.Length <= 30)
            {
                r = true;
            }
            return r;
        }

        private bool esApellidoValido(string apll)
        {
            bool r = false;
            if (apll.Length >= 3 && apll.Length <= 30)
            {
                r = true;
            }
            return r;
        }

        private bool esFechaValida(DateTime fecha)
        {
            bool r = false;
            DateTime hoy = DateTime.Today;
            if (fecha.CompareTo(hoy) < 0)
            {
                r = true;
            }
            return r;
        }

    }
}
