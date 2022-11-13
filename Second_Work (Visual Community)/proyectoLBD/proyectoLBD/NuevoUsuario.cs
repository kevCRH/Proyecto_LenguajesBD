using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoLBD
{
    public partial class NuevoUsuario : Form
    {
        public NuevoUsuario()
        {
            InitializeComponent();
        }

        private void panel_fondoRojo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_navBar_Click(object sender, EventArgs e)
        {

        }

        private void panel_fondoRojo_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void NuevoUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.TBROL' Puede moverla o quitarla según sea necesario.
            this.tBROLTableAdapter.Fill(this.dataSet1.TBROL);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
