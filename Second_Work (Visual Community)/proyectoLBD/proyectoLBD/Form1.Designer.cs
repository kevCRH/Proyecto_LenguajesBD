namespace proyectoLBD
{
    partial class frm_login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            this.panel_fondoCeleste = new System.Windows.Forms.Panel();
            this.bt_login = new System.Windows.Forms.Button();
            this.txt_inicial = new System.Windows.Forms.Label();
            this.panel_fondoRojo = new System.Windows.Forms.Panel();
            this.txt_navBar = new System.Windows.Forms.Label();
            this.image_logo = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.panel_fondoCeleste.SuspendLayout();
            this.panel_fondoRojo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_fondoCeleste
            // 
            this.panel_fondoCeleste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(118)))), ((int)(((byte)(149)))));
            this.panel_fondoCeleste.Controls.Add(this.txt_pass);
            this.panel_fondoCeleste.Controls.Add(this.txt_email);
            this.panel_fondoCeleste.Controls.Add(this.label5);
            this.panel_fondoCeleste.Controls.Add(this.label4);
            this.panel_fondoCeleste.Controls.Add(this.label3);
            this.panel_fondoCeleste.Controls.Add(this.bt_login);
            resources.ApplyResources(this.panel_fondoCeleste, "panel_fondoCeleste");
            this.panel_fondoCeleste.Name = "panel_fondoCeleste";
            this.panel_fondoCeleste.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bt_login
            // 
            this.bt_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(168)))), ((int)(((byte)(2)))));
            this.bt_login.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.bt_login, "bt_login");
            this.bt_login.Name = "bt_login";
            this.bt_login.UseVisualStyleBackColor = false;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // txt_inicial
            // 
            resources.ApplyResources(this.txt_inicial, "txt_inicial");
            this.txt_inicial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txt_inicial.Name = "txt_inicial";
            this.txt_inicial.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel_fondoRojo
            // 
            this.panel_fondoRojo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel_fondoRojo.Controls.Add(this.image_logo);
            this.panel_fondoRojo.Controls.Add(this.txt_navBar);
            resources.ApplyResources(this.panel_fondoRojo, "panel_fondoRojo");
            this.panel_fondoRojo.Name = "panel_fondoRojo";
            // 
            // txt_navBar
            // 
            resources.ApplyResources(this.txt_navBar, "txt_navBar");
            this.txt_navBar.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_navBar.Name = "txt_navBar";
            this.txt_navBar.Click += new System.EventHandler(this.label2_Click);
            // 
            // image_logo
            // 
            this.image_logo.BackColor = System.Drawing.Color.Transparent;
            this.image_logo.Image = global::proyectoLBD.Properties.Resources.AOES_PNG;
            resources.ApplyResources(this.image_logo, "image_logo");
            this.image_logo.Name = "image_logo";
            this.image_logo.TabStop = false;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.txt_email, "txt_email");
            this.txt_email.Name = "txt_email";
            this.txt_email.TextChanged += new System.EventHandler(this.txt_email_TextChanged);
            // 
            // txt_pass
            // 
            this.txt_pass.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.txt_pass, "txt_pass");
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.TextChanged += new System.EventHandler(this.txt_pass_TextChanged);
            // 
            // frm_login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panel_fondoRojo);
            this.Controls.Add(this.txt_inicial);
            this.Controls.Add(this.panel_fondoCeleste);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frm_login";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.frm_login_Load);
            this.panel_fondoCeleste.ResumeLayout(false);
            this.panel_fondoCeleste.PerformLayout();
            this.panel_fondoRojo.ResumeLayout(false);
            this.panel_fondoRojo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_fondoCeleste;
        public System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.Label txt_inicial;
        private System.Windows.Forms.Panel panel_fondoRojo;
        private System.Windows.Forms.Label txt_navBar;
        private System.Windows.Forms.PictureBox image_logo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_email;
    }
}

