using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using MySql.Data.MySqlClient;


namespace DAL
{
    public class PersonaDAO
    {
        private Persona p = new Persona();
        private db db = new db();
        private static MySqlConnection cnn = new MySqlConnection();

        public int insertar(Persona p)
        {
            int r=1;
            cnn = db.conexion();
            if (cnn == null)
            {
                r = -1;
            }
            else
            {
                try
                {
                    
                    string query = "insert into persona values (?id,?nom,?apll,?fNac,?sexo, ?foto);";
                    MySqlCommand cmd = new MySqlCommand(query, cnn);
                    cmd.Parameters.AddWithValue("id", p.cedula);
                    cmd.Parameters.AddWithValue("nom", p.nombres);
                    cmd.Parameters.AddWithValue("apll", p.apellidos);
                    cmd.Parameters.AddWithValue("fNac", p.fNacimiento);
                    cmd.Parameters.AddWithValue("sexo", p.sexo);
                    cmd.Parameters.AddWithValue("foto", p.foto);
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
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

        public int update(Persona p, string ced)
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

                    string query = "update persona set idPersona = ?id, nombres = ?nom, apellidos = ?apll, fNacimiento = ?fNac, sexo = ?sexo where idPersona = ?id;";
                    MySqlCommand cmd = new MySqlCommand(query, cnn);
                    cmd.Parameters.AddWithValue("id", p.cedula);
                    cmd.Parameters.AddWithValue("nom", p.nombres);
                    cmd.Parameters.AddWithValue("apll", p.apellidos);
                    cmd.Parameters.AddWithValue("fNac", p.fNacimiento);
                    cmd.Parameters.AddWithValue("sexo", p.sexo);
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
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

        public Persona select(string cod)
        {
            Persona p = null;
            cnn = db.conexion();
            if (cnn == null)
            {
                
            }
            else
            {
                try
                {
                    p = new Persona();
                    string query = "select * from persona where idPersona = ?id;";
                    MySqlCommand cmd = new MySqlCommand(query, cnn);
                    cmd.Parameters.AddWithValue("id", cod);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows){
                        while (dr.Read()){
                            p.cedula = Convert.ToString(dr["idPersona"]);
                            p.nombres = Convert.ToString(dr["nombres"]);
                            p.apellidos = Convert.ToString(dr["apellidos"]);
                            p.fNacimiento = Convert.ToDateTime(dr["fNacimiento"]);
                            p.sexo = Convert.ToChar(dr["sexo"]);
                            p.foto = Convert.ToString(dr["foto"]);
                        }
                    }
                }
                catch (MySqlException)
                {
                    
                }
                cnn.Close();
            }
            return p;
        }
    }
}
