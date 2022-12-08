using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proyectoLBD
{
    public partial class ActualizarDonacion : Form
    {
        public ActualizarDonacion()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleConnection database = new OracleConnection("DATA SOURCE = ORCL ; PASSWORD=1234; USER ID = PROYECTO;");
            try
            {
                database.Open();
                //llamamos al metodo ver_donacion enviandole como parametro el numero del recibo de la donacion
                //que queremos buscar para actualizar, el cual nos devolvera un cursor como un parametro de salida con los datos que necesitamos
                OracleCommand donacion = new OracleCommand("ver_donacion", database);
                donacion.CommandType = System.Data.CommandType.StoredProcedure;
                donacion.Parameters.AddWithValue("pNumeroRecibo", textBox6.Text);
                donacion.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;
                //adaptamos el cursor para poder meterlo dentro de una tabla
                OracleDataAdapter adaptador = new OracleDataAdapter();
                adaptador.SelectCommand = donacion;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                //enviamos la tabla con los datos del cursor al dataGripView
                dataGridView1.DataSource = tabla;
            }
            catch {
                MessageBox.Show("Donacion no encontrada, algo fallo");
            }
            database.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OracleConnection database = new OracleConnection("DATA SOURCE = ORCL ; PASSWORD=1234; USER ID = PROYECTO;");
            try
            {
                database.Open();
                //Abri la conexion a la base de datos y llamamos al metodo actualizar_donacion al cual 
                //le enviaremos por parametro cada uno de los valores nuevos a la donacion que buscamos anteriormente
                OracleCommand donacion = new OracleCommand("actualizar_donacion", database);
                donacion.CommandType = System.Data.CommandType.StoredProcedure;
                donacion.Parameters.Add("pNumeroRecibo", OracleType.VarChar).Value = textBox6.Text;
                donacion.Parameters.Add("npNUMERORECIBO", OracleType.VarChar).Value = textBox5.Text;
                donacion.Parameters.Add("npFECHA", OracleType.DateTime).Value = dateTimePicker1.Value;
                donacion.Parameters.Add("npPROCEDENCIA", OracleType.VarChar).Value = textBox1.Text;
                //los chechBox se encargaràn de validar la opcion de que provincia se seleccion,
                //Si no se seleccion una sede mostrara una alerta
                if (checkBox3.Checked)
                {
                    donacion.Parameters.Add("npNOMBRESEDE", OracleType.VarChar).Value = "San Jose";
                }
                else if (checkBox7.Checked)
                {
                    donacion.Parameters.Add("npNOMBRESEDE", OracleType.VarChar).Value = "Alajuela";
                }
                else if (checkBox8.Checked)
                {
                    donacion.Parameters.Add("npNOMBRESEDE", OracleType.VarChar).Value = "Puntarenas";
                }
                else
                {
                    MessageBox.Show("Seleccione una sede");
                }
                // Se capturan los datos del tipo de donacion monetaria
                donacion.Parameters.Add("npID_TDONACION", OracleType.Number).Value = 1;
                donacion.Parameters.Add("npCANTIDAD", OracleType.VarChar).Value = "0";
                donacion.Parameters.Add("npDESCRIPCION", OracleType.VarChar).Value = "N/A";
                //Se validan los checkBox para ver el metodo de pago
                if (checkBox4.Checked)
                {
                    donacion.Parameters.Add("npMETODOPAGO", OracleType.VarChar).Value = "N/A";
                }
                else if (checkBox5.Checked)
                {
                    donacion.Parameters.Add("npMETODOPAGO", OracleType.VarChar).Value = "Efectivo";
                }
                else if (checkBox6.Checked)
                {
                    donacion.Parameters.Add("npMETODOPAGO", OracleType.VarChar).Value = "Tarjeta";
                }
                else if (checkBox9.Checked)
                {
                    donacion.Parameters.Add("npMETODOPAGO", OracleType.VarChar).Value = "Cheque";
                }
                else
                {
                    MessageBox.Show("Seleccione el metodo de pago");
                }
                donacion.Parameters.Add("npMONTO", OracleType.VarChar).Value = textBox10.Text;
                donacion.ExecuteNonQuery();
                MessageBox.Show("La donacion se actualizo");
                textBox1.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox10.Clear();
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
                checkBox7.Checked = false;
                checkBox8.Checked = false;
                checkBox9.Checked = false;
            }
            catch (Exception) {
                MessageBox.Show("Algo fallo, asegurese de que los datos a ingresar sean correctos");

            }
            database.Close();
        }

        private void bt_atrás_Click(object sender, EventArgs e)
        {
            AgregarDonacionEspecie agregarDonacion = new AgregarDonacionEspecie();
            agregarDonacion.Show();
            this.Hide();
        }

        private void bt_logout_Click(object sender, EventArgs e)
        {
            frm_login formulario = new frm_login();
            formulario.Show();
            this.Hide();
        }
    }
}
