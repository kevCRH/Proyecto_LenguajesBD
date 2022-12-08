using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace proyectoLBD
{
    public partial class AgregarDonacionEspecie : Form
    {
        public AgregarDonacionEspecie()
        {
            InitializeComponent();
        }

     
        private void Button1_Click(object sender, EventArgs e)
        {
            
            OracleConnection database = new OracleConnection("DATA SOURCE = ORCL ; PASSWORD=1234; USER ID = PROYECTO;");
            try
            {
                database.Open();
                //Declaramos los procedimientos almacenados
                OracleCommand usuario = new OracleCommand("AGREGAR_USUARIO", database);
                OracleCommand correo = new OracleCommand("AGREGAR_CORREO", database);
                OracleCommand telefono = new OracleCommand("AGREGAR_TELEFONO", database);
                OracleCommand donacion = new OracleCommand("INSERTAR_DONACION", database);

                //Registramos la persona que hizo la donacion en la tabla usuarios como roll de donante
                usuario.CommandType = System.Data.CommandType.StoredProcedure;
                usuario.Parameters.Add("pNombre", OracleType.VarChar).Value = txt_user.Text;
                usuario.Parameters.Add("pApellido_1", OracleType.VarChar).Value = textBox2.Text;
                usuario.Parameters.Add("pApellido_2", OracleType.VarChar).Value = textBox4.Text;
                usuario.Parameters.Add("pCedula", OracleType.VarChar).Value = textBox8.Text;
                usuario.Parameters.Add("pRol", OracleType.VarChar).Value = "Donante";

                //Registramos el correo de la persona

                correo.CommandType = System.Data.CommandType.StoredProcedure;
                correo.Parameters.Add("pCorreo", OracleType.VarChar).Value = textBox6.Text;
                correo.Parameters.Add("pDuenoCorreo", OracleType.VarChar).Value = textBox8.Text;
                correo.Parameters.Add("pCategoriaCorreo", OracleType.VarChar).Value = "Usuario";

                //Registramos el telefono de la persona

                telefono.CommandType = System.Data.CommandType.StoredProcedure;
                telefono.Parameters.Add("pTelefono", OracleType.VarChar).Value = textBox7.Text;
                telefono.Parameters.Add("pDuenoTelefono", OracleType.VarChar).Value = textBox8.Text;
                telefono.Parameters.Add("pCategoriaTelefono", OracleType.VarChar).Value = "Usuario";

                //Registramos la donacion

                donacion.CommandType = System.Data.CommandType.StoredProcedure;
                donacion.Parameters.Add("pFecha", OracleType.DateTime).Value = dateTimePicker1.Value;
                donacion.Parameters.Add("pProcedencia", OracleType.VarChar).Value = textBox1.Text;
                donacion.Parameters.Add("pNumeroRecibo", OracleType.VarChar).Value = textBox5.Text;
                donacion.Parameters.Add("pCedulaUsuario", OracleType.VarChar).Value = textBox8.Text;
                donacion.Parameters.Add("pCedulaUsuarioCaptacion", OracleType.VarChar).Value = textBox13.Text;

                //los chechBox se encargaràn de validar la opcion de que provincia se seleccion,
                //Si no se seleccion una sede mostrara una alerta
                if (checkBox3.Checked)
                {
                    donacion.Parameters.Add("pSede", OracleType.VarChar).Value = "San Jose";
                }
                else if (checkBox7.Checked)
                {
                    donacion.Parameters.Add("pSede", OracleType.VarChar).Value = "Alajuela";
                }
                else if (checkBox8.Checked)
                {
                    donacion.Parameters.Add("pSede", OracleType.VarChar).Value = "Puntarenas";
                }
                else
                {
                    MessageBox.Show("Seleccione una sede");
                }
                //Se capturan las descripcion de la donacion y la cantidad    
                donacion.Parameters.Add("pTipoDonacion", OracleType.Number).Value = 2;  
                donacion.Parameters.Add("pCantidad", OracleType.VarChar).Value = textBox9.Text;
                donacion.Parameters.Add("pDescripcion", OracleType.VarChar).Value = textBox3.Text;

                //Al ser el form de las donaciones se envian los parametros directos de los espacios monetarios
                donacion.Parameters.Add("pMetodoPago", OracleType.VarChar).Value = "N/A";
                donacion.Parameters.Add("pMonto", OracleType.VarChar).Value = "0";
                
                //Se ejecutan cada uno de los objetos que contienen los parametros que se enviaran al procedimiento almacenado
                usuario.ExecuteNonQuery();
                correo.ExecuteNonQuery();
                telefono.ExecuteNonQuery();
                donacion.ExecuteNonQuery();

                //Alerta sobre que la donacion se agrego con exito y limpiamos cada uno de los espacios de la donacion
                MessageBox.Show("La donacion se agrego");
                txt_user.Clear();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();
                textBox13.Clear();
                checkBox3.Checked = false;
                checkBox7.Checked = false;
                checkBox8.Checked = false;

            }
            catch(Exception)
            {
                //Si se detecta un fallo se mostrara la alerta de que algo ocurrio
                MessageBox.Show("Algo fallo, asegurese de que los datos a ingresar sean correctos");

            }    
            database.Close();

        }

        private void AgregarDonacion_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActualizarDonacionEspecie actualizarDonacion = new ActualizarDonacionEspecie();
            actualizarDonacion.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListarDonacionesEspecie listarDonaciones = new ListarDonacionesEspecie();
            listarDonaciones.Show();
            this.Hide();
        }

        private void bt_atrás_Click(object sender, EventArgs e)
        {
            if (Program.varglobal.valorRol.Equals(1)) { 
                TipoDonacionAdmin formulario = new TipoDonacionAdmin();
                formulario.Show();
                this.Hide();
            }
            else {
                TipoDonacion formulario = new TipoDonacion();
                formulario.Show();
                this.Hide();
            }
        }

        private void bt_logout_Click(object sender, EventArgs e)
        {
            //Mensaje de confirmación para Cerrar Sesión
            DialogResult dr = MessageBox.Show("¿Está seguro que quiere Cerrar Sesión?",
                "CERRAR SESION", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (dr == DialogResult.Yes) //Si le da que SI entonces cierra sesión
            {
                frm_login formulario = new frm_login();
                formulario.Show();
                this.Hide();
            }
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
