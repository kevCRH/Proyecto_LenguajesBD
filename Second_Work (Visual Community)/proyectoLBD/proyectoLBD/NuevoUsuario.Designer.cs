namespace proyectoLBD
{
    partial class NuevoUsuario
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
            this.components = new System.ComponentModel.Container();
            this.image_logo = new System.Windows.Forms.PictureBox();
            this.txt_navBar = new System.Windows.Forms.Label();
            this.panel_fondoRojo = new System.Windows.Forms.Panel();
            this.panel_fondoCeleste = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.bt_login = new System.Windows.Forms.Button();
            this.dataSet1 = new proyectoLBD.DataSet1();
            this.tBROLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBROLTableAdapter = new proyectoLBD.DataSet1TableAdapters.TBROLTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.image_logo)).BeginInit();
            this.panel_fondoRojo.SuspendLayout();
            this.panel_fondoCeleste.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBROLBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // image_logo
            // 
            this.image_logo.BackColor = System.Drawing.Color.Transparent;
            this.image_logo.Image = global::proyectoLBD.Properties.Resources.AOES_PNG;
            this.image_logo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.image_logo.Location = new System.Drawing.Point(797, 5);
            this.image_logo.Name = "image_logo";
            this.image_logo.Size = new System.Drawing.Size(146, 68);
            this.image_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image_logo.TabIndex = 1;
            this.image_logo.TabStop = false;
            // 
            // txt_navBar
            // 
            this.txt_navBar.AutoSize = true;
            this.txt_navBar.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold);
            this.txt_navBar.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_navBar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_navBar.Location = new System.Drawing.Point(17, 16);
            this.txt_navBar.Name = "txt_navBar";
            this.txt_navBar.Size = new System.Drawing.Size(418, 40);
            this.txt_navBar.TabIndex = 0;
            this.txt_navBar.Text = "INGRESO DE NUEVO USUARIO";
            this.txt_navBar.Click += new System.EventHandler(this.txt_navBar_Click);
            // 
            // panel_fondoRojo
            // 
            this.panel_fondoRojo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel_fondoRojo.Controls.Add(this.image_logo);
            this.panel_fondoRojo.Controls.Add(this.txt_navBar);
            this.panel_fondoRojo.Location = new System.Drawing.Point(0, 1);
            this.panel_fondoRojo.Name = "panel_fondoRojo";
            this.panel_fondoRojo.Size = new System.Drawing.Size(965, 73);
            this.panel_fondoRojo.TabIndex = 3;
            this.panel_fondoRojo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_fondoRojo_Paint_1);
            // 
            // panel_fondoCeleste
            // 
            this.panel_fondoCeleste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(118)))), ((int)(((byte)(149)))));
            this.panel_fondoCeleste.Controls.Add(this.textBox6);
            this.panel_fondoCeleste.Controls.Add(this.textBox5);
            this.panel_fondoCeleste.Controls.Add(this.label10);
            this.panel_fondoCeleste.Controls.Add(this.label9);
            this.panel_fondoCeleste.Controls.Add(this.label8);
            this.panel_fondoCeleste.Controls.Add(this.comboBox2);
            this.panel_fondoCeleste.Controls.Add(this.label7);
            this.panel_fondoCeleste.Controls.Add(this.comboBox1);
            this.panel_fondoCeleste.Controls.Add(this.label6);
            this.panel_fondoCeleste.Controls.Add(this.textBox4);
            this.panel_fondoCeleste.Controls.Add(this.label5);
            this.panel_fondoCeleste.Controls.Add(this.textBox3);
            this.panel_fondoCeleste.Controls.Add(this.label4);
            this.panel_fondoCeleste.Controls.Add(this.textBox2);
            this.panel_fondoCeleste.Controls.Add(this.label3);
            this.panel_fondoCeleste.Controls.Add(this.label2);
            this.panel_fondoCeleste.Controls.Add(this.label1);
            this.panel_fondoCeleste.Controls.Add(this.textBox1);
            this.panel_fondoCeleste.Controls.Add(this.txt_user);
            this.panel_fondoCeleste.Controls.Add(this.txt_pass);
            this.panel_fondoCeleste.Controls.Add(this.bt_login);
            this.panel_fondoCeleste.Location = new System.Drawing.Point(24, 98);
            this.panel_fondoCeleste.Name = "panel_fondoCeleste";
            this.panel_fondoCeleste.Size = new System.Drawing.Size(897, 450);
            this.panel_fondoCeleste.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.ItemHeight = 48;
            this.comboBox1.Location = new System.Drawing.Point(45, 231);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(248, 54);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Leelawadee", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label6.Location = new System.Drawing.Point(596, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Cedula";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.textBox4.Location = new System.Drawing.Point(600, 137);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(248, 54);
            this.textBox4.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Leelawadee", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label5.Location = new System.Drawing.Point(320, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Segundo apellido";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.textBox3.Location = new System.Drawing.Point(324, 137);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(248, 54);
            this.textBox3.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Leelawadee", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label4.Location = new System.Drawing.Point(41, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Primer apellido";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.textBox2.Location = new System.Drawing.Point(45, 137);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(248, 54);
            this.textBox2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label3.Location = new System.Drawing.Point(596, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label2.Location = new System.Drawing.Point(320, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Location = new System.Drawing.Point(41, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(600, 41);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(248, 54);
            this.textBox1.TabIndex = 6;
            // 
            // txt_user
            // 
            this.txt_user.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_user.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.txt_user.Location = new System.Drawing.Point(45, 41);
            this.txt_user.Multiline = true;
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(248, 54);
            this.txt_user.TabIndex = 4;
            // 
            // txt_pass
            // 
            this.txt_pass.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_pass.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.txt_pass.Location = new System.Drawing.Point(324, 41);
            this.txt_pass.Multiline = true;
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(248, 54);
            this.txt_pass.TabIndex = 5;
            // 
            // bt_login
            // 
            this.bt_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(168)))), ((int)(((byte)(2)))));
            this.bt_login.FlatAppearance.BorderSize = 0;
            this.bt_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_login.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.bt_login.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bt_login.Location = new System.Drawing.Point(633, 387);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(215, 50);
            this.bt_login.TabIndex = 0;
            this.bt_login.Text = "Agregar";
            this.bt_login.UseVisualStyleBackColor = false;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBROLBindingSource
            // 
            this.tBROLBindingSource.DataMember = "TBROL";
            this.tBROLBindingSource.DataSource = this.dataSet1;
            // 
            // tBROLTableAdapter
            // 
            this.tBROLTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Leelawadee", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label7.Location = new System.Drawing.Point(46, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Estado";
            // 
            // comboBox2
            // 
            this.comboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.IntegralHeight = false;
            this.comboBox2.ItemHeight = 48;
            this.comboBox2.Location = new System.Drawing.Point(324, 231);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(248, 54);
            this.comboBox2.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Leelawadee", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label8.Location = new System.Drawing.Point(320, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Rol";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Leelawadee", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label9.Location = new System.Drawing.Point(596, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Correo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Leelawadee", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label10.Location = new System.Drawing.Point(47, 301);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "Teléfono";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.textBox5.Location = new System.Drawing.Point(600, 231);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(248, 54);
            this.textBox5.TabIndex = 24;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.textBox6.Location = new System.Drawing.Point(45, 324);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(248, 54);
            this.textBox6.TabIndex = 25;
            // 
            // NuevoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 574);
            this.Controls.Add(this.panel_fondoCeleste);
            this.Controls.Add(this.panel_fondoRojo);
            this.Name = "NuevoUsuario";
            this.Text = "NuevoUsuario";
            this.Load += new System.EventHandler(this.NuevoUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.image_logo)).EndInit();
            this.panel_fondoRojo.ResumeLayout(false);
            this.panel_fondoRojo.PerformLayout();
            this.panel_fondoCeleste.ResumeLayout(false);
            this.panel_fondoCeleste.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBROLBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox image_logo;
        private System.Windows.Forms.Label txt_navBar;
        private System.Windows.Forms.Panel panel_fondoRojo;
        private System.Windows.Forms.Panel panel_fondoCeleste;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_pass;
        public System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource tBROLBindingSource;
        private DataSet1TableAdapters.TBROLTableAdapter tBROLTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label7;
    }
}