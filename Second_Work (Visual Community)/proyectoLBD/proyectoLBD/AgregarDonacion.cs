﻿using System;
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
    public partial class AgregarDonacion : Form
    {
        public AgregarDonacion()
        {
            InitializeComponent();
        }

     
        private void Button1_Click(object sender, EventArgs e)
        {
            int total = 0;
            int total2 = 0;
            string total3 = "";
            OracleConnection database = new OracleConnection("DATA SOURCE = ORCL ; PASSWORD=1234; USER ID = PROYECTO;");

            database.Open();
            OracleCommand comando = new OracleCommand("INSERTAR_DONACION", database);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("pFecha", OracleType.DateTime).Value = dateTimePicker1.Value;
            comando.Parameters.Add("pProcedencia", OracleType.VarChar).Value = textBox1.Text;

            if (checkBox1.Checked == true)
            {
                total = 2;
            }
            else if (checkBox2.Checked == true)
            {
                total = 1;
            }
            else
            {
                MessageBox.Show("Seleccione la sede");
            }
            comando.Parameters.Add("pTipoDonacion", OracleType.Number).Value = total;
            comando.Parameters.Add("pUsuario", OracleType.Number).Value = numericUpDown1.Value;
            if (checkBox3.Checked == true)
            {
                total2 = 1;
            }
            else if (checkBox3.Checked == false)
            {
                MessageBox.Show("Seleccione la sede");
            }
            comando.Parameters.Add("pSede", OracleType.Number).Value = total2;
            comando.Parameters.Add("pCantidad", OracleType.Number).Value = numericUpDown2.Value;
            comando.Parameters.Add("pDescripcion", OracleType.VarChar).Value = textBox3.Text;
            if (checkBox4.Checked == true)
            {
                total3 = "N/A";
            }
            else if (checkBox5.Checked == true)
            {
                total3 = "Tarjeta";
            }
            else if (checkBox6.Checked == true)
            {
                total3 = "Efectivo";
            }
            else
            {
                MessageBox.Show("Seleccione el metodo de pago");
            }
            comando.Parameters.Add("pMetodoPago", OracleType.VarChar).Value = total3;
            comando.ExecuteNonQuery();
            MessageBox.Show("La donacion se agrego");

            database.Close();
        }

        private void AgregarDonacion_Load(object sender, EventArgs e)
        {

        }
    }

    
}