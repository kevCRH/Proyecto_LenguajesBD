using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoLBD
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        //IMPORTANTE
        /*Cada uno debe crear su base de datos, basandose en el SCRIPT 4
          que esta en el repositorio en su SQL DEVELOPER.
          Nombre del usuario "PROYECTO"
          Password: 1234
          Crearla en ORCL, NO en XE o otro
          SI NO COINCIDEN LOS DATOS LA BASE DE DATOS NO SE LES ABRIRA*/
        OracleConnection database = new OracleConnection("DATA SOURCE = ORCL ; PASSWORD=1234; USER ID = PROYECTO;");

        private void bt_login_Click(object sender, EventArgs e)
        {
            
            database.Open();
            OracleCommand comando = new OracleCommand("SELECT * FROM TBCORREO WHERE ATCORREO = :email AND ATCONTRASENNA = :pass", database);

            comando.Parameters.AddWithValue(":email", txt_email.Text);
            comando.Parameters.AddWithValue(":pass", txt_pass.Text);

            OracleDataReader lectura = comando.ExecuteReader();

            if (lectura.Read())
            {
                Form2 formulario = new Form2();
                database.Close();
                MessageBox.Show("Conectado");
                formulario.Show();
            }
            else {
                MessageBox.Show("Error al ingresar");
                database.Close();
            }
            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}