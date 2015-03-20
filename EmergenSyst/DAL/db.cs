using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class db
    {
        private MySqlConnection cnn = null;
        //private int FilasAfectadas = 0;

        public db()
        {
            try
            {
                cnn = new MySqlConnection();
                string cadena = "Server=localhost;Database=emergensyst;User id=root;Password=";
                cnn.ConnectionString = cadena;
                cnn.Open();
                //Console.WriteLine("Conectado");
            }
            catch(MySqlException)
            {
                //Console.WriteLine("No conectado" + ex);
            }
        }

        public MySqlConnection conexion()
        {
            return cnn;
        }
    }
}
