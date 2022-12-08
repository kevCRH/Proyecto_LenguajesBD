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
            try
            {
                database.Open();//se abre la conexion de db
                OracleCommand comando = new OracleCommand("Ver_Usuarios", database); //llamamos procedure
                comando.CommandType = System.Data.CommandType.StoredProcedure;//especificamos que la instancia es un procedure
                comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output; //parametro que recibira, que tipo es y definimos una direccion
                OracleDataAdapter adaptador = new OracleDataAdapter();
                adaptador.SelectCommand = comando;//Comando que tiene el procedimiento almacenado
                DataTable tabla = new DataTable();//Creamos un data table
                adaptador.Fill(tabla);//Aca se llena la tabla con los datos
                dgvUsuarios.DataSource = tabla;//y le decimos que se reflejen los datos a nivel de diseno en la tabla
            }
            catch (Exception) {
                MessageBox.Show("Algo fallo, intente de nuevo");
            }
            database.Close();//Cerramos conexion de db       
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // hacer un if
            // Aqui se hace la logica donde tenemos que abrir el form y enviar los datos de la celda por parametro de la fila seleccionada
            // string nombre = dataTable.Rows[0]["Nombre"].ToString();
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

        private void bt_atrás_Click(object sender, EventArgs e)
        {
            AgregarUsuario AgregarUsario = new AgregarUsuario();
            AgregarUsario.Show();
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
