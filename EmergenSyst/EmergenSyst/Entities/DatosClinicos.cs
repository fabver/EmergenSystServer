using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Entities
{
    //abstract 
    public class DatosClinicos
    {
        public string cedula { get; set; }
        public string tipo { get; set; }
        public string descripcion { get; set; }

        //protected static MySqlConnection cnn = new MySqlConnection();
        //public abstract bool insertar();
    }
}
