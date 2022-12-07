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
    public partial class ListarUsernames : Form
    {
        OracleConnection database = new OracleConnection("DATA SOURCE = ORCL ; PASSWORD=1234; USER ID = PROYECTO;");
        public ListarUsernames()
        {
            InitializeComponent();
        }

        private void bt_atrás_Click(object sender, EventArgs e)
        {
            AgregarUsuario AgregarUsario = new AgregarUsuario();
            AgregarUsario.Show();
            this.Hide();
        }

        private void bt_logout_Click(object sender, EventArgs e)
        {
            frm_login formulario = new frm_login();
            formulario.Show();
            this.Hide();
        }

        private void btnCargarUsuarios_Click(object sender, EventArgs e)
        {
            database.Open();//se abre la conexion de db
            OracleCommand comando = new OracleCommand("Ver_Username", database); //Instanciamos
            comando.CommandType = System.Data.CommandType.StoredProcedure;//Definimos comando, que tipo de comando es
            comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output; //parametro que recibira, que tipo es y definimos una direccion

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;//Comando que tiene el procedimiento almacenado
            DataTable tabla = new DataTable();//Creamos un data table
            adaptador.Fill(tabla);//Aca se llena la tabla con los datos
            dgvUsernames.DataSource = tabla;//y le decimos que se reflejen los datos a nivel de diseno en la tabla

            database.Close();//Cerramos conexion de db
        }
    }
}
