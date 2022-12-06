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
    public partial class ActualizarSede : Form
    {
        OracleConnection database = new OracleConnection("DATA SOURCE = ORCL ; PASSWORD=1234; USER ID = PROYECTO;");
        public ActualizarSede()
        {
            InitializeComponent();
        }

        private void bt_atrás_Click(object sender, EventArgs e)
        {
            AgregarSede agregarSede = new AgregarSede();
            agregarSede.Show();
            this.Hide();
        }

        private void bt_logout_Click(object sender, EventArgs e)
        {
            frm_login formulario = new frm_login();
            formulario.Show();
            this.Hide();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                database.Open();
                //llamamos al metodo ver_donacion enviandole como parametro el numero del recibo de la donacion
                //que queremos buscar para actualizar, el cual nos devolvera un cursor como un parametro de salida con los datos que necesitamos
                OracleCommand donacion = new OracleCommand("VER_SEDE_ESPECIFICA", database);
                donacion.CommandType = System.Data.CommandType.StoredProcedure;
                donacion.Parameters.AddWithValue("pNombreSede", txtSede.Text);
                donacion.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;
                //adaptamos el cursor para poder meterlo dentro de una tabla
                OracleDataAdapter adaptador = new OracleDataAdapter();
                adaptador.SelectCommand = donacion;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                //enviamos la tabla con los datos del cursor al dataGripView
                dgvSede.DataSource = tabla;
            }
            catch
            {
                MessageBox.Show("Sede no encontrada, algo fallo");
            }
            database.Close();
        }

        private void txtActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                database.Open();
                OracleCommand comandoAgregar = new OracleCommand("ACTUALIZARSEDE", database);
                comandoAgregar.CommandType = System.Data.CommandType.StoredProcedure;
                comandoAgregar.Parameters.Add("pNombreSede", OracleType.VarChar).Value = txtSede.Text;
                comandoAgregar.Parameters.Add("pCodPostal", OracleType.VarChar).Value = txtCodPostal.Text;
                comandoAgregar.Parameters.Add("pCanton", OracleType.VarChar).Value = txtCanton.Text;
                comandoAgregar.Parameters.Add("pDistrito", OracleType.VarChar).Value = txtDistrito.Text;
                comandoAgregar.Parameters.Add("pDireccionExacta", OracleType.VarChar).Value = txtDireccionExacta.Text;
                comandoAgregar.ExecuteNonQuery();
                MessageBox.Show("Sede actualizada con exito");
                txtSede.Clear();
                txtCodPostal.Clear();
                txtCanton.Clear();
                txtDistrito.Clear();
                txtDireccionExacta.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Algo fallo");
                txtSede.Clear();
                txtCodPostal.Clear();
                txtCanton.Clear();
                txtDistrito.Clear();
                txtDireccionExacta.Clear();
            }
            database.Close();
        }
    }
}
