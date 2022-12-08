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
            OracleConnection database = new OracleConnection("DATA SOURCE = ORCL ; PASSWORD=1234; USER ID = PROYECTO;");
            try
            {
                database.Open();
                OracleCommand donacion = new OracleCommand("VER_SEDE_ESPECIFICA", database); //llamamos procedure
                donacion.CommandType = System.Data.CommandType.StoredProcedure; //especificamos que la instancia es un procedure
                donacion.Parameters.AddWithValue("pNombreSede", txtSede.Text); //parametro que recibira 
                donacion.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output; //definimos una direccion
                OracleDataAdapter adaptador = new OracleDataAdapter(); 
                adaptador.SelectCommand = donacion;//Comando que tiene el procedimiento almacenado
                DataTable tabla = new DataTable();//Creamos un data table
                adaptador.Fill(tabla);//Aca se llena la tabla con los datos
                dgvSede.DataSource = tabla;//y le decimos que se reflejen los datos a nivel de diseno en la tabla
            }
            catch
            {
                MessageBox.Show("Sede no encontrada, algo fallo");
            }
            database.Close();
        }

        private void txtActualizar_Click(object sender, EventArgs e)
        {
            OracleConnection database = new OracleConnection("DATA SOURCE = ORCL ; PASSWORD=1234; USER ID = PROYECTO;");
            try
            {
                database.Open();
                OracleCommand comandoAgregar = new OracleCommand("ACTUALIZARSEDE", database); //llamamos procedure
                comandoAgregar.CommandType = System.Data.CommandType.StoredProcedure; //especificamos que la instancia es un procedure
                //pasamos los parametros con la informacion esrita por el usuario
                comandoAgregar.Parameters.Add("pNombreSede", OracleType.VarChar).Value = txtSede.Text;
                comandoAgregar.Parameters.Add("pCodPostal", OracleType.VarChar).Value = txtCodPostal.Text;
                comandoAgregar.Parameters.Add("pCanton", OracleType.VarChar).Value = txtCanton.Text;
                comandoAgregar.Parameters.Add("pDistrito", OracleType.VarChar).Value = txtDistrito.Text;
                comandoAgregar.Parameters.Add("pDireccionExacta", OracleType.VarChar).Value = txtDireccionExacta.Text;
                comandoAgregar.ExecuteNonQuery(); //ejecutamos 
                MessageBox.Show("Sede actualizada con exito"); //mandamos msj de exito
                //limpiamos campos
                txtSede.Clear();
                txtCodPostal.Clear();
                txtCanton.Clear();
                txtDistrito.Clear();
                txtDireccionExacta.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Algo fallo");//mandamos msj de fallo
                //limpiamos campos
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
