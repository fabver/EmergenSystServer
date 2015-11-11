using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class ClinicalDataDAO
    {
        private db db = new db();
        private static MySqlConnection cnn = new MySqlConnection();
        public int insertar(List<DatosClinicos> lstDC)
        {
            int r = 1;
            cnn = db.conexion();
            if (cnn == null)
            {
                r = -1;
            }
            else
            {
                try
                {
                    foreach (DatosClinicos dc in lstDC)
                    {
                        string query = "insert into clinicaldata values (?id,?tipo, ?descripcion);";
                        MySqlCommand cmd = new MySqlCommand(query, cnn);
                        cmd.Parameters.AddWithValue("id", dc.cedula);
                        cmd.Parameters.AddWithValue("tipo", dc.tipo);
                        cmd.Parameters.AddWithValue("descripcion", dc.descripcion);
                        cmd.Prepare();
                        cmd.ExecuteNonQuery();
                    }
                    cnn.Close();
                }
                catch (MySqlException)
                {
                    r = -2;
                    cnn.Close();
                }

            }
            return r;
        }

        public List<DatosClinicos> getDatosClinicos(string cod)
        {
            DatosClinicos dc;
            List<DatosClinicos> lstDC = new List<DatosClinicos>();
            cnn = db.conexion();
            if (cnn == null)
            {

            }
            else
            {
                try
                {
                    string query = "select * from clinicaldata where idPersona = ?id;";
                    MySqlCommand cmd = new MySqlCommand(query, cnn);
                    cmd.Parameters.AddWithValue("id", cod);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            dc = new DatosClinicos();
                            dc.cedula = Convert.ToString(dr["idPersona"]);
                            dc.tipo = Convert.ToString(dr["tipo"]);
                            dc.descripcion = Convert.ToString(dr["descripcion"]);
                            lstDC.Add(dc);
                        }
                    }
                }
                catch (MySqlException)
                {

                }
            }
            return lstDC;
        }

    }
}
