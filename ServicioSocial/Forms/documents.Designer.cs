namespace ServicioSocial
{
    partial class documents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(documents));
            this.tabBuscar = new System.Windows.Forms.TabControl();
            this.tabbus = new System.Windows.Forms.TabPage();
            this.dgvbuscar = new System.Windows.Forms.DataGridView();
            this.paneluser = new System.Windows.Forms.Panel();
            this.cmbfiltro = new System.Windows.Forms.ComboBox();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabedit = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.cbUnidad = new System.Windows.Forms.ComboBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtaño = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtubicacion = new System.Windows.Forms.TextBox();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.txtcorrelativo = new System.Windows.Forms.TextBox();
            this.cbSubS = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabBuscar.SuspendLayout();
            this.tabbus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbuscar)).BeginInit();
            this.paneluser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabedit.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabBuscar
            // 
            this.tabBuscar.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabBuscar.Controls.Add(this.tabbus);
            this.tabBuscar.Controls.Add(this.tabedit);
            this.tabBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabBuscar.ItemSize = new System.Drawing.Size(90, 20);
            this.tabBuscar.Location = new System.Drawing.Point(0, 0);
            this.tabBuscar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabBuscar.Name = "tabBuscar";
            this.tabBuscar.SelectedIndex = 0;
            this.tabBuscar.Size = new System.Drawing.Size(795, 460);
            this.tabBuscar.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabBuscar.TabIndex = 0;
            // 
            // tabbus
            // 
            this.tabbus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(89)))));
            this.tabbus.Controls.Add(this.dgvbuscar);
            this.tabbus.Controls.Add(this.paneluser);
            this.tabbus.Location = new System.Drawing.Point(4, 24);
            this.tabbus.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabbus.Name = "tabbus";
            this.tabbus.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabbus.Size = new System.Drawing.Size(787, 432);
            this.tabbus.TabIndex = 0;
            this.tabbus.Text = "Buscar";
            this.tabbus.Click += new System.EventHandler(this.tabbus_Click);
            // 
            // dgvbuscar
            // 
            this.dgvbuscar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvbuscar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgvbuscar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvbuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbuscar.Location = new System.Drawing.Point(21, 132);
            this.dgvbuscar.Name = "dgvbuscar";
            this.dgvbuscar.RowHeadersVisible = false;
            this.dgvbuscar.RowTemplate.Height = 25;
            this.dgvbuscar.Size = new System.Drawing.Size(733, 265);
            this.dgvbuscar.TabIndex = 5;
            // 
            // paneluser
            // 
            this.paneluser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.paneluser.Controls.Add(this.cmbfiltro);
            this.paneluser.Controls.Add(this.btneliminar);
            this.paneluser.Controls.Add(this.btnBuscar);
            this.paneluser.Controls.Add(this.txtbuscar);
            this.paneluser.Controls.Add(this.pictureBox2);
            this.paneluser.Location = new System.Drawing.Point(4, 37);
            this.paneluser.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.paneluser.Name = "paneluser";
            this.paneluser.Size = new System.Drawing.Size(776, 57);
            this.paneluser.TabIndex = 4;
            // 
            // cmbfiltro
            // 
            this.cmbfiltro.FormattingEnabled = true;
            this.cmbfiltro.Items.AddRange(new object[] {
            "Codigo",
            "Año",
            "Ubicacion"});
            this.cmbfiltro.Location = new System.Drawing.Point(448, 18);
            this.cmbfiltro.Name = "cmbfiltro";
            this.cmbfiltro.Size = new System.Drawing.Size(151, 23);
            this.cmbfiltro.TabIndex = 9;
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btneliminar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btneliminar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btneliminar.Location = new System.Drawing.Point(691, 13);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(83, 33);
            this.btneliminar.TabIndex = 8;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscar.Location = new System.Drawing.Point(604, 13);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(83, 33);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtbuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbuscar.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbuscar.Location = new System.Drawing.Point(78, 16);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtbuscar.Multiline = true;
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.PlaceholderText = "Buscar documento";
            this.txtbuscar.Size = new System.Drawing.Size(365, 25);
            this.txtbuscar.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(25, 16);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // tabedit
            // 
            this.tabedit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabedit.Controls.Add(this.panel1);
            this.tabedit.Location = new System.Drawing.Point(4, 24);
            this.tabedit.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabedit.Name = "tabedit";
            this.tabedit.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabedit.Size = new System.Drawing.Size(787, 432);
            this.tabedit.TabIndex = 1;
            this.tabedit.Text = "Formulario";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(89)))));
            this.panel1.Controls.Add(this.btnguardar);
            this.panel1.Controls.Add(this.btncancelar);
            this.panel1.Controls.Add(this.cbUnidad);
            this.panel1.Controls.Add(this.txtdescripcion);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtaño);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtubicacion);
            this.panel1.Controls.Add(this.txtcod);
            this.panel1.Controls.Add(this.txtcorrelativo);
            this.panel1.Controls.Add(this.cbSubS);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 431);
            this.panel1.TabIndex = 1;
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnguardar.FlatAppearance.BorderSize = 0;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnguardar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnguardar.Location = new System.Drawing.Point(411, 357);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(106, 38);
            this.btnguardar.TabIndex = 25;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btncancelar.FlatAppearance.BorderSize = 0;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btncancelar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btncancelar.Location = new System.Drawing.Point(260, 357);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(106, 38);
            this.btncancelar.TabIndex = 24;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            // 
            // cbUnidad
            // 
            this.cbUnidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbUnidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbUnidad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbUnidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbUnidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbUnidad.FormattingEnabled = true;
            this.cbUnidad.Location = new System.Drawing.Point(411, 55);
            this.cbUnidad.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cbUnidad.Name = "cbUnidad";
            this.cbUnidad.Size = new System.Drawing.Size(322, 29);
            this.cbUnidad.TabIndex = 23;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtdescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdescripcion.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtdescripcion.Location = new System.Drawing.Point(44, 269);
            this.txtdescripcion.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtdescripcion.Multiline = true;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(689, 66);
            this.txtdescripcion.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(44, 243);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 25);
            this.label9.TabIndex = 21;
            this.label9.Text = "Descripcion:";
            // 
            // txtaño
            // 
            this.txtaño.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtaño.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtaño.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtaño.Location = new System.Drawing.Point(411, 198);
            this.txtaño.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtaño.Name = "txtaño";
            this.txtaño.Size = new System.Drawing.Size(322, 25);
            this.txtaño.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(411, 172);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "Año:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(411, 29);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Unidad Productora:";
            // 
            // txtubicacion
            // 
            this.txtubicacion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtubicacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtubicacion.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtubicacion.Location = new System.Drawing.Point(44, 198);
            this.txtubicacion.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtubicacion.Name = "txtubicacion";
            this.txtubicacion.Size = new System.Drawing.Size(322, 25);
            this.txtubicacion.TabIndex = 10;
            // 
            // txtcod
            // 
            this.txtcod.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtcod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcod.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtcod.Location = new System.Drawing.Point(411, 129);
            this.txtcod.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(322, 25);
            this.txtcod.TabIndex = 9;
            // 
            // txtcorrelativo
            // 
            this.txtcorrelativo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtcorrelativo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcorrelativo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtcorrelativo.Location = new System.Drawing.Point(44, 129);
            this.txtcorrelativo.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtcorrelativo.Name = "txtcorrelativo";
            this.txtcorrelativo.Size = new System.Drawing.Size(322, 25);
            this.txtcorrelativo.TabIndex = 2;
            // 
            // cbSubS
            // 
            this.cbSubS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbSubS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSubS.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbSubS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSubS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbSubS.FormattingEnabled = true;
            this.cbSubS.Location = new System.Drawing.Point(44, 55);
            this.cbSubS.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cbSubS.Name = "cbSubS";
            this.cbSubS.Size = new System.Drawing.Size(322, 29);
            this.cbSubS.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(411, 103);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Codigo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(44, 172);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ubicacion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(44, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Correlativo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(44, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sub-Serie:";
            // 
            // documents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(795, 460);
            this.Controls.Add(this.tabBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "documents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "buscar";
            this.Load += new System.EventHandler(this.documents_Load);
            this.tabBuscar.ResumeLayout(false);
            this.tabbus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbuscar)).EndInit();
            this.paneluser.ResumeLayout(false);
            this.paneluser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabedit.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabBuscar;
        private TabPage tabbus;
        private TabPage tabedit;
        private Panel paneluser;
        private Button btnBuscar;
        private TextBox txtbuscar;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtubicacion;
        private TextBox txtcod;
        private TextBox txtcorrelativo;
        private ComboBox cbSubS;
        private Button btneliminar;
        private TextBox txtdescripcion;
        private Label label9;
        private TextBox txtaño;
        private Label label8;
        private Label label7;
        private ComboBox cbUnidad;
        private Button btnguardar;
        private Button btncancelar;
        private ComboBox cmbfiltro;
        private DataGridView dgvbuscar;
    }
}