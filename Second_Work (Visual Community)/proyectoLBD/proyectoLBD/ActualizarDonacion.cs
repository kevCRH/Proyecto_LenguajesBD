using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
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

            database.Open();
            OracleCommand donacion = new OracleCommand("ver_donacion", database);
            donacion.CommandType = System.Data.CommandType.StoredProcedure;
            donacion.Parameters.AddWithValue("pNumeroRecibo", textBox6.Text);
            donacion.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = donacion;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;

            database.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OracleConnection database = new OracleConnection("DATA SOURCE = ORCL ; PASSWORD=1234; USER ID = PROYECTO;");
            database.Open();
            OracleCommand donacion = new OracleCommand("actualizar_donacion", database);
            donacion.CommandType = System.Data.CommandType.StoredProcedure;
            donacion.Parameters.Add("pNumeroRecibo", OracleType.VarChar).Value = textBox6.Text;
            donacion.Parameters.Add("npNUMERORECIBO", OracleType.VarChar).Value = textBox5.Text;
            donacion.Parameters.Add("npFECHA", OracleType.DateTime).Value = dateTimePicker1.Value;
            donacion.Parameters.Add("npPROCEDENCIA", OracleType.VarChar).Value = textBox1.Text;
            donacion.Parameters.Add("npCEDULAUSUARIO", OracleType.VarChar).Value = textBox2.Text;
            donacion.Parameters.Add("npCEDULAUSUARIOCAPTACION", OracleType.VarChar).Value = textBox3.Text;
            if (checkBox3.Checked == true)
            {
                donacion.Parameters.Add("npNOMBRESEDE", OracleType.VarChar).Value = "San Jose";
            }
            else if (checkBox7.Checked == true)
            {
                donacion.Parameters.Add("npNOMBRESEDE", OracleType.VarChar).Value = "Alajuela";
            }
            else if (checkBox8.Checked == true)
            {
                donacion.Parameters.Add("npNOMBRESEDE", OracleType.VarChar).Value = "Puntarenas";
            }
            else
            {
                MessageBox.Show("Seleccione la sede");
            }

            if (checkBox1.Checked == true)
            {
                donacion.Parameters.Add("npID_TDONACION", OracleType.Number).Value = 1;
            }
            else if (checkBox2.Checked == true)
            {
                donacion.Parameters.Add("npID_TDONACION", OracleType.Number).Value = 2;
            }
            else
            {
                MessageBox.Show("Seleccione el tipo de donacion");
            }

            donacion.Parameters.Add("npCANTIDAD", OracleType.VarChar).Value = textBox9.Text;
            donacion.Parameters.Add("npDESCRIPCION", OracleType.VarChar).Value = textBox4.Text;
            if (checkBox4.Checked == true)
            {
                donacion.Parameters.Add("npMETODOPAGO", OracleType.VarChar).Value = "N/A";
            }
            else if (checkBox5.Checked == true)
            {
                donacion.Parameters.Add("npMETODOPAGO", OracleType.VarChar).Value = "Efectivo";
            }
            else if (checkBox6.Checked == true)
            {
                donacion.Parameters.Add("npMETODOPAGO", OracleType.VarChar).Value = "Tarjeta";
            }
            else if (checkBox9.Checked == true)
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
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            database.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AgregarDonacion agregarDonacion = new AgregarDonacion();
            agregarDonacion.Show();
            this.Hide();
        }
    }
}
