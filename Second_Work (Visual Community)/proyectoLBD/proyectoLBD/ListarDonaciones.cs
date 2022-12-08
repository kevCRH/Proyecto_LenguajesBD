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
    public partial class ListarDonaciones : Form
    {
        public ListarDonaciones()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {   
            //Metodo de conexion a la base de datos
            OracleConnection database = new OracleConnection("DATA SOURCE = ORCL ; PASSWORD=1234; USER ID = PROYECTO;");
            try
            {
                database.Open();
                //llamamos al metodo ver_donaciones el cual nos devolvera un cursor como un parametro de salida
                OracleCommand donacion = new OracleCommand("ver_donaciones_monetaria", database);
                donacion.CommandType = System.Data.CommandType.StoredProcedure;
                donacion.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;
                //adaptamos el cursor para poder meterlo dentro de una tabla
                OracleDataAdapter adaptador = new OracleDataAdapter();
                adaptador.SelectCommand = donacion;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                //enviamos la tabla con los datos del cursor al dataGripView
                dataGridView1.DataSource = tabla;
            }
            catch(Exception) {
                MessageBox.Show("Algo fallo, intente de nuevo");
            }
            database.Close(); 
        }
        private void bt_atrás_Click(object sender, EventArgs e)
        {
            AgregarDonacion agregarDonacion = new AgregarDonacion();
            agregarDonacion.Show();
            this.Hide();
        }

        private void txt_navBar_Click(object sender, EventArgs e)
        {

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
