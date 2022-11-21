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
                OracleCommand comandoAgregar = new OracleCommand("AGREGARUSUARIO", database);
                comandoAgregar.CommandType = System.Data.CommandType.StoredProcedure;
                comandoAgregar.Parameters.Add("pUsuario", OracleType.VarChar).Value = txtUsario.Text;
                comandoAgregar.Parameters.Add("pContrasenna", OracleType.VarChar).Value = txtContrasenna.Text;
                comandoAgregar.Parameters.Add("pNombre", OracleType.VarChar).Value = txtNombre.Text;
                comandoAgregar.Parameters.Add("pApellido_1", OracleType.VarChar).Value = txtPrimerApellido.Text;
                comandoAgregar.Parameters.Add("pApellido_2", OracleType.VarChar).Value = txtSegundoApellido.Text;
                comandoAgregar.Parameters.Add("pCedula", OracleType.VarChar).Value = txtCedula.Text;
                comandoAgregar.Parameters.Add("pRol", OracleType.VarChar).Value = ddmRol.SelectedItem.ToString();
                comandoAgregar.ExecuteNonQuery();
                OracleCommand comandoAgregarCorreo = new OracleCommand("AGREGARCORREOUSUARIO", database);
                comandoAgregarCorreo.CommandType = System.Data.CommandType.StoredProcedure;
                comandoAgregarCorreo.Parameters.Add("pCorreo", OracleType.VarChar).Value = txtCorreo.Text;
                comandoAgregarCorreo.Parameters.Add("pUsuarioCorreo", OracleType.VarChar).Value = txtCedula.Text;
                comandoAgregarCorreo.ExecuteNonQuery();
                OracleCommand comandoAgregarTelefono = new OracleCommand("AGREGARTELEFONOUSUARIO", database);
                comandoAgregarTelefono.CommandType = System.Data.CommandType.StoredProcedure;
                comandoAgregarTelefono.Parameters.Add("pTelefono", OracleType.VarChar).Value = txtTelefono.Text;
                comandoAgregarTelefono.Parameters.Add("pUsuarioTelefono", OracleType.VarChar).Value = txtCedula.Text;
                comandoAgregarTelefono.ExecuteNonQuery();
                MessageBox.Show("Usuario Agregado con exito");
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
                MessageBox.Show("Algo fallo");
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
    }
}
