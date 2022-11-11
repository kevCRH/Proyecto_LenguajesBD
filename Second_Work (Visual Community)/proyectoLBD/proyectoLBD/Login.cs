using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoLBD
{
    public partial class frm_login : Form
    {
        //Se inicializan variables para poder crear placeholders en los textbox de email y pass
        string ph_email = "";
        string ph_pass = "";

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
                frm_tipo_Donacion formulario = new frm_tipo_Donacion();
                database.Close();
                //MessageBox.Show("Conectado"); //Msj para confirmar que todo este bien
                formulario.Show();
                this.Hide(); //Oculta la ventana si el login es exitoso
                
            }
            else {
                MessageBox.Show("Usuario o Contraseña incorrecta"); //Esto se puede mejorar
                database.Close();
            }
            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_login_Load(object sender, EventArgs e)
        {
        //Se cargan los textbox con los textos que se quieren mostrar, abajo se configura cada uno de los textbox
            txt_email.Text = "Correo electronico";
            txt_email.ForeColor = Color.Gray;
            txt_pass.PasswordChar = '\0';
            txt_pass.Text = "Contraseña";
            txt_pass.ForeColor = Color.Gray;
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

        //Configuracion del boton Email, tanto entrada como salida
        private void txt_email_Enter(object sender, EventArgs e)
        {
            txt_email.Text = "";
            txt_email.ForeColor = Color.Black;
        }

        private void txt_email_Leave(object sender, EventArgs e)
        {
            ph_email = txt_email.Text;
            if (ph_email.Equals("Correo electronico")){
                txt_email.Text = "Correo electronico";
                txt_email.ForeColor = Color.Gray;
            }
            else {
                if (ph_email.Equals("")) {
                    txt_email.Text = "Correo electronico";
                    txt_email.ForeColor = Color.Gray;
                }
                else {
                    txt_email.Text = ph_email;
                    txt_email.ForeColor = Color.Black;
                }
            }
        }

        //Configuracion del boton Pass, tanto entrada como salida
        private void txt_pass_Enter(object sender, EventArgs e)
        {
            txt_pass.Text = "";
            txt_pass.ForeColor = Color.Black;
            txt_pass.PasswordChar = '*';
        }

        private void txt_pass_Leave(object sender, EventArgs e)
        {
            ph_pass = txt_pass.Text;
            if (ph_pass.Equals("Contraseña"))
            {
                txt_pass.Text = "Contraseña";
                txt_pass.ForeColor = Color.Gray;
            }
            else
            {
                if (ph_email.Equals(""))
                {
                    txt_pass.PasswordChar = '\0';
                    txt_pass.Text = "Contraseña";
                    txt_pass.ForeColor = Color.Gray;
                }
                else
                {
                    txt_pass.PasswordChar = '*';
                    txt_pass.Text = ph_pass;
                    txt_pass.ForeColor = Color.Black;
                }
            }
        }
    }
}