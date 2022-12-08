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
    public partial class ActualizarUsuario : Form
    {
        OracleConnection database = new OracleConnection("DATA SOURCE = ORCL ; PASSWORD=1234; USER ID = PROYECTO;");
        public ActualizarUsuario()
        {
            InitializeComponent();
        }

        private void txt_navBar_Click(object sender, EventArgs e)
        {

        }

        private void panel_fondoCeleste_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                database.Open();
                OracleCommand donacion = new OracleCommand("BuscarUsuario", database); //llamamos procedure
                donacion.CommandType = System.Data.CommandType.StoredProcedure; //especificamos que la instancia es un procedure
                donacion.Parameters.AddWithValue("pCedula", txtCedula.Text); //parametro que recibira  
                donacion.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output; //definimos una direccion
                OracleDataAdapter adaptador = new OracleDataAdapter();
                adaptador.SelectCommand = donacion;//Comando que tiene el procedimiento almacenado
                DataTable tabla = new DataTable();//Creamos un data table
                adaptador.Fill(tabla);//Aca se llena la tabla con los datos
                dgvUsuario.DataSource = tabla;//y le decimos que se reflejen los datos a nivel de diseno en la tabla
            }
            catch
            {
                MessageBox.Show("Usuario no encontrado, algo fallo");
            }
            database.Close();
        }

        private void bt_atrás_Click(object sender, EventArgs e)
        {
            AgregarUsuario agregarUsuario = new AgregarUsuario();
            agregarUsuario.Show();
            this.Hide();
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

        private void txtActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                database.Open();
                OracleCommand ActualizarUsuario = new OracleCommand("ActualizarUsuario", database); //llamamos procedure
                ActualizarUsuario.CommandType = System.Data.CommandType.StoredProcedure; //especificamos que la instancia es un procedure
                //pasamos los parametros con la informacion esrita por el usuario
                ActualizarUsuario.Parameters.Add("pNombre", OracleType.VarChar).Value = txtNombre.Text;
                ActualizarUsuario.Parameters.Add("pApellido_1", OracleType.VarChar).Value = txtPrimerApellido.Text;
                ActualizarUsuario.Parameters.Add("pApellido_2", OracleType.VarChar).Value = txtSegundoApellido.Text;
                ActualizarUsuario.Parameters.Add("pCedula", OracleType.VarChar).Value = txtCedula.Text;
                ActualizarUsuario.Parameters.Add("pRol", OracleType.VarChar).Value = ddmRol.SelectedItem.ToString();
                ActualizarUsuario.ExecuteNonQuery();
                OracleCommand ActualizarUsername = new OracleCommand("ActualizarUsername", database); //llamamos procedure
                ActualizarUsername.CommandType = System.Data.CommandType.StoredProcedure; //especificamos que la instancia es un procedure
                //pasamos los parametros con la informacion esrita por el usuario
                ActualizarUsername.Parameters.Add("pUsername", OracleType.VarChar).Value = txtUsario.Text;
                ActualizarUsername.Parameters.Add("pContrasenna", OracleType.VarChar).Value = txtContrasenna.Text;
                ActualizarUsername.Parameters.Add("pDuenoUsername", OracleType.VarChar).Value = txtCedula.Text;
                ActualizarUsername.Parameters.Add("pRol", OracleType.VarChar).Value = ddmRol.SelectedItem.ToString();
                ActualizarUsername.ExecuteNonQuery();
                OracleCommand ActualizarTelefono = new OracleCommand("ActualizarTelefono", database); //llamamos procedure
                ActualizarTelefono.CommandType = System.Data.CommandType.StoredProcedure; //especificamos que la instancia es un procedure
                //pasamos los parametros con la informacion esrita por el usuario
                ActualizarTelefono.Parameters.Add("pTelefono", OracleType.VarChar).Value = txtTelefono.Text;
                ActualizarTelefono.Parameters.Add("pDuenoTelefono", OracleType.VarChar).Value = txtCedula.Text;
                ActualizarTelefono.Parameters.Add("pCategoria", OracleType.VarChar).Value = "Usuario";
                ActualizarUsername.ExecuteNonQuery();
                OracleCommand ActualizarCorreo = new OracleCommand("ActualizarCorreo", database); //llamamos procedure
                ActualizarCorreo.CommandType = System.Data.CommandType.StoredProcedure; //especificamos que la instancia es un procedure
                //pasamos los parametros con la informacion esrita por el usuario
                ActualizarCorreo.Parameters.Add("pCorreo", OracleType.VarChar).Value = txtCorreo.Text;
                ActualizarCorreo.Parameters.Add("pDuenoCorreo", OracleType.VarChar).Value = txtCedula.Text;
                ActualizarCorreo.Parameters.Add("pCategoria", OracleType.VarChar).Value = "Usuario";
                ActualizarUsername.ExecuteNonQuery();
                MessageBox.Show("El usuario se actualizo"); //mandamos msj de exito
                //limpiamos campos
                txtUsario.Clear();
                txtContrasenna.Clear();
                txtNombre.Clear();
                txtPrimerApellido.Clear();
                txtSegundoApellido.Clear();
                txtCedula.Clear();
                ddmRol.ResetText();
                txtTelefono.Clear();
                txtCorreo.Clear();
                txtCedula.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Algo fallo, asegurese de que los datos a ingresar sean correctos"); //mandamos msj de fallo
                //limpiamos campos
                txtUsario.Clear();
                txtContrasenna.Clear();
                txtNombre.Clear();
                txtPrimerApellido.Clear();
                txtSegundoApellido.Clear();
                txtCedula.Clear();
                ddmRol.ResetText();
                txtTelefono.Clear();
                txtCorreo.Clear();
                txtCedula.Clear();
            }
            database.Close();
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
