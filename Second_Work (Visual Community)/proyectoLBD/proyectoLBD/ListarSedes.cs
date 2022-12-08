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
    public partial class ListarSedes : Form
    {
        OracleConnection database = new OracleConnection("DATA SOURCE = ORCL ; PASSWORD=1234; USER ID = PROYECTO;");
        public ListarSedes()
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

        private void btnCargarUsuarios_Click(object sender, EventArgs e)
        {
            try
            {
                database.Open();//se abre la conexion de db
                OracleCommand comando = new OracleCommand("Ver_Sedes", database); //Instanciamos
                comando.CommandType = System.Data.CommandType.StoredProcedure;//Definimos comando, que tipo de comando es
                comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output; //parametro que recibira, que tipo es y definimos una direccion

                OracleDataAdapter adaptador = new OracleDataAdapter();
                adaptador.SelectCommand = comando;//Comando que tiene el procedimiento almacenado
                DataTable tabla = new DataTable();//Creamos un data table
                adaptador.Fill(tabla);//Aca se llena la tabla con los datos
                dgvSedes.DataSource = tabla;//y le decimos que se reflejen los datos a nivel de diseno en la tabla
            }
            catch (Exception ex) {
                MessageBox.Show("Algo fallo, intente de nuevo");
            }
            database.Close();//Cerramos conexion de db
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
