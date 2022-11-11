namespace proyectoLBD
{
    partial class frm_tipo_Donacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_tipo_Donacion));
            this.txt_navBar = new System.Windows.Forms.Label();
            this.panel_fondoRojo = new System.Windows.Forms.Panel();
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
            this.txt_navBar.Location = new System.Drawing.Point(17, 16);
            this.txt_navBar.Name = "txt_navBar";
            this.txt_navBar.Size = new System.Drawing.Size(544, 40);
            this.txt_navBar.TabIndex = 0;
            this.txt_navBar.Text = "SISTEMA DE INGRESO DE DONACIONES";
            // 
            // panel_fondoRojo
            // 
            this.panel_fondoRojo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel_fondoRojo.Controls.Add(this.txt_navBar);
            this.panel_fondoRojo.Location = new System.Drawing.Point(0, 0);
            this.panel_fondoRojo.Name = "panel_fondoRojo";
            this.panel_fondoRojo.Size = new System.Drawing.Size(802, 73);
            this.panel_fondoRojo.TabIndex = 3;
            // 
            // panel_fondoCeleste
            // 
            this.panel_fondoCeleste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(118)))), ((int)(((byte)(149)))));
            this.panel_fondoCeleste.Controls.Add(this.bt_donacion_especies);
            this.panel_fondoCeleste.Controls.Add(this.pictureBox1);
            this.panel_fondoCeleste.Location = new System.Drawing.Point(89, 97);
            this.panel_fondoCeleste.Name = "panel_fondoCeleste";
            this.panel_fondoCeleste.Size = new System.Drawing.Size(288, 316);
            this.panel_fondoCeleste.TabIndex = 4;
            // 
            // bt_donacion_especies
            // 
            this.bt_donacion_especies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(168)))), ((int)(((byte)(2)))));
            this.bt_donacion_especies.FlatAppearance.BorderSize = 0;
            this.bt_donacion_especies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_donacion_especies.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_donacion_especies.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bt_donacion_especies.Location = new System.Drawing.Point(31, 228);
            this.bt_donacion_especies.Name = "bt_donacion_especies";
            this.bt_donacion_especies.Size = new System.Drawing.Size(224, 61);
            this.bt_donacion_especies.TabIndex = 6;
            this.bt_donacion_especies.Text = "Donación en Especies";
            this.bt_donacion_especies.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::proyectoLBD.Properties.Resources.DonaciónEspecies;
            this.pictureBox1.Location = new System.Drawing.Point(14, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 224);
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
            this.panel1.Location = new System.Drawing.Point(409, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 316);
            this.panel1.TabIndex = 5;
            // 
            // bt_donacion_dinero
            // 
            this.bt_donacion_dinero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(168)))), ((int)(((byte)(2)))));
            this.bt_donacion_dinero.FlatAppearance.BorderSize = 0;
            this.bt_donacion_dinero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_donacion_dinero.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_donacion_dinero.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bt_donacion_dinero.Location = new System.Drawing.Point(31, 228);
            this.bt_donacion_dinero.Name = "bt_donacion_dinero";
            this.bt_donacion_dinero.Size = new System.Drawing.Size(224, 61);
            this.bt_donacion_dinero.TabIndex = 7;
            this.bt_donacion_dinero.Text = "Donación Dinero";
            this.bt_donacion_dinero.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::proyectoLBD.Properties.Resources.DonaciónDinero;
            this.pictureBox2.Location = new System.Drawing.Point(14, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(259, 224);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // image_logo
            // 
            this.image_logo.BackColor = System.Drawing.Color.Transparent;
            this.image_logo.Image = global::proyectoLBD.Properties.Resources.AOES_PNG;
            this.image_logo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.image_logo.Location = new System.Drawing.Point(677, 394);
            this.image_logo.Name = "image_logo";
            this.image_logo.Size = new System.Drawing.Size(117, 45);
            this.image_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image_logo.TabIndex = 1;
            this.image_logo.TabStop = false;
            // 
            // frm_tipo_Donacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_fondoCeleste);
            this.Controls.Add(this.panel_fondoRojo);
            this.Controls.Add(this.image_logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_tipo_Donacion";
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
    }
}