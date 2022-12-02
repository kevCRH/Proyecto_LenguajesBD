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
    public partial class AgregarSede : Form
    {
        public AgregarSede()
        {
            InitializeComponent();
        }

        private void txt_navBar_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            OracleConnection database = new OracleConnection("DATA SOURCE = ORCL ; PASSWORD=1234; USER ID = PROYECTO;");
            try
            {
                database.Open();
                OracleCommand comandoAgregar = new OracleCommand("AGREGAR_SEDE", database);
                comandoAgregar.CommandType = System.Data.CommandType.StoredProcedure;
                comandoAgregar.Parameters.Add("pNombreSede", OracleType.VarChar).Value = txtNombreSede.Text;
                comandoAgregar.Parameters.Add("pCodPostal", OracleType.VarChar).Value = txtCodPostal.Text;
                comandoAgregar.Parameters.Add("pProvincia", OracleType.VarChar).Value = txtProvincia.Text;
                comandoAgregar.Parameters.Add("pCanton", OracleType.VarChar).Value = txtCanton.Text;
                comandoAgregar.Parameters.Add("pDistrito", OracleType.VarChar).Value = txtDistrito.Text;
                comandoAgregar.Parameters.Add("pDireccionExacta", OracleType.VarChar).Value = txtDireccionExacta.Text;
                comandoAgregar.ExecuteNonQuery();
                MessageBox.Show("Sede agregado con exito");
                txtNombreSede.Clear();
                txtCodPostal.Clear();
                txtProvincia.Clear();
                txtCanton.Clear();
                txtDistrito.Clear();
                txtDireccionExacta.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Algo fallo");
                txtNombreSede.Clear();
                txtCodPostal.Clear();
                txtProvincia.Clear();
                txtCanton.Clear();
                txtDistrito.Clear();
                txtDireccionExacta.Clear();
            }
            database.Close();
        }
    }
}
