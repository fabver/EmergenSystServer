using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class MedicamentosDAO : DatosClinicosDAO
    {
        public override bool insertar(DatosClinicos med)
        {
            bool r = true;
            try
            {
                cnn = db.conexion();
                //cnn.Open();
                string query = "insert into medicamentos values (?id,?desc);";
                MySqlCommand cmd = new MySqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("id", med.cedula);
                cmd.Parameters.AddWithValue("desc", med.descripcion);
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
