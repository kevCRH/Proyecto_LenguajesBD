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
            try {
                database.Open();
                /* --------------LOGIN CON STORED PROCEDURE--------------*/
                OracleCommand comandoLogin = new OracleCommand("USUARIO_LOGIN", database);
                comandoLogin.CommandType = CommandType.StoredProcedure;

                /*Se envian los datos al procedimiento almacenado para que sean verificados*/
                comandoLogin.Parameters.Add("pATUSUARIO", OracleType.VarChar).Value = txt_user.Text;
                comandoLogin.Parameters.Add("pATCONTRASENNA", OracleType.VarChar).Value = txt_pass.Text;


                /*Se obtienen las variables del procedimiento almacenado*/
                comandoLogin.Parameters.Add("pVERIFICAR", OracleType.Number).Direction = ParameterDirection.Output;
                comandoLogin.Parameters.Add("pROL", OracleType.Number).Direction = ParameterDirection.Output;

                //Se ejecuta los datos obtenidos para poder leerlos posteriormente
                comandoLogin.ExecuteNonQuery();

                if (comandoLogin.Parameters["pVERIFICAR"].Value.ToString().Equals("1"))
                {
                    //--------------Verificación de roles (administrador o empleado)------------------------------

                    if (comandoLogin.Parameters["pROL"].Value.ToString().Equals("1"))
                    {
                        //Ejecutamos la clase global para posteriormente guardar una variable
                        //que nos permita conocer el Rol del Usuario en todo momento
                        Program.varglobal.valorRol = 1;

                        MenuAdministrador formAdmin = new MenuAdministrador();
                        database.Close();//se cierra la base de datos para que no de problema
                        formAdmin.Show();//muestra el formulario
                        this.Hide(); //Oculta la ventana si el lee el dato

                    }
                    //si no se cumple la condicion de que el usuario sea Administrador lo manda al form de empleados el cual es TipoDonacion
                    else
                    {
                        //Ejecutamos la clase global para posteriormente guardar una variable
                        //que nos permita conocer el Rol del Usuario en todo momento
                        Program.varglobal.valorRol = 2;

                        TipoDonacion formEmpleado = new TipoDonacion();
                        database.Close();//se cierra la base de datos para que no de problema
                        formEmpleado.Show();//muestra el formulario
                        this.Hide(); //Oculta la ventana si lee el dato
                    }                    
                }
                else{
                    MessageBox.Show("Usuario o Contraseña incorrecta"); //Esta vista se puede mejorar (Diseño)
                    database.Close();
                    txt_user.Clear();
                    txt_pass.Clear();

                }
            }
            catch{
                MessageBox.Show("Error en el sistema, algo fallo");
                txt_user.Clear();
                txt_pass.Clear();
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

        private void CargarUsuarios_Click(object sender, EventArgs e)
        {
            ListarUsuarios listarUsuarios =   new ListarUsuarios();
            listarUsuarios.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AgregarSede agregarSede = new AgregarSede();
            agregarSede.Show();
        }

        private void bt_loggin_quemado_Click(object sender, EventArgs e)
        {
            TipoDonacion formulario = new TipoDonacion();
            formulario.Show();
            this.Hide(); //Oculta la ventana si el login es exitoso
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MenuAdministrador formulario = new MenuAdministrador();
            formulario.Show();
            this.Hide(); //Oculta la ventana si el login es exitoso
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close(); //Evento click del botón cerrar
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            //Evento click del botón máximizar
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            //Evento click del botón minimizar
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Minimized;
            else if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Minimized;
        }
    }
}