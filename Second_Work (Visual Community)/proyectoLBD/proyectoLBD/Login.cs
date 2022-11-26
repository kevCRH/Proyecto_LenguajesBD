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
        string ph_user = "";
        string ph_pass = "";

        public frm_login()
        {
            InitializeComponent();
        }

        //IMPORTANTE
        /*Cada uno debe crear su base de datos, basandose en el SCRIPT 6
          que esta en el repositorio en su SQL DEVELOPER.
          Nombre del usuario "PROYECTO"
          Password: 1234
          Crearla en ORCL, NO en XE o otro
          SI NO COINCIDEN LOS DATOS LA BASE DE DATOS NO SE LES ABRIRA*/

        OracleConnection database = new OracleConnection("DATA SOURCE = ORCL ; PASSWORD=1234; USER ID = PROYECTO;");
        private void bt_login_Click(object sender, EventArgs e)
        {
            database.Open();
            /* --------------LOGIN CON STORED PROCEDURE--------------*/
            OracleCommand comando = new OracleCommand("USUARIO_LOGIN", database);
            comando.CommandType = CommandType.StoredProcedure;
            
            /*Se envian los datos al procedimiento almacenado para que sean verificados*/
            comando.Parameters.Add("pATUSUARIO", OracleType.VarChar).Value = txt_user.Text;
            comando.Parameters.Add("pATCONTRASENNA", OracleType.VarChar).Value = txt_pass.Text;
            
            /*Forma larga de obtener variable del procedimiento almacenado*/
            //comando.Parameters.Add("pVERIFICAR", OracleType.VarChar, 120);
            //comando.Parameters["pVERIFICAR"].Direction = ParameterDirection.Output;
            
            /*Forma corta de obtener variable del procedimiento almacenado*/
            comando.Parameters.Add("pVERIFICAR", OracleType.Number).Direction = ParameterDirection.Output;
            
            //Se ejecuta los datos obtenidos para poder leerlos posteriormente
            comando.ExecuteNonQuery();

            if (comando.Parameters["pVERIFICAR"].Value.ToString().Equals("1"))
            {   
                frm_tipo_Donacion formulario = new frm_tipo_Donacion();
                database.Close();
                //MessageBox.Show("Conectado"); //Msj para confirmar que todo este bien
                formulario.Show();
                this.Hide(); //Oculta la ventana si el login es exitoso

            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrecta"); //Esta vista se puede mejorar (Diseño)
                database.Close();
            }
            
            /* --------------LOGIN CON SELECT-------------- 
            OracleCommand comando = new OracleCommand("SELECT * FROM TBUSUARIOS WHERE ATUSUARIO = :usuario AND ATCONTRASENNA = :pass", database);
            comando.Parameters.AddWithValue(":usuario", txt_user.Text);
            comando.Parameters.AddWithValue(":pass", txt_pass.Text);*/

            /*OracleDataReader lectura = comando.ExecuteReader();

            if (lectura.Read())
            {
                frm_tipo_Donacion formulario = new frm_tipo_Donacion();
                database.Close();
                MessageBox.Show("Conectado"); //Msj para confirmar que todo este bien
                formulario.Show();
                this.Hide(); //Oculta la ventana si el login es exitoso
            }
            else {
                MessageBox.Show("Usuario o Contraseña incorrecta"); //Esto se puede mejorar
                database.Close();
            }*/
        }

        private void frm_login_Load(object sender, EventArgs e)
        {
        /*Se cargan los textbox con los textos que se quieren mostrar, abajo se
        configura cada uno de los textbox*/
            txt_user.Text = "Usuario";
            txt_user.ForeColor = Color.Gray;
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

        //Configuracion del boton User, tanto entrada como salida
        private void txt_email_Enter(object sender, EventArgs e)
        {
            txt_user.Text = "";
            txt_user.ForeColor = Color.Black;
        }

        private void txt_email_Leave(object sender, EventArgs e)
        {
            ph_user = txt_user.Text;
            if (ph_user.Equals("Usuario")){
                txt_user.Text = "Usuario";
                txt_user.ForeColor = Color.Gray;
            }
            else {
                if (ph_user.Equals("")) {
                    txt_user.Text = "Usuario";
                    txt_user.ForeColor = Color.Gray;
                }
                else {
                    txt_user.Text = ph_user;
                    txt_user.ForeColor = Color.Black;
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
                if (ph_user.Equals(""))
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarUsuario AgregarUsario = new AgregarUsuario();
            AgregarUsario.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AgregarDonacion donacion = new AgregarDonacion();
            donacion.Show();
        }
    }
}