namespace proyectoLBD
{
    partial class ActualizarSede
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_fondoRojo = new System.Windows.Forms.Panel();
            this.bt_logout = new System.Windows.Forms.Button();
            this.bt_atrás = new System.Windows.Forms.Button();
            this.txt_navBar = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.dgvSede = new System.Windows.Forms.DataGridView();
            this.txtSede = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_fondoCeleste = new System.Windows.Forms.Panel();
            this.txtActualizar = new System.Windows.Forms.Button();
            this.txtDireccionExacta = new System.Windows.Forms.TextBox();
            this.LbDireccionExacta = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDistrito = new System.Windows.Forms.TextBox();
            this.LbCanton = new System.Windows.Forms.Label();
            this.txtCanton = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodPostal = new System.Windows.Forms.TextBox();
            this.panel_fondoRojo.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSede)).BeginInit();
            this.panel_fondoCeleste.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_fondoRojo
            // 
            this.panel_fondoRojo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel_fondoRojo.Controls.Add(this.bt_logout);
            this.panel_fondoRojo.Controls.Add(this.bt_atrás);
            this.panel_fondoRojo.Controls.Add(this.txt_navBar);
            this.panel_fondoRojo.Location = new System.Drawing.Point(3, 1);
            this.panel_fondoRojo.Margin = new System.Windows.Forms.Padding(4);
            this.panel_fondoRojo.Name = "panel_fondoRojo";
            this.panel_fondoRojo.Size = new System.Drawing.Size(1204, 90);
            this.panel_fondoRojo.TabIndex = 65;
            // 
            // bt_logout
            // 
            this.bt_logout.BackColor = System.Drawing.Color.DarkRed;
            this.bt_logout.FlatAppearance.BorderSize = 0;
            this.bt_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_logout.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_logout.Image = global::proyectoLBD.Properties.Resources.logout;
            this.bt_logout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bt_logout.Location = new System.Drawing.Point(1040, 20);
            this.bt_logout.Margin = new System.Windows.Forms.Padding(4);
            this.bt_logout.Name = "bt_logout";
            this.bt_logout.Size = new System.Drawing.Size(73, 52);
            this.bt_logout.TabIndex = 10;
            this.bt_logout.UseVisualStyleBackColor = false;
            this.bt_logout.Click += new System.EventHandler(this.bt_logout_Click);
            // 
            // bt_atrás
            // 
            this.bt_atrás.BackColor = System.Drawing.Color.DarkRed;
            this.bt_atrás.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_atrás.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.bt_atrás.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bt_atrás.Location = new System.Drawing.Point(951, 20);
            this.bt_atrás.Margin = new System.Windows.Forms.Padding(4);
            this.bt_atrás.Name = "bt_atrás";
            this.bt_atrás.Size = new System.Drawing.Size(73, 49);
            this.bt_atrás.TabIndex = 58;
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
            this.txt_navBar.Location = new System.Drawing.Point(23, 20);
            this.txt_navBar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_navBar.Name = "txt_navBar";
            this.txt_navBar.Size = new System.Drawing.Size(353, 50);
            this.txt_navBar.TabIndex = 0;
            this.txt_navBar.Text = "ACTUALIZAR SEDES";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(118)))), ((int)(((byte)(149)))));
            this.panel9.Controls.Add(this.dgvSede);
            this.panel9.Controls.Add(this.txtSede);
            this.panel9.Controls.Add(this.btnBuscar);
            this.panel9.Controls.Add(this.label1);
            this.panel9.Location = new System.Drawing.Point(35, 112);
            this.panel9.Margin = new System.Windows.Forms.Padding(4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1147, 192);
            this.panel9.TabIndex = 66;
            // 
            // dgvSede
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(170)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(170)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvSede.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSede.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(133)))), ((int)(((byte)(167)))));
            this.dgvSede.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(72)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(72)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSede.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSede.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSede.Cursor = System.Windows.Forms.Cursors.IBeam;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(130)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(130)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSede.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSede.EnableHeadersVisualStyles = false;
            this.dgvSede.Location = new System.Drawing.Point(4, 78);
            this.dgvSede.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSede.Name = "dgvSede";
            this.dgvSede.RowHeadersWidth = 51;
            this.dgvSede.Size = new System.Drawing.Size(1143, 114);
            this.dgvSede.TabIndex = 58;
            // 
            // txtSede
            // 
            this.txtSede.Location = new System.Drawing.Point(21, 41);
            this.txtSede.Margin = new System.Windows.Forms.Padding(4);
            this.txtSede.Multiline = true;
            this.txtSede.Name = "txtSede";
            this.txtSede.Size = new System.Drawing.Size(221, 24);
            this.txtSede.TabIndex = 57;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(168)))), ((int)(((byte)(2)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.Location = new System.Drawing.Point(268, 36);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(116, 32);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(118)))), ((int)(((byte)(149)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(17, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "NUMERO DE CEDULA QUE DESEA  ACTUALIZAR";
            // 
            // panel_fondoCeleste
            // 
            this.panel_fondoCeleste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(118)))), ((int)(((byte)(149)))));
            this.panel_fondoCeleste.Controls.Add(this.txtActualizar);
            this.panel_fondoCeleste.Controls.Add(this.txtDireccionExacta);
            this.panel_fondoCeleste.Controls.Add(this.LbDireccionExacta);
            this.panel_fondoCeleste.Controls.Add(this.label5);
            this.panel_fondoCeleste.Controls.Add(this.txtDistrito);
            this.panel_fondoCeleste.Controls.Add(this.LbCanton);
            this.panel_fondoCeleste.Controls.Add(this.txtCanton);
            this.panel_fondoCeleste.Controls.Add(this.label2);
            this.panel_fondoCeleste.Controls.Add(this.txtCodPostal);
            this.panel_fondoCeleste.Location = new System.Drawing.Point(35, 311);
            this.panel_fondoCeleste.Margin = new System.Windows.Forms.Padding(4);
            this.panel_fondoCeleste.Name = "panel_fondoCeleste";
            this.panel_fondoCeleste.Size = new System.Drawing.Size(1147, 382);
            this.panel_fondoCeleste.TabIndex = 67;
            // 
            // txtActualizar
            // 
            this.txtActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(168)))), ((int)(((byte)(2)))));
            this.txtActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtActualizar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActualizar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtActualizar.Location = new System.Drawing.Point(904, 318);
            this.txtActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.txtActualizar.Name = "txtActualizar";
            this.txtActualizar.Size = new System.Drawing.Size(183, 42);
            this.txtActualizar.TabIndex = 63;
            this.txtActualizar.Text = "ACTUALIZAR";
            this.txtActualizar.UseVisualStyleBackColor = false;
            this.txtActualizar.Click += new System.EventHandler(this.txtActualizar_Click);
            // 
            // txtDireccionExacta
            // 
            this.txtDireccionExacta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDireccionExacta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccionExacta.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.txtDireccionExacta.Location = new System.Drawing.Point(21, 190);
            this.txtDireccionExacta.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccionExacta.Multiline = true;
            this.txtDireccionExacta.Name = "txtDireccionExacta";
            this.txtDireccionExacta.Size = new System.Drawing.Size(1065, 104);
            this.txtDireccionExacta.TabIndex = 25;
            // 
            // LbDireccionExacta
            // 
            this.LbDireccionExacta.AutoSize = true;
            this.LbDireccionExacta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbDireccionExacta.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.LbDireccionExacta.Location = new System.Drawing.Point(16, 144);
            this.LbDireccionExacta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbDireccionExacta.Name = "LbDireccionExacta";
            this.LbDireccionExacta.Size = new System.Drawing.Size(192, 26);
            this.LbDireccionExacta.TabIndex = 23;
            this.LbDireccionExacta.Text = "Dirección Exacta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label5.Location = new System.Drawing.Point(384, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 26);
            this.label5.TabIndex = 13;
            this.label5.Text = "Distrito";
            // 
            // txtDistrito
            // 
            this.txtDistrito.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDistrito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDistrito.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.txtDistrito.Location = new System.Drawing.Point(389, 50);
            this.txtDistrito.Margin = new System.Windows.Forms.Padding(4);
            this.txtDistrito.Multiline = true;
            this.txtDistrito.Name = "txtDistrito";
            this.txtDistrito.Size = new System.Drawing.Size(330, 66);
            this.txtDistrito.TabIndex = 12;
            // 
            // LbCanton
            // 
            this.LbCanton.AutoSize = true;
            this.LbCanton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCanton.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.LbCanton.Location = new System.Drawing.Point(751, 22);
            this.LbCanton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbCanton.Name = "LbCanton";
            this.LbCanton.Size = new System.Drawing.Size(88, 26);
            this.LbCanton.TabIndex = 11;
            this.LbCanton.Text = "Cantón";
            // 
            // txtCanton
            // 
            this.txtCanton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCanton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCanton.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.txtCanton.Location = new System.Drawing.Point(756, 50);
            this.txtCanton.Margin = new System.Windows.Forms.Padding(4);
            this.txtCanton.Multiline = true;
            this.txtCanton.Name = "txtCanton";
            this.txtCanton.Size = new System.Drawing.Size(330, 66);
            this.txtCanton.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label2.Location = new System.Drawing.Point(16, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "Código postal";
            // 
            // txtCodPostal
            // 
            this.txtCodPostal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCodPostal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodPostal.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.txtCodPostal.Location = new System.Drawing.Point(21, 50);
            this.txtCodPostal.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodPostal.Multiline = true;
            this.txtCodPostal.Name = "txtCodPostal";
            this.txtCodPostal.Size = new System.Drawing.Size(330, 66);
            this.txtCodPostal.TabIndex = 5;
            // 
            // ActualizarSede
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 752);
            this.Controls.Add(this.panel_fondoCeleste);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel_fondoRojo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ActualizarSede";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ActualizarSede";
            this.panel_fondoRojo.ResumeLayout(false);
            this.panel_fondoRojo.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSede)).EndInit();
            this.panel_fondoCeleste.ResumeLayout(false);
            this.panel_fondoCeleste.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_fondoRojo;
        public System.Windows.Forms.Button bt_logout;
        private System.Windows.Forms.Button bt_atrás;
        private System.Windows.Forms.Label txt_navBar;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.DataGridView dgvSede;
        private System.Windows.Forms.TextBox txtSede;
        public System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_fondoCeleste;
        private System.Windows.Forms.TextBox txtDireccionExacta;
        private System.Windows.Forms.Label LbDireccionExacta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDistrito;
        private System.Windows.Forms.Label LbCanton;
        private System.Windows.Forms.TextBox txtCanton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodPostal;
        private System.Windows.Forms.Button txtActualizar;
    }
}