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
                OracleCommand comandoAgregar = new OracleCommand("AGREGAR_SEDE", database); //llamamos procedure
                comandoAgregar.CommandType = System.Data.CommandType.StoredProcedure; //especificamos que la instancia es un procedure
                //pasamos los parametros con la informacion esrita por el usuario
                comandoAgregar.Parameters.Add("pNombreSede", OracleType.VarChar).Value = txtNombreSede.Text;
                comandoAgregar.Parameters.Add("pCodPostal", OracleType.VarChar).Value = txtCodPostal.Text;
                comandoAgregar.Parameters.Add("pProvincia", OracleType.VarChar).Value = txtProvincia.Text;
                comandoAgregar.Parameters.Add("pCanton", OracleType.VarChar).Value = txtCanton.Text;
                comandoAgregar.Parameters.Add("pDistrito", OracleType.VarChar).Value = txtDistrito.Text;
                comandoAgregar.Parameters.Add("pDireccionExacta", OracleType.VarChar).Value = txtDireccionExacta.Text;
                comandoAgregar.ExecuteNonQuery(); //ejecutamos
                MessageBox.Show("Sede agregado con exito"); //mandamos msj de exito
                //limpiamos campos
                txtNombreSede.Clear();
                txtCodPostal.Clear();
                txtProvincia.Clear();
                txtCanton.Clear();
                txtDistrito.Clear();
                txtDireccionExacta.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Algo fallo"); //mandamos msj de fallo
                //limpiamos campos
                txtNombreSede.Clear();
                txtCodPostal.Clear();
                txtProvincia.Clear();
                txtCanton.Clear();
                txtDistrito.Clear();
                txtDireccionExacta.Clear();
            }
            database.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MenuAdministrador formulario = new MenuAdministrador();
            formulario.Show();
            this.Hide();
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
            ListarSedes listarSedes = new ListarSedes();
            listarSedes.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActualizarSede actualizarSede = new ActualizarSede();   
            actualizarSede.Show();
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
    }
}
