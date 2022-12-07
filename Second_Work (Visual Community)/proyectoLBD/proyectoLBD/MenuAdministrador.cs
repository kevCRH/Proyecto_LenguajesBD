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
    public partial class MenuAdministrador : Form
    {
        public MenuAdministrador()
        {
            InitializeComponent();
        }

        private void bt_donaciones_Click(object sender, EventArgs e)
        {

            TipoDonacionAdmin formulario = new TipoDonacionAdmin();
            formulario.Show();
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

        private void bt_usuarios_Click(object sender, EventArgs e)
        {
            AgregarUsuario AgregarUsario = new AgregarUsuario();
            AgregarUsario.Show();
            this.Hide();
        }

        private void bt_sedes_Click(object sender, EventArgs e)
        {
            AgregarSede agregarSede = new AgregarSede();
            agregarSede.Show();
            this.Hide();
        }

        private void panel_fondoRojo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
