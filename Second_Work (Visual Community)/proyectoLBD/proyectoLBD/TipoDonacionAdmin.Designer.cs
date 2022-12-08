namespace proyectoLBD
{
    partial class TipoDonacionAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TipoDonacionAdmin));
            this.txt_navBar = new System.Windows.Forms.Label();
            this.panel_fondoRojo = new System.Windows.Forms.Panel();
            this.bt_atrás = new System.Windows.Forms.Button();
            this.bt_logout = new System.Windows.Forms.Button();
            this.panel_fondoCeleste = new System.Windows.Forms.Panel();
            this.bt_donacion_especies = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_donacion_dinero = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.image_logo = new System.Windows.Forms.PictureBox();
            this.panel_fondoRojo.SuspendLayout();
            this.panel_fondoCeleste.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_navBar
            // 
            this.txt_navBar.AutoSize = true;
            this.txt_navBar.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold);
            this.txt_navBar.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_navBar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_navBar.Location = new System.Drawing.Point(23, 20);
            this.txt_navBar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_navBar.Name = "txt_navBar";
            this.txt_navBar.Size = new System.Drawing.Size(694, 50);
            this.txt_navBar.TabIndex = 0;
            this.txt_navBar.Text = "SISTEMA DE INGRESO DE DONACIONES";
            // 
            // panel_fondoRojo
            // 
            this.panel_fondoRojo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel_fondoRojo.Controls.Add(this.bt_atrás);
            this.panel_fondoRojo.Controls.Add(this.bt_logout);
            this.panel_fondoRojo.Controls.Add(this.txt_navBar);
            this.panel_fondoRojo.Location = new System.Drawing.Point(0, 0);
            this.panel_fondoRojo.Margin = new System.Windows.Forms.Padding(4);
            this.panel_fondoRojo.Name = "panel_fondoRojo";
            this.panel_fondoRojo.Size = new System.Drawing.Size(1069, 90);
            this.panel_fondoRojo.TabIndex = 3;
            // 
            // bt_atrás
            // 
            this.bt_atrás.BackColor = System.Drawing.Color.DarkRed;
            this.bt_atrás.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_atrás.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.bt_atrás.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bt_atrás.Location = new System.Drawing.Point(896, 22);
            this.bt_atrás.Margin = new System.Windows.Forms.Padding(4);
            this.bt_atrás.Name = "bt_atrás";
            this.bt_atrás.Size = new System.Drawing.Size(73, 49);
            this.bt_atrás.TabIndex = 56;
            this.bt_atrás.Text = "<<";
            this.bt_atrás.UseVisualStyleBackColor = false;
            this.bt_atrás.Click += new System.EventHandler(this.bt_atrás_Click);
            // 
            // bt_logout
            // 
            this.bt_logout.BackColor = System.Drawing.Color.DarkRed;
            this.bt_logout.FlatAppearance.BorderSize = 0;
            this.bt_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_logout.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_logout.Image = global::proyectoLBD.Properties.Resources.logout;
            this.bt_logout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bt_logout.Location = new System.Drawing.Point(977, 20);
            this.bt_logout.Margin = new System.Windows.Forms.Padding(4);
            this.bt_logout.Name = "bt_logout";
            this.bt_logout.Size = new System.Drawing.Size(73, 52);
            this.bt_logout.TabIndex = 11;
            this.bt_logout.UseVisualStyleBackColor = false;
            this.bt_logout.Click += new System.EventHandler(this.bt_logout_Click);
            // 
            // panel_fondoCeleste
            // 
            this.panel_fondoCeleste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(118)))), ((int)(((byte)(149)))));
            this.panel_fondoCeleste.Controls.Add(this.bt_donacion_especies);
            this.panel_fondoCeleste.Controls.Add(this.pictureBox1);
            this.panel_fondoCeleste.Location = new System.Drawing.Point(119, 119);
            this.panel_fondoCeleste.Margin = new System.Windows.Forms.Padding(4);
            this.panel_fondoCeleste.Name = "panel_fondoCeleste";
            this.panel_fondoCeleste.Size = new System.Drawing.Size(384, 389);
            this.panel_fondoCeleste.TabIndex = 4;
            // 
            // bt_donacion_especies
            // 
            this.bt_donacion_especies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(168)))), ((int)(((byte)(2)))));
            this.bt_donacion_especies.FlatAppearance.BorderSize = 0;
            this.bt_donacion_especies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_donacion_especies.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_donacion_especies.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bt_donacion_especies.Location = new System.Drawing.Point(41, 281);
            this.bt_donacion_especies.Margin = new System.Windows.Forms.Padding(4);
            this.bt_donacion_especies.Name = "bt_donacion_especies";
            this.bt_donacion_especies.Size = new System.Drawing.Size(299, 75);
            this.bt_donacion_especies.TabIndex = 6;
            this.bt_donacion_especies.Text = "Donación en Especies";
            this.bt_donacion_especies.UseVisualStyleBackColor = false;
            this.bt_donacion_especies.Click += new System.EventHandler(this.bt_donacion_especies_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::proyectoLBD.Properties.Resources.DonaciónEspecies;
            this.pictureBox1.Location = new System.Drawing.Point(19, 27);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(345, 276);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(118)))), ((int)(((byte)(149)))));
            this.panel1.Controls.Add(this.bt_donacion_dinero);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(545, 119);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 389);
            this.panel1.TabIndex = 5;
            // 
            // bt_donacion_dinero
            // 
            this.bt_donacion_dinero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(168)))), ((int)(((byte)(2)))));
            this.bt_donacion_dinero.FlatAppearance.BorderSize = 0;
            this.bt_donacion_dinero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_donacion_dinero.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_donacion_dinero.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bt_donacion_dinero.Location = new System.Drawing.Point(41, 281);
            this.bt_donacion_dinero.Margin = new System.Windows.Forms.Padding(4);
            this.bt_donacion_dinero.Name = "bt_donacion_dinero";
            this.bt_donacion_dinero.Size = new System.Drawing.Size(299, 75);
            this.bt_donacion_dinero.TabIndex = 7;
            this.bt_donacion_dinero.Text = "Donación Dinero";
            this.bt_donacion_dinero.UseVisualStyleBackColor = false;
            this.bt_donacion_dinero.Click += new System.EventHandler(this.bt_donacion_dinero_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::proyectoLBD.Properties.Resources.DonaciónDinero;
            this.pictureBox2.Location = new System.Drawing.Point(19, 27);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(345, 276);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // image_logo
            // 
            this.image_logo.BackColor = System.Drawing.Color.Transparent;
            this.image_logo.Image = global::proyectoLBD.Properties.Resources.AOES_PNG;
            this.image_logo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.image_logo.Location = new System.Drawing.Point(903, 485);
            this.image_logo.Margin = new System.Windows.Forms.Padding(4);
            this.image_logo.Name = "image_logo";
            this.image_logo.Size = new System.Drawing.Size(156, 55);
            this.image_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image_logo.TabIndex = 1;
            this.image_logo.TabStop = false;
            // 
            // TipoDonacionAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_fondoCeleste);
            this.Controls.Add(this.panel_fondoRojo);
            this.Controls.Add(this.image_logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TipoDonacionAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panel_fondoRojo.ResumeLayout(false);
            this.panel_fondoRojo.PerformLayout();
            this.panel_fondoCeleste.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox image_logo;
        private System.Windows.Forms.Label txt_navBar;
        private System.Windows.Forms.Panel panel_fondoRojo;
        private System.Windows.Forms.Panel panel_fondoCeleste;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Button bt_donacion_especies;
        public System.Windows.Forms.Button bt_donacion_dinero;
        public System.Windows.Forms.Button bt_logout;
        private System.Windows.Forms.Button bt_atrás;
    }
}