namespace proyectoLBD
{
    partial class AgregarSede
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
            this.panel_fondoRojo = new System.Windows.Forms.Panel();
            this.bt_atrás = new System.Windows.Forms.Button();
            this.txt_navBar = new System.Windows.Forms.Label();
            this.image_logo = new System.Windows.Forms.PictureBox();
            this.panel_fondoCeleste = new System.Windows.Forms.Panel();
            this.txtDireccionExacta = new System.Windows.Forms.TextBox();
            this.LbDireccionExacta = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDistrito = new System.Windows.Forms.TextBox();
            this.LbCanton = new System.Windows.Forms.Label();
            this.txtCanton = new System.Windows.Forms.TextBox();
            this.LbProvincia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProvincia = new System.Windows.Forms.TextBox();
            this.txtNombreSede = new System.Windows.Forms.TextBox();
            this.txtCodPostal = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.bt_logout = new System.Windows.Forms.Button();
            this.panel_fondoRojo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_logo)).BeginInit();
            this.panel_fondoCeleste.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_fondoRojo
            // 
            this.panel_fondoRojo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel_fondoRojo.Controls.Add(this.bt_logout);
            this.panel_fondoRojo.Controls.Add(this.bt_atrás);
            this.panel_fondoRojo.Controls.Add(this.txt_navBar);
            this.panel_fondoRojo.Location = new System.Drawing.Point(2, 1);
            this.panel_fondoRojo.Name = "panel_fondoRojo";
            this.panel_fondoRojo.Size = new System.Drawing.Size(1031, 73);
            this.panel_fondoRojo.TabIndex = 6;
            // 
            // bt_atrás
            // 
            this.bt_atrás.BackColor = System.Drawing.Color.DarkRed;
            this.bt_atrás.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_atrás.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.bt_atrás.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bt_atrás.Location = new System.Drawing.Point(877, 16);
            this.bt_atrás.Name = "bt_atrás";
            this.bt_atrás.Size = new System.Drawing.Size(55, 40);
            this.bt_atrás.TabIndex = 56;
            this.bt_atrás.Text = "<<";
            this.bt_atrás.UseVisualStyleBackColor = false;
            this.bt_atrás.Click += new System.EventHandler(this.bt_atrás_Click);
            // 
            // txt_navBar
            // 
            this.txt_navBar.AutoSize = true;
            this.txt_navBar.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold);
            this.txt_navBar.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_navBar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_navBar.Location = new System.Drawing.Point(17, 16);
            this.txt_navBar.Name = "txt_navBar";
            this.txt_navBar.Size = new System.Drawing.Size(279, 40);
            this.txt_navBar.TabIndex = 0;
            this.txt_navBar.Text = "Ingresar nueva sede";
            this.txt_navBar.Click += new System.EventHandler(this.txt_navBar_Click);
            // 
            // image_logo
            // 
            this.image_logo.BackColor = System.Drawing.Color.Transparent;
            this.image_logo.Image = global::proyectoLBD.Properties.Resources.AOES_PNG;
            this.image_logo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.image_logo.Location = new System.Drawing.Point(849, 166);
            this.image_logo.Name = "image_logo";
            this.image_logo.Size = new System.Drawing.Size(161, 93);
            this.image_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image_logo.TabIndex = 1;
            this.image_logo.TabStop = false;
            // 
            // panel_fondoCeleste
            // 
            this.panel_fondoCeleste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(118)))), ((int)(((byte)(149)))));
            this.panel_fondoCeleste.Controls.Add(this.txtDireccionExacta);
            this.panel_fondoCeleste.Controls.Add(this.LbDireccionExacta);
            this.panel_fondoCeleste.Controls.Add(this.label5);
            this.panel_fondoCeleste.Controls.Add(this.txtDistrito);
            this.panel_fondoCeleste.Controls.Add(this.LbCanton);
            this.panel_fondoCeleste.Controls.Add(this.txtCanton);
            this.panel_fondoCeleste.Controls.Add(this.LbProvincia);
            this.panel_fondoCeleste.Controls.Add(this.label2);
            this.panel_fondoCeleste.Controls.Add(this.label1);
            this.panel_fondoCeleste.Controls.Add(this.txtProvincia);
            this.panel_fondoCeleste.Controls.Add(this.txtNombreSede);
            this.panel_fondoCeleste.Controls.Add(this.txtCodPostal);
            this.panel_fondoCeleste.Location = new System.Drawing.Point(12, 80);
            this.panel_fondoCeleste.Name = "panel_fondoCeleste";
            this.panel_fondoCeleste.Size = new System.Drawing.Size(831, 356);
            this.panel_fondoCeleste.TabIndex = 7;
            // 
            // txtDireccionExacta
            // 
            this.txtDireccionExacta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDireccionExacta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccionExacta.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.txtDireccionExacta.Location = new System.Drawing.Point(14, 230);
            this.txtDireccionExacta.Multiline = true;
            this.txtDireccionExacta.Name = "txtDireccionExacta";
            this.txtDireccionExacta.Size = new System.Drawing.Size(794, 85);
            this.txtDireccionExacta.TabIndex = 25;
            // 
            // LbDireccionExacta
            // 
            this.LbDireccionExacta.AutoSize = true;
            this.LbDireccionExacta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbDireccionExacta.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.LbDireccionExacta.Location = new System.Drawing.Point(10, 207);
            this.LbDireccionExacta.Name = "LbDireccionExacta";
            this.LbDireccionExacta.Size = new System.Drawing.Size(153, 20);
            this.LbDireccionExacta.TabIndex = 23;
            this.LbDireccionExacta.Text = "Dirección Exacta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label5.Location = new System.Drawing.Point(288, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Distrito";
            // 
            // txtDistrito
            // 
            this.txtDistrito.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDistrito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDistrito.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.txtDistrito.Location = new System.Drawing.Point(292, 137);
            this.txtDistrito.Multiline = true;
            this.txtDistrito.Name = "txtDistrito";
            this.txtDistrito.Size = new System.Drawing.Size(248, 54);
            this.txtDistrito.TabIndex = 12;
            // 
            // LbCanton
            // 
            this.LbCanton.AutoSize = true;
            this.LbCanton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCanton.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.LbCanton.Location = new System.Drawing.Point(9, 114);
            this.LbCanton.Name = "LbCanton";
            this.LbCanton.Size = new System.Drawing.Size(68, 20);
            this.LbCanton.TabIndex = 11;
            this.LbCanton.Text = "Cantón";
            // 
            // txtCanton
            // 
            this.txtCanton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCanton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCanton.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.txtCanton.Location = new System.Drawing.Point(13, 137);
            this.txtCanton.Multiline = true;
            this.txtCanton.Name = "txtCanton";
            this.txtCanton.Size = new System.Drawing.Size(248, 54);
            this.txtCanton.TabIndex = 10;
            // 
            // LbProvincia
            // 
            this.LbProvincia.AutoSize = true;
            this.LbProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbProvincia.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.LbProvincia.Location = new System.Drawing.Point(556, 18);
            this.LbProvincia.Name = "LbProvincia";
            this.LbProvincia.Size = new System.Drawing.Size(87, 20);
            this.LbProvincia.TabIndex = 9;
            this.LbProvincia.Text = "Provincia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label2.Location = new System.Drawing.Point(288, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Código postal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre Sede";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtProvincia
            // 
            this.txtProvincia.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtProvincia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProvincia.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.txtProvincia.Location = new System.Drawing.Point(560, 41);
            this.txtProvincia.Multiline = true;
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(248, 54);
            this.txtProvincia.TabIndex = 6;
            // 
            // txtNombreSede
            // 
            this.txtNombreSede.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNombreSede.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreSede.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.txtNombreSede.Location = new System.Drawing.Point(13, 41);
            this.txtNombreSede.Multiline = true;
            this.txtNombreSede.Name = "txtNombreSede";
            this.txtNombreSede.Size = new System.Drawing.Size(248, 54);
            this.txtNombreSede.TabIndex = 4;
            // 
            // txtCodPostal
            // 
            this.txtCodPostal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCodPostal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodPostal.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.txtCodPostal.Location = new System.Drawing.Point(292, 41);
            this.txtCodPostal.Multiline = true;
            this.txtCodPostal.Name = "txtCodPostal";
            this.txtCodPostal.Size = new System.Drawing.Size(248, 54);
            this.txtCodPostal.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(168)))), ((int)(((byte)(2)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAgregar.Location = new System.Drawing.Point(879, 374);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(131, 48);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // bt_logout
            // 
            this.bt_logout.BackColor = System.Drawing.Color.DarkRed;
            this.bt_logout.FlatAppearance.BorderSize = 0;
            this.bt_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_logout.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_logout.Image = global::proyectoLBD.Properties.Resources.logout;
            this.bt_logout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bt_logout.Location = new System.Drawing.Point(938, 16);
            this.bt_logout.Name = "bt_logout";
            this.bt_logout.Size = new System.Drawing.Size(55, 40);
            this.bt_logout.TabIndex = 28;
            this.bt_logout.UseVisualStyleBackColor = false;
            this.bt_logout.Click += new System.EventHandler(this.bt_logout_Click);
            // 
            // AgregarSede
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 455);
            this.Controls.Add(this.image_logo);
            this.Controls.Add(this.panel_fondoCeleste);
            this.Controls.Add(this.panel_fondoRojo);
            this.Controls.Add(this.btnAgregar);
            this.Name = "AgregarSede";
            this.Text = "AgregarSede";
            this.panel_fondoRojo.ResumeLayout(false);
            this.panel_fondoRojo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_logo)).EndInit();
            this.panel_fondoCeleste.ResumeLayout(false);
            this.panel_fondoCeleste.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_fondoRojo;
        private System.Windows.Forms.PictureBox image_logo;
        private System.Windows.Forms.Label txt_navBar;
        private System.Windows.Forms.Panel panel_fondoCeleste;
        private System.Windows.Forms.TextBox txtDireccionExacta;
        private System.Windows.Forms.Label LbDireccionExacta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDistrito;
        private System.Windows.Forms.Label LbCanton;
        private System.Windows.Forms.TextBox txtCanton;
        private System.Windows.Forms.Label LbProvincia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProvincia;
        private System.Windows.Forms.TextBox txtNombreSede;
        private System.Windows.Forms.TextBox txtCodPostal;
        public System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button bt_atrás;
        public System.Windows.Forms.Button bt_logout;
    }
}