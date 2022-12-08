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

namespace proyectoLBD
{
    public partial class AgregarUsuario : Form
    {
        public AgregarUsuario()
        {
            InitializeComponent();
        }

        private void ddmRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            OracleConnection database = new OracleConnection("DATA SOURCE = ORCL ; PASSWORD=1234; USER ID = PROYECTO;");
            try
            {
                database.Open();
                OracleCommand comandoAgregarUusuario = new OracleCommand("AGREGAR_USUARIO", database); //llamamos procedure
                comandoAgregarUusuario.CommandType = System.Data.CommandType.StoredProcedure; //especificamos que la instancia es un procedure
                //pasamos los parametros con la informacion esrita por el usuario
                comandoAgregarUusuario.Parameters.Add("pNombre", OracleType.VarChar).Value = txtNombre.Text;
                comandoAgregarUusuario.Parameters.Add("pApellido_1", OracleType.VarChar).Value = txtPrimerApellido.Text;
                comandoAgregarUusuario.Parameters.Add("pApellido_2", OracleType.VarChar).Value = txtSegundoApellido.Text;
                comandoAgregarUusuario.Parameters.Add("pCedula", OracleType.VarChar).Value = txtCedula.Text;
                comandoAgregarUusuario.Parameters.Add("pRol", OracleType.VarChar).Value = ddmRol.SelectedItem.ToString();
                comandoAgregarUusuario.ExecuteNonQuery();
                OracleCommand comandoAgregarUsername = new OracleCommand("AGREGAR_USERNAME", database); //llamamos procedure
                comandoAgregarUsername.CommandType = System.Data.CommandType.StoredProcedure; //especificamos que la instancia es un procedure
                //pasamos los parametros con la informacion esrita por el usuario
                comandoAgregarUsername.Parameters.Add("pUsername", OracleType.VarChar).Value = txtUsario.Text;
                comandoAgregarUsername.Parameters.Add("pContrasenna", OracleType.VarChar).Value = txtContrasenna.Text;
                comandoAgregarUsername.Parameters.Add("pDuenoUsername", OracleType.VarChar).Value = txtCedula.Text;
                comandoAgregarUsername.Parameters.Add("pRolUsername", OracleType.VarChar).Value = ddmRol.SelectedItem.ToString();
                comandoAgregarUsername.ExecuteNonQuery();
                OracleCommand comandoAgregarCorreo = new OracleCommand("Agregar_Correo", database); //llamamos procedure
                comandoAgregarCorreo.CommandType = System.Data.CommandType.StoredProcedure; //especificamos que la instancia es un procedure
                //pasamos los parametros con la informacion esrita por el usuario
                comandoAgregarCorreo.Parameters.Add("pCorreo", OracleType.VarChar).Value = txtCorreo.Text;
                comandoAgregarCorreo.Parameters.Add("pDuenoCorreo", OracleType.VarChar).Value = txtCedula.Text;
                comandoAgregarCorreo.Parameters.Add("pCategoriaCorreo", OracleType.VarChar).Value = "Usuario";
                comandoAgregarCorreo.ExecuteNonQuery();
                OracleCommand comandoAgregarTelefono = new OracleCommand("Agregar_Telefono", database); //llamamos procedure
                comandoAgregarTelefono.CommandType = System.Data.CommandType.StoredProcedure; //especificamos que la instancia es un procedure
                //pasamos los parametros con la informacion esrita por el usuario
                comandoAgregarTelefono.Parameters.Add("pTelefono", OracleType.VarChar).Value = txtTelefono.Text;
                comandoAgregarTelefono.Parameters.Add("pDuenoTelefono", OracleType.VarChar).Value = txtCedula.Text;
                comandoAgregarTelefono.Parameters.Add("pCategoriaTelefono", OracleType.VarChar).Value = "Usuario";
                comandoAgregarTelefono.ExecuteNonQuery(); //ejecutamos 
                MessageBox.Show("Usuario Agregado con exito"); //mandamos msj de exito
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
                MessageBox.Show("Algo fallo"); //mandamos msj de fallo
                //limpiamos campos
                txtUsario.Clear();
                txtContrasenna.Clear();
                txtNombre.Clear();
                txtPrimerApellido.Clear();
                txtSegundoApellido.Clear();
                txtCedula.Clear();
                ddmRol.ResetText();
                txtCorreo.Clear();
                txtTelefono.Clear();
                txtCedula.Clear();
            }
            database.Close();
        }

        private void panel_fondoCeleste_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_atrás_Click(object sender, EventArgs e)
        {
            MenuAdministrador formulario = new MenuAdministrador();
            formulario.Show();
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

        private void button3_Click(object sender, EventArgs e)
        {
            ListarUsuarios listarUsuarios = new ListarUsuarios();
            listarUsuarios.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListarUsernames listarUsernames = new ListarUsernames();    
            listarUsernames.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActualizarUsuario actualizarUsuario = new ActualizarUsuario();
            actualizarUsuario.Show();
            this.Hide();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            //Evento click del botón minimizar
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Minimized;
            else if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Minimized;
        }

        private void ddmRol_DrawItem(object sender, DrawItemEventArgs e)
        {

        }
    }
}
