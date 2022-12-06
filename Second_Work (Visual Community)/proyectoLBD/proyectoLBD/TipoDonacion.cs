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
    public partial class TipoDonacion : Form
    {
        public TipoDonacion()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {

        }

        private void bt_donacion_especies_Click(object sender, EventArgs e)
        {
            AgregarDonacionEspecie donacion = new AgregarDonacionEspecie();
            donacion.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_login formulario = new frm_login();
            formulario.Show();
            this.Hide();
        }

        private void bt_logout_Click(object sender, EventArgs e)
        {
            frm_login formulario = new frm_login();
            formulario.Show();
            this.Hide();
        }

        private void bt_donacion_dinero_Click(object sender, EventArgs e)
        {
            AgregarDonacion donacion = new AgregarDonacion();
            donacion.Show();
            this.Hide();
        }
    }
}
