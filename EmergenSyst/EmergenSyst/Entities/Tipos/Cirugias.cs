using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Cirugias : DatosClinicos
    {
        //public override bool insertar()
        //{
        //    bool r;
        //    cnn = new MySqlConnection();
        //    string cadena = "Server=localhost;Database=emergensyst;User id=root;Password=";
        //    try
        //    {
        //        cnn.ConnectionString = cadena;
        //        cnn.Open();
        //        string query = "insert into cirugias values (?id,?desc);";
        //        MySqlCommand cmd = new MySqlCommand(query, cnn);
        //        cmd.Parameters.AddWithValue("id", this.cedula);
        //        cmd.Parameters.AddWithValue("desc", this.descripcion);
        //        cmd.Prepare();
        //        cmd.ExecuteNonQuery();
        //        r = true;
        //        cnn.Close();
        //    }
        //    catch (MySqlException)
        //    {
        //        r = false;
        //        cnn.Close();
        //    }
        //    return r;
        //}
    }
}
