using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using MySql.Data.MySqlClient;

namespace DAL
{
    public abstract class DatosClinicosDAO
    {
        protected Persona p = new Persona();
        protected db db = new db();
        protected static MySqlConnection cnn = new MySqlConnection();
        public abstract bool insertar(DatosClinicos dc);
    }
}
