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
    public partial class ActualizarUsuario : Form
    {
        public ActualizarUsuario()
        {
            InitializeComponent();
        }

        private void Cargar_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ActualizarUsuario_Load(object sender, EventArgs e)
        {
            OracleConnection database = new OracleConnection("DATA SOURCE = ORCL ; PASSWORD=1234; USER ID = PROYECTO;");
            database.Open();//se abre la conexion de db
            OracleCommand comando = new OracleCommand("Buscar_Usuario", database); //Instanciamos
            comando.CommandType = System.Data.CommandType.StoredProcedure;//Definimos comando, que tipo de comando es
            comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output; //parametro que recibira, que tipo es y definimos una direccion
            comando.Parameters.AddWithValue("pCedula","305380675");
            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;//Comando que tiene el procedimiento almacenado
            DataTable tabla = new DataTable();//Creamos un data table
            adaptador.Fill(tabla);//Aca se llena la tabla con los datos
            //y le decimos que se reflejen los datos a nivel de diseno en la tabla
            string nombre = tabla.Rows[0]["ATDescripcion"].ToString();
            textBox1.Text = nombre;
            database.Close();//Cerramos conexion de db
            
        }
    }
}
