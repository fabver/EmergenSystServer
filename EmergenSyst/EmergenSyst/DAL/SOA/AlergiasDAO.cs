using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class AlergiasDAO : DatosClinicosDAO
    {
        public override bool insertar(DatosClinicos al)
        {
            bool r= true;
            try
            {
                cnn = db.conexion();
                //cnn.Open();
                string query = "insert into alergias values (?id,?desc);";
                MySqlCommand cmd = new MySqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("id", al.cedula);
                cmd.Parameters.AddWithValue("desc", al.descripcion);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
            catch (MySqlException)
            {
                r = false;
                cnn.Close();
            }
            return r;
        }
    }
}
