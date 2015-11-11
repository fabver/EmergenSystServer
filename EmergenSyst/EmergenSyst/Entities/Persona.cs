using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Persona
    {
        public string foto { get; set; }
        public string cedula { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public DateTime fNacimiento { get; set; }
        public char sexo { get; set; }
        public int edad { get { return getEdad(); } }
        public Persona()
        {

        }
        public Persona(string ced, string nom, string apll, DateTime fNac, char sexo)
        {
            this.cedula = ced;
            this.nombres = nom;
            this.apellidos = apll;
            this.fNacimiento = fNac;
            this.sexo = sexo;
        }

        private int getEdad(){
            int edad = 0;
            DateTime fNac = this.fNacimiento;
            DateTime now = DateTime.Today;
            edad = now.Year - fNac.Year;
            //if (fNac.DayOfYear >= now.DayOfYear)
            //{
            //    edad = edad - 1;
            //}
            if (now.Month < fNac.Month)
            {
                edad = edad - 1;
            }
            if (now.Month == fNac.Month)
            {
                if (now.Day < fNac.Day)
                {
                    edad = edad - 1;
                }
            }
            return edad;
        }

    }
}
