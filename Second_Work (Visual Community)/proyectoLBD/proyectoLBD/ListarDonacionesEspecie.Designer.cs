namespace proyectoLBD
{
    partial class ListarDonacionesEspecie
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_fondoRojo = new System.Windows.Forms.Panel();
            this.bt_logout = new System.Windows.Forms.Button();
            this.bt_atrás = new System.Windows.Forms.Button();
            this.txt_navBar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel_fondoRojo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_fondoRojo
            // 
            this.panel_fondoRojo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel_fondoRojo.Controls.Add(this.bt_logout);
            this.panel_fondoRojo.Controls.Add(this.bt_atrás);
            this.panel_fondoRojo.Controls.Add(this.txt_navBar);
            this.panel_fondoRojo.Location = new System.Drawing.Point(1, -2);
            this.panel_fondoRojo.Name = "panel_fondoRojo";
            this.panel_fondoRojo.Size = new System.Drawing.Size(1195, 103);
            this.panel_fondoRojo.TabIndex = 24;
            // 
            // bt_logout
            // 
            this.bt_logout.BackColor = System.Drawing.Color.DarkRed;
            this.bt_logout.FlatAppearance.BorderSize = 0;
            this.bt_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_logout.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_logout.Image = global::proyectoLBD.Properties.Resources.logout;
            this.bt_logout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bt_logout.Location = new System.Drawing.Point(1092, 25);
            this.bt_logout.Name = "bt_logout";
            this.bt_logout.Size = new System.Drawing.Size(55, 40);
            this.bt_logout.TabIndex = 26;
            this.bt_logout.UseVisualStyleBackColor = false;
            this.bt_logout.Click += new System.EventHandler(this.bt_logout_Click);
            // 
            // bt_atrás
            // 
            this.bt_atrás.BackColor = System.Drawing.Color.DarkRed;
            this.bt_atrás.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_atrás.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.bt_atrás.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bt_atrás.Location = new System.Drawing.Point(1019, 25);
            this.bt_atrás.Name = "bt_atrás";
            this.bt_atrás.Size = new System.Drawing.Size(55, 40);
            this.bt_atrás.TabIndex = 57;
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
            this.txt_navBar.Location = new System.Drawing.Point(14, 25);
            this.txt_navBar.Name = "txt_navBar";
            this.txt_navBar.Size = new System.Drawing.Size(346, 40);
            this.txt_navBar.TabIndex = 0;
            this.txt_navBar.Text = "MOSTRAR DONACIONES";
            this.txt_navBar.Click += new System.EventHandler(this.txt_navBar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(118)))), ((int)(((byte)(149)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1168, 520);
            this.panel1.TabIndex = 25;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(168)))), ((int)(((byte)(2)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(1025, 461);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 45);
            this.button2.TabIndex = 50;
            this.button2.Text = "LISTAR DONACIONES";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(170)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(170)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(133)))), ((int)(((byte)(167)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(72)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(72)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(130)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(130)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1141, 431);
            this.dataGridView1.TabIndex = 0;
            // 
            // ListarDonacionesEspecie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 639);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_fondoRojo);
            this.Name = "ListarDonacionesEspecie";
            this.Text = "VerDonaciones";
            this.panel_fondoRojo.ResumeLayout(false);
            this.panel_fondoRojo.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_fondoRojo;
        private System.Windows.Forms.Label txt_navBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bt_atrás;
        public System.Windows.Forms.Button bt_logout;
    }
}