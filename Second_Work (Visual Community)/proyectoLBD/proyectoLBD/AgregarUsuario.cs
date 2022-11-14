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
                comandoAgregar.Parameters.Add("usuario", OracleType.VarChar).Value = txtUsario.Text;
                comandoAgregar.Parameters.Add("contrasenna", OracleType.VarChar).Value = txtContrasenna.Text;
                comandoAgregar.Parameters.Add("nombre", OracleType.VarChar).Value = txtNombre.Text;
                comandoAgregar.Parameters.Add("apellido_1", OracleType.VarChar).Value = txtPrimerApellido.Text;
                comandoAgregar.Parameters.Add("apellido_2", OracleType.VarChar).Value = txtSegundoApellido.Text;
                comandoAgregar.Parameters.Add("cedula", OracleType.VarChar).Value = txtCedula.Text;
                comandoAgregar.Parameters.Add("activo", OracleType.Char).Value = ddmEstado.SelectedItem;
                comandoAgregar.Parameters.Add("rol", OracleType.Number).Value = ddmRol.SelectedItem;
                comandoAgregar.Parameters.Add("correo", OracleType.VarChar).Value = txtCorreo.Text;
                comandoAgregar.Parameters.Add("telefono", OracleType.VarChar).Value = txtTelefono.Text;
                comandoAgregar.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Algo fallo");
            }
            database.Close();
        }
        
    }
}
