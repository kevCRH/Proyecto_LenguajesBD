using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoLBD.Resources
{
    public partial class BuscarDonacion : Form
    {
        public BuscarDonacion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            OracleConnection database = new OracleConnection("DATA SOURCE = ORCL ; PASSWORD=1234; USER ID = PROYECTO;");

            database.Open();
            OracleCommand donacion = new OracleCommand("Buscar_donacion", database);
            donacion.CommandType = System.Data.CommandType.StoredProcedure;
            donacion.Parameters.Add("pNumeroRecibo",OracleType.Number).Value = numericUpDown1.Value;
            
            donacion.Parameters.Add("pVERIFICAR", OracleType.Number).Direction = ParameterDirection.Output;

            donacion.ExecuteNonQuery();
            if (donacion.Parameters["pVERIFICAR"].Value.ToString().Equals("1"))
            {

                ActualizarDonacion actualizarDonacion = new ActualizarDonacion();   
                database.Close();
                actualizarDonacion.Show();
                this.Hide(); 

            }
            else
            {
                MessageBox.Show("Numero de recibo incorrecto"); //Esta vista se puede mejorar (Diseño)
                database.Close();
            }

        }
    }
}
