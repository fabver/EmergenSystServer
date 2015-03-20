using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private MySqlConnection cnn = null;
        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                cnn= new MySqlConnection();
                cnn.ConnectionString = "Server=localhost;Database=emergensyst;User id=root;Password=";
                cnn.Open();
                MessageBox.Show ("Conectado");
                Console.WriteLine("Conectado");
                cnn.Close();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("No conectado" + ex);
            }
        }
    }
}
