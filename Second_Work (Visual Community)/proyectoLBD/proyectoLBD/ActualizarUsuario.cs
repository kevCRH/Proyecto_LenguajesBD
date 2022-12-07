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
                //llamamos al metodo ver_donacion enviandole como parametro el numero del recibo de la donacion
                //que queremos buscar para actualizar, el cual nos devolvera un cursor como un parametro de salida con los datos que necesitamos
                OracleCommand donacion = new OracleCommand("BuscarUsuario", database);
                donacion.CommandType = System.Data.CommandType.StoredProcedure;
                donacion.Parameters.AddWithValue("pCedula", txtCedula.Text);
                donacion.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;
                //adaptamos el cursor para poder meterlo dentro de una tabla
                OracleDataAdapter adaptador = new OracleDataAdapter();
                adaptador.SelectCommand = donacion;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                //enviamos la tabla con los datos del cursor al dataGripView
                dgvUsuario.DataSource = tabla;
            }
            catch
            {
                MessageBox.Show("Donacion no encontrada, algo fallo");
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
            frm_login formulario = new frm_login();
            formulario.Show();
            this.Hide();
        }

        private void txtActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                database.Open();
                //Abri la conexion a la base de datos y llamamos al metodo actualizar_donacion al cual 
                //le enviaremos por parametro cada uno de los valores nuevos a la donacion que buscamos anteriormente
                OracleCommand ActualizarUsuario = new OracleCommand("ActualizarUsuario", database);
                ActualizarUsuario.CommandType = System.Data.CommandType.StoredProcedure;
                ActualizarUsuario.Parameters.Add("pNombre", OracleType.VarChar).Value = txtNombre.Text;
                ActualizarUsuario.Parameters.Add("pApellido_1", OracleType.VarChar).Value = txtPrimerApellido.Text;
                ActualizarUsuario.Parameters.Add("pApellido_2", OracleType.VarChar).Value = txtSegundoApellido.Text;
                ActualizarUsuario.Parameters.Add("pCedula", OracleType.VarChar).Value = txtCedula.Text;
                ActualizarUsuario.Parameters.Add("pRol", OracleType.VarChar).Value = ddmRol.SelectedItem.ToString();
                ActualizarUsuario.ExecuteNonQuery();
                OracleCommand ActualizarUsername = new OracleCommand("ActualizarUsername", database);
                ActualizarUsername.CommandType = System.Data.CommandType.StoredProcedure;
                ActualizarUsername.Parameters.Add("pUsername", OracleType.VarChar).Value = txtUsario.Text;
                ActualizarUsername.Parameters.Add("pContrasenna", OracleType.VarChar).Value = txtContrasenna.Text;
                ActualizarUsername.Parameters.Add("pDuenoUsername", OracleType.VarChar).Value = txtCedula.Text;
                ActualizarUsername.Parameters.Add("pRol", OracleType.VarChar).Value = ddmRol.SelectedItem.ToString();
                ActualizarUsername.ExecuteNonQuery();
                OracleCommand ActualizarTelefono = new OracleCommand("ActualizarTelefono", database);
                ActualizarTelefono.CommandType = System.Data.CommandType.StoredProcedure;
                ActualizarTelefono.Parameters.Add("pTelefono", OracleType.VarChar).Value = txtTelefono.Text;
                ActualizarTelefono.Parameters.Add("pDuenoTelefono", OracleType.VarChar).Value = txtCedula.Text;
                ActualizarTelefono.Parameters.Add("pCategoria", OracleType.VarChar).Value = "Usuario";
                ActualizarUsername.ExecuteNonQuery();
                OracleCommand ActualizarCorreo = new OracleCommand("ActualizarCorreo", database);
                ActualizarCorreo.CommandType = System.Data.CommandType.StoredProcedure;
                ActualizarCorreo.Parameters.Add("pCorreo", OracleType.VarChar).Value = txtCorreo.Text;
                ActualizarCorreo.Parameters.Add("pDuenoCorreo", OracleType.VarChar).Value = txtCedula.Text;
                ActualizarCorreo.Parameters.Add("pCategoria", OracleType.VarChar).Value = "Usuario";
                ActualizarUsername.ExecuteNonQuery();
                MessageBox.Show("El usuario se actualizo");
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
                MessageBox.Show("Algo fallo, asegurese de que los datos a ingresar sean correctos");

            }
            database.Close();
        }
    }
}
