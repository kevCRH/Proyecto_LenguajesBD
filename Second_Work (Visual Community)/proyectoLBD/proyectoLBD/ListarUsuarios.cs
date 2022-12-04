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
    public partial class ListarUsuarios : Form
    {
        OracleConnection database = new OracleConnection("DATA SOURCE = ORCL ; PASSWORD=1234; USER ID = PROYECTO;");
        public ListarUsuarios()
        {
            InitializeComponent();
        }

        private void panel_fondoCeleste_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ListarUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnCargarUsuarios_Click(object sender, EventArgs e)
        {
            database.Open();//se abre la conexion de db
            OracleCommand comando = new OracleCommand("Ver_Usuarios",database); //Instanciamos
            comando.CommandType = System.Data.CommandType.StoredProcedure;//Definimos comando, que tipo de comando es
            comando.Parameters.Add("registros",OracleType.Cursor).Direction=ParameterDirection.Output; //parametro que recibira, que tipo es y definimos una direccion
          
            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;//Comando que tiene el procedimiento almacenado
            DataTable tabla = new DataTable();//Creamos un data table
            adaptador.Fill(tabla);//Aca se llena la tabla con los datos
            dgvUsuarios.DataSource = tabla;//y le decimos que se reflejen los datos a nivel de diseno en la tabla

            database.Close();//Cerramos conexion de db
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // hacer un if
            // Aqui se hace la logica donde tenemos que abrir el form y enviar los datos de la celda por parametro de la fila seleccionada
            // string nombre = dataTable.Rows[0]["Nombre"].ToString();
        }
    }
}
