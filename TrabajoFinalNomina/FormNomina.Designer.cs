namespace TrabajoFinalNomina
{
    partial class FormNomina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNomina));
            grpDatos = new GroupBox();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            pictureBox6 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            mtbAntigüedad = new MaskedTextBox();
            mtbHorasExtra = new MaskedTextBox();
            txtSalario = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            cmbDepartamento = new ComboBox();
            mtbNoINNS = new MaskedTextBox();
            label3 = new Label();
            label2 = new Label();
            pictureBox5 = new PictureBox();
            txtNombre = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dvgNomina = new DataGridView();
            clmNoINNS = new DataGridViewTextBoxColumn();
            clmNombre = new DataGridViewTextBoxColumn();
            clmDepartamento = new DataGridViewTextBoxColumn();
            clmSalarioMensual = new DataGridViewTextBoxColumn();
            clmSalarioQuincenal = new DataGridViewTextBoxColumn();
            clmSalarioSemanal = new DataGridViewTextBoxColumn();
            clmHorasExtras = new DataGridViewTextBoxColumn();
            clmIngresoPorHora = new DataGridViewTextBoxColumn();
            clmAntigüedad = new DataGridViewTextBoxColumn();
            clmTotalIngresos = new DataGridViewTextBoxColumn();
            clmINNSLaboral = new DataGridViewTextBoxColumn();
            clmIR = new DataGridViewTextBoxColumn();
            clmTotalDeducciones = new DataGridViewTextBoxColumn();
            clmSalarioNeto = new DataGridViewTextBoxColumn();
            clmINATEC = new DataGridViewTextBoxColumn();
            clmINNSPatronal = new DataGridViewTextBoxColumn();
            clmVacaciones = new DataGridViewTextBoxColumn();
            clmTreceavoMes = new DataGridViewTextBoxColumn();
            btnCalcular = new Button();
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnCargar = new Button();
            grpDatos.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvgNomina).BeginInit();
            SuspendLayout();
            // 
            // grpDatos
            // 
            grpDatos.Anchor = AnchorStyles.None;
            grpDatos.BackColor = SystemColors.ControlLight;
            grpDatos.Controls.Add(toolStrip1);
            grpDatos.Controls.Add(pictureBox6);
            grpDatos.Controls.Add(pictureBox4);
            grpDatos.Controls.Add(pictureBox3);
            grpDatos.Controls.Add(pictureBox2);
            grpDatos.Controls.Add(mtbAntigüedad);
            grpDatos.Controls.Add(mtbHorasExtra);
            grpDatos.Controls.Add(txtSalario);
            grpDatos.Controls.Add(label6);
            grpDatos.Controls.Add(label5);
            grpDatos.Controls.Add(label4);
            grpDatos.Controls.Add(cmbDepartamento);
            grpDatos.Controls.Add(mtbNoINNS);
            grpDatos.Controls.Add(label3);
            grpDatos.Controls.Add(label2);
            grpDatos.Controls.Add(pictureBox5);
            grpDatos.Controls.Add(txtNombre);
            grpDatos.Controls.Add(label1);
            grpDatos.Controls.Add(pictureBox1);
            grpDatos.Font = new Font("Cambria", 18F, FontStyle.Bold);
            grpDatos.Location = new Point(12, 12);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(1426, 223);
            grpDatos.TabIndex = 0;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos";
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.Transparent;
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1 });
            toolStrip1.Location = new Point(1384, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(42, 27);
            toolStrip1.TabIndex = 32;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(29, 24);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(760, 153);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(30, 29);
            pictureBox6.TabIndex = 31;
            pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(760, 103);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 29);
            pictureBox4.TabIndex = 30;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(760, 57);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 29);
            pictureBox3.TabIndex = 29;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(78, 157);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 29);
            pictureBox2.TabIndex = 28;
            pictureBox2.TabStop = false;
            // 
            // mtbAntigüedad
            // 
            mtbAntigüedad.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mtbAntigüedad.Location = new Point(1059, 157);
            mtbAntigüedad.Mask = "99";
            mtbAntigüedad.Name = "mtbAntigüedad";
            mtbAntigüedad.Size = new Size(225, 34);
            mtbAntigüedad.TabIndex = 27;
            mtbAntigüedad.ValidatingType = typeof(int);
            // 
            // mtbHorasExtra
            // 
            mtbHorasExtra.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mtbHorasExtra.Location = new Point(1059, 104);
            mtbHorasExtra.Mask = "99";
            mtbHorasExtra.Name = "mtbHorasExtra";
            mtbHorasExtra.Size = new Size(225, 34);
            mtbHorasExtra.TabIndex = 26;
            mtbHorasExtra.ValidatingType = typeof(int);
            // 
            // txtSalario
            // 
            txtSalario.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSalario.Location = new Point(1059, 52);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(225, 34);
            txtSalario.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(797, 153);
            label6.Name = "label6";
            label6.Size = new Size(173, 33);
            label6.TabIndex = 24;
            label6.Text = "Antigüedad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(797, 103);
            label5.Name = "label5";
            label5.Size = new Size(188, 33);
            label5.TabIndex = 23;
            label5.Text = "Horas Extras:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(797, 53);
            label4.Name = "label4";
            label4.Size = new Size(114, 33);
            label4.TabIndex = 22;
            label4.Text = "Salario:";
            // 
            // cmbDepartamento
            // 
            cmbDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartamento.Font = new Font("Cambria", 13.8F, FontStyle.Bold);
            cmbDepartamento.FormattingEnabled = true;
            cmbDepartamento.Items.AddRange(new object[] { "Direccion", "Recursos Humanos", "Produccion", "Marketing", "Compras", "Logística" });
            cmbDepartamento.Location = new Point(402, 151);
            cmbDepartamento.Name = "cmbDepartamento";
            cmbDepartamento.Size = new Size(225, 35);
            cmbDepartamento.TabIndex = 21;
            // 
            // mtbNoINNS
            // 
            mtbNoINNS.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mtbNoINNS.Location = new Point(402, 104);
            mtbNoINNS.Mask = "999999999";
            mtbNoINNS.Name = "mtbNoINNS";
            mtbNoINNS.Size = new Size(225, 34);
            mtbNoINNS.TabIndex = 20;
            mtbNoINNS.ValidatingType = typeof(int);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(114, 153);
            label3.Name = "label3";
            label3.Size = new Size(211, 33);
            label3.TabIndex = 19;
            label3.Text = "Departamento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(114, 103);
            label2.Name = "label2";
            label2.Size = new Size(124, 33);
            label2.TabIndex = 18;
            label2.Text = "No. INNS";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(78, 107);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(30, 29);
            pictureBox5.TabIndex = 17;
            pictureBox5.TabStop = false;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(402, 53);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(225, 34);
            txtNombre.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(114, 53);
            label1.Name = "label1";
            label1.Size = new Size(128, 33);
            label1.TabIndex = 14;
            label1.Text = "Nombre:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(78, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 29);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // dvgNomina
            // 
            dvgNomina.Anchor = AnchorStyles.None;
            dvgNomina.BackgroundColor = SystemColors.ControlLight;
            dvgNomina.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgNomina.Columns.AddRange(new DataGridViewColumn[] { clmNoINNS, clmNombre, clmDepartamento, clmSalarioMensual, clmSalarioQuincenal, clmSalarioSemanal, clmHorasExtras, clmIngresoPorHora, clmAntigüedad, clmTotalIngresos, clmINNSLaboral, clmIR, clmTotalDeducciones, clmSalarioNeto, clmINATEC, clmINNSPatronal, clmVacaciones, clmTreceavoMes });
            dvgNomina.Location = new Point(12, 251);
            dvgNomina.Name = "dvgNomina";
            dvgNomina.ReadOnly = true;
            dvgNomina.RowHeadersWidth = 51;
            dvgNomina.Size = new Size(1426, 324);
            dvgNomina.TabIndex = 2;
            // 
            // clmNoINNS
            // 
            clmNoINNS.HeaderText = "No. INNS";
            clmNoINNS.MinimumWidth = 6;
            clmNoINNS.Name = "clmNoINNS";
            clmNoINNS.ReadOnly = true;
            clmNoINNS.Width = 125;
            // 
            // clmNombre
            // 
            clmNombre.HeaderText = "Nombre";
            clmNombre.MinimumWidth = 6;
            clmNombre.Name = "clmNombre";
            clmNombre.ReadOnly = true;
            clmNombre.Width = 125;
            // 
            // clmDepartamento
            // 
            clmDepartamento.HeaderText = "Departamento";
            clmDepartamento.MinimumWidth = 6;
            clmDepartamento.Name = "clmDepartamento";
            clmDepartamento.ReadOnly = true;
            clmDepartamento.Width = 125;
            // 
            // clmSalarioMensual
            // 
            clmSalarioMensual.HeaderText = "Salario Mensual";
            clmSalarioMensual.MinimumWidth = 6;
            clmSalarioMensual.Name = "clmSalarioMensual";
            clmSalarioMensual.ReadOnly = true;
            clmSalarioMensual.Width = 125;
            // 
            // clmSalarioQuincenal
            // 
            clmSalarioQuincenal.HeaderText = "Salario Quincenal";
            clmSalarioQuincenal.MinimumWidth = 6;
            clmSalarioQuincenal.Name = "clmSalarioQuincenal";
            clmSalarioQuincenal.ReadOnly = true;
            clmSalarioQuincenal.Width = 125;
            // 
            // clmSalarioSemanal
            // 
            clmSalarioSemanal.HeaderText = "Salario Semanal";
            clmSalarioSemanal.MinimumWidth = 6;
            clmSalarioSemanal.Name = "clmSalarioSemanal";
            clmSalarioSemanal.ReadOnly = true;
            clmSalarioSemanal.Width = 125;
            // 
            // clmHorasExtras
            // 
            clmHorasExtras.HeaderText = "Horas Extras";
            clmHorasExtras.MinimumWidth = 6;
            clmHorasExtras.Name = "clmHorasExtras";
            clmHorasExtras.ReadOnly = true;
            clmHorasExtras.Width = 125;
            // 
            // clmIngresoPorHora
            // 
            clmIngresoPorHora.HeaderText = "Ingreso por hora";
            clmIngresoPorHora.MinimumWidth = 6;
            clmIngresoPorHora.Name = "clmIngresoPorHora";
            clmIngresoPorHora.ReadOnly = true;
            clmIngresoPorHora.Width = 125;
            // 
            // clmAntigüedad
            // 
            clmAntigüedad.HeaderText = "Antigüedad";
            clmAntigüedad.MinimumWidth = 6;
            clmAntigüedad.Name = "clmAntigüedad";
            clmAntigüedad.ReadOnly = true;
            clmAntigüedad.Width = 125;
            // 
            // clmTotalIngresos
            // 
            clmTotalIngresos.HeaderText = "Total de Ingresos";
            clmTotalIngresos.MinimumWidth = 6;
            clmTotalIngresos.Name = "clmTotalIngresos";
            clmTotalIngresos.ReadOnly = true;
            clmTotalIngresos.Width = 125;
            // 
            // clmINNSLaboral
            // 
            clmINNSLaboral.HeaderText = "INNS Laboral";
            clmINNSLaboral.MinimumWidth = 6;
            clmINNSLaboral.Name = "clmINNSLaboral";
            clmINNSLaboral.ReadOnly = true;
            clmINNSLaboral.Width = 125;
            // 
            // clmIR
            // 
            clmIR.HeaderText = "IR";
            clmIR.MinimumWidth = 6;
            clmIR.Name = "clmIR";
            clmIR.ReadOnly = true;
            clmIR.Width = 125;
            // 
            // clmTotalDeducciones
            // 
            clmTotalDeducciones.HeaderText = "Total Deducciones";
            clmTotalDeducciones.MinimumWidth = 6;
            clmTotalDeducciones.Name = "clmTotalDeducciones";
            clmTotalDeducciones.ReadOnly = true;
            clmTotalDeducciones.Width = 125;
            // 
            // clmSalarioNeto
            // 
            clmSalarioNeto.HeaderText = "Salario Neto";
            clmSalarioNeto.MinimumWidth = 6;
            clmSalarioNeto.Name = "clmSalarioNeto";
            clmSalarioNeto.ReadOnly = true;
            clmSalarioNeto.Width = 125;
            // 
            // clmINATEC
            // 
            clmINATEC.HeaderText = "INATEC";
            clmINATEC.MinimumWidth = 6;
            clmINATEC.Name = "clmINATEC";
            clmINATEC.ReadOnly = true;
            clmINATEC.Width = 125;
            // 
            // clmINNSPatronal
            // 
            clmINNSPatronal.HeaderText = "INNS Patronal";
            clmINNSPatronal.MinimumWidth = 6;
            clmINNSPatronal.Name = "clmINNSPatronal";
            clmINNSPatronal.ReadOnly = true;
            clmINNSPatronal.Width = 125;
            // 
            // clmVacaciones
            // 
            clmVacaciones.HeaderText = "Vacaciones";
            clmVacaciones.MinimumWidth = 6;
            clmVacaciones.Name = "clmVacaciones";
            clmVacaciones.ReadOnly = true;
            clmVacaciones.Width = 125;
            // 
            // clmTreceavoMes
            // 
            clmTreceavoMes.HeaderText = "Treceavo mes";
            clmTreceavoMes.MinimumWidth = 6;
            clmTreceavoMes.Name = "clmTreceavoMes";
            clmTreceavoMes.ReadOnly = true;
            clmTreceavoMes.Width = 125;
            // 
            // btnCalcular
            // 
            btnCalcular.Anchor = AnchorStyles.None;
            btnCalcular.BackColor = SystemColors.ControlLight;
            btnCalcular.FlatAppearance.BorderSize = 0;
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Font = new Font("Cambria", 16.2F, FontStyle.Bold);
            btnCalcular.Location = new Point(73, 606);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(225, 90);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.None;
            btnEliminar.BackColor = SystemColors.ControlLight;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Cambria", 16.2F, FontStyle.Bold);
            btnEliminar.Location = new Point(423, 606);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(225, 90);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.None;
            btnGuardar.BackColor = SystemColors.ControlLight;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Cambria", 16.2F, FontStyle.Bold);
            btnGuardar.Location = new Point(780, 606);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(225, 90);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCargar
            // 
            btnCargar.Anchor = AnchorStyles.None;
            btnCargar.BackColor = SystemColors.ControlLight;
            btnCargar.FlatAppearance.BorderSize = 0;
            btnCargar.FlatStyle = FlatStyle.Flat;
            btnCargar.Font = new Font("Cambria", 16.2F, FontStyle.Bold);
            btnCargar.Location = new Point(1144, 606);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(225, 90);
            btnCargar.TabIndex = 7;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = false;
            btnCargar.Click += btnCargar_Click;
            // 
            // FormNomina
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1450, 725);
            Controls.Add(btnCargar);
            Controls.Add(btnGuardar);
            Controls.Add(btnEliminar);
            Controls.Add(btnCalcular);
            Controls.Add(dvgNomina);
            Controls.Add(grpDatos);
            Name = "FormNomina";
            Text = "FormNomina";
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvgNomina).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDatos;
        private Label label1;
        private PictureBox pictureBox1;
        private MaskedTextBox mtbAntigüedad;
        private MaskedTextBox mtbHorasExtra;
        private TextBox txtSalario;
        private Label label6;
        private Label label5;
        private Label label4;
        private ComboBox cmbDepartamento;
        private MaskedTextBox mtbNoINNS;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox5;
        private TextBox txtNombre;
        private PictureBox pictureBox6;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private DataGridView dvgNomina;
        private DataGridViewTextBoxColumn clmNoINNS;
        private DataGridViewTextBoxColumn clmNombre;
        private DataGridViewTextBoxColumn clmDepartamento;
        private DataGridViewTextBoxColumn clmSalarioMensual;
        private DataGridViewTextBoxColumn clmSalarioQuincenal;
        private DataGridViewTextBoxColumn clmSalarioSemanal;
        private DataGridViewTextBoxColumn clmHorasExtras;
        private DataGridViewTextBoxColumn clmIngresoPorHora;
        private DataGridViewTextBoxColumn clmAntigüedad;
        private DataGridViewTextBoxColumn clmTotalIngresos;
        private DataGridViewTextBoxColumn clmINNSLaboral;
        private DataGridViewTextBoxColumn clmIR;
        private DataGridViewTextBoxColumn clmTotalDeducciones;
        private DataGridViewTextBoxColumn clmSalarioNeto;
        private DataGridViewTextBoxColumn clmINATEC;
        private DataGridViewTextBoxColumn clmINNSPatronal;
        private DataGridViewTextBoxColumn clmVacaciones;
        private DataGridViewTextBoxColumn clmTreceavoMes;
        private Button btnCalcular;
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnCargar;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
    }
}