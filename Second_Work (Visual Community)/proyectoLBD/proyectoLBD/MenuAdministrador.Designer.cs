namespace proyectoLBD
{
    partial class MenuAdministrador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAdministrador));
            this.panel_fondoRojo = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.Button();
            this.bt_logout = new System.Windows.Forms.Button();
            this.txt_navBar = new System.Windows.Forms.Label();
            this.image_logo = new System.Windows.Forms.PictureBox();
            this.panel_fondoCeleste = new System.Windows.Forms.Panel();
            this.bt_donaciones = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_usuarios = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_sedes = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel_fondoRojo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_logo)).BeginInit();
            this.panel_fondoCeleste.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_fondoRojo
            // 
            this.panel_fondoRojo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel_fondoRojo.Controls.Add(this.btnMin);
            this.panel_fondoRojo.Controls.Add(this.bt_logout);
            this.panel_fondoRojo.Controls.Add(this.txt_navBar);
            this.panel_fondoRojo.Location = new System.Drawing.Point(0, -1);
            this.panel_fondoRojo.Name = "panel_fondoRojo";
            this.panel_fondoRojo.Size = new System.Drawing.Size(802, 73);
            this.panel_fondoRojo.TabIndex = 4;
            this.panel_fondoRojo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_fondoRojo_Paint);
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.DarkRed;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnMin.Image = global::proyectoLBD.Properties.Resources.minimizar;
            this.btnMin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnMin.Location = new System.Drawing.Point(667, 16);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(55, 42);
            this.btnMin.TabIndex = 79;
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // bt_logout
            // 
            this.bt_logout.BackColor = System.Drawing.Color.DarkRed;
            this.bt_logout.FlatAppearance.BorderSize = 0;
            this.bt_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_logout.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_logout.Image = global::proyectoLBD.Properties.Resources.logout;
            this.bt_logout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bt_logout.Location = new System.Drawing.Point(733, 16);
            this.bt_logout.Name = "bt_logout";
            this.bt_logout.Size = new System.Drawing.Size(55, 42);
            this.bt_logout.TabIndex = 12;
            this.bt_logout.UseVisualStyleBackColor = false;
            this.bt_logout.Click += new System.EventHandler(this.bt_logout_Click);
            // 
            // txt_navBar
            // 
            this.txt_navBar.AutoSize = true;
            this.txt_navBar.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold);
            this.txt_navBar.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_navBar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_navBar.Location = new System.Drawing.Point(17, 16);
            this.txt_navBar.Name = "txt_navBar";
            this.txt_navBar.Size = new System.Drawing.Size(544, 40);
            this.txt_navBar.TabIndex = 0;
            this.txt_navBar.Text = "SISTEMA DE INGRESO DE DONACIONES";
            // 
            // image_logo
            // 
            this.image_logo.BackColor = System.Drawing.Color.Transparent;
            this.image_logo.Image = global::proyectoLBD.Properties.Resources.AOES_PNG;
            this.image_logo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.image_logo.Location = new System.Drawing.Point(685, 404);
            this.image_logo.Name = "image_logo";
            this.image_logo.Size = new System.Drawing.Size(117, 45);
            this.image_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image_logo.TabIndex = 5;
            this.image_logo.TabStop = false;
            // 
            // panel_fondoCeleste
            // 
            this.panel_fondoCeleste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(118)))), ((int)(((byte)(149)))));
            this.panel_fondoCeleste.Controls.Add(this.bt_donaciones);
            this.panel_fondoCeleste.Controls.Add(this.pictureBox1);
            this.panel_fondoCeleste.Location = new System.Drawing.Point(24, 89);
            this.panel_fondoCeleste.Name = "panel_fondoCeleste";
            this.panel_fondoCeleste.Size = new System.Drawing.Size(229, 295);
            this.panel_fondoCeleste.TabIndex = 6;
            // 
            // bt_donaciones
            // 
            this.bt_donaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(168)))), ((int)(((byte)(2)))));
            this.bt_donaciones.FlatAppearance.BorderSize = 0;
            this.bt_donaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_donaciones.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_donaciones.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bt_donaciones.Location = new System.Drawing.Point(31, 228);
            this.bt_donaciones.Name = "bt_donaciones";
            this.bt_donaciones.Size = new System.Drawing.Size(165, 40);
            this.bt_donaciones.TabIndex = 6;
            this.bt_donaciones.Text = "Donaciones";
            this.bt_donaciones.UseVisualStyleBackColor = false;
            this.bt_donaciones.Click += new System.EventHandler(this.bt_donaciones_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::proyectoLBD.Properties.Resources.DonaciónEspecies;
            this.pictureBox1.Location = new System.Drawing.Point(14, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(118)))), ((int)(((byte)(149)))));
            this.panel1.Controls.Add(this.bt_usuarios);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(273, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 295);
            this.panel1.TabIndex = 7;
            // 
            // bt_usuarios
            // 
            this.bt_usuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(168)))), ((int)(((byte)(2)))));
            this.bt_usuarios.FlatAppearance.BorderSize = 0;
            this.bt_usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_usuarios.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_usuarios.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bt_usuarios.Location = new System.Drawing.Point(31, 228);
            this.bt_usuarios.Name = "bt_usuarios";
            this.bt_usuarios.Size = new System.Drawing.Size(165, 40);
            this.bt_usuarios.TabIndex = 6;
            this.bt_usuarios.Text = "Usuarios";
            this.bt_usuarios.UseVisualStyleBackColor = false;
            this.bt_usuarios.Click += new System.EventHandler(this.bt_usuarios_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::proyectoLBD.Properties.Resources.Usuarios;
            this.pictureBox2.Location = new System.Drawing.Point(14, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 203);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(118)))), ((int)(((byte)(149)))));
            this.panel2.Controls.Add(this.bt_sedes);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Location = new System.Drawing.Point(526, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 295);
            this.panel2.TabIndex = 8;
            // 
            // bt_sedes
            // 
            this.bt_sedes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(168)))), ((int)(((byte)(2)))));
            this.bt_sedes.FlatAppearance.BorderSize = 0;
            this.bt_sedes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_sedes.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sedes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bt_sedes.Location = new System.Drawing.Point(31, 228);
            this.bt_sedes.Name = "bt_sedes";
            this.bt_sedes.Size = new System.Drawing.Size(165, 40);
            this.bt_sedes.TabIndex = 6;
            this.bt_sedes.Text = "Sedes";
            this.bt_sedes.UseVisualStyleBackColor = false;
            this.bt_sedes.Click += new System.EventHandler(this.bt_sedes_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::proyectoLBD.Properties.Resources.Sedes;
            this.pictureBox3.Location = new System.Drawing.Point(14, 22);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(200, 203);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // MenuAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_fondoCeleste);
            this.Controls.Add(this.image_logo);
            this.Controls.Add(this.panel_fondoRojo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuAdministrador";
            this.panel_fondoRojo.ResumeLayout(false);
            this.panel_fondoRojo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_logo)).EndInit();
            this.panel_fondoCeleste.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_fondoRojo;
        private System.Windows.Forms.Label txt_navBar;
        private System.Windows.Forms.PictureBox image_logo;
        private System.Windows.Forms.Panel panel_fondoCeleste;
        public System.Windows.Forms.Button bt_donaciones;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button bt_usuarios;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button bt_sedes;
        private System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.Button bt_logout;
        private System.Windows.Forms.Button btnMin;
    }
}