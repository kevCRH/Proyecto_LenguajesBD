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
    public partial class ListarDonacionesEspecie : Form
    {
        public ListarDonacionesEspecie()
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
                OracleCommand donacion = new OracleCommand("ver_donaciones_especie", database);
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
            AgregarDonacionEspecie agregarDonacion = new AgregarDonacionEspecie();
            agregarDonacion.Show();
            this.Hide();
        }

        private void txt_navBar_Click(object sender, EventArgs e)
        {

        }

        private void bt_logout_Click(object sender, EventArgs e)
        {
            frm_login formulario = new frm_login();
            formulario.Show();
            this.Hide();
        }
    }
}
