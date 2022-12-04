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
            OracleConnection database = new OracleConnection("DATA SOURCE = ORCL ; PASSWORD=1234; USER ID = PROYECTO;");

            database.Open();

            OracleCommand donacion = new OracleCommand("ver_donaciones", database);
            donacion.CommandType = System.Data.CommandType.StoredProcedure;
            donacion.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = donacion;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;

            database.Close(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarDonacion agregarDonacion = new AgregarDonacion();
            agregarDonacion.Show();
            this.Hide();
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
            frm_login formulario = new frm_login();
            formulario.Show();
            this.Hide();
        }
    }
}
