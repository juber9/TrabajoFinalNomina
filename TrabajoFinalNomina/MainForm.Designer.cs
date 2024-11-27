namespace TrabajoFinalNomina
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panelLeft = new Panel();
            btnSalir = new Button();
            panelTipoNomina = new Panel();
            btnSemanal = new Button();
            btnQuincenal = new Button();
            btnMensual = new Button();
            btnTipoNomina = new Button();
            btnExpandir = new Button();
            tabPrincipal = new TabControl();
            tabPagePrincipal = new TabPage();
            label3 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tabMensual = new TabPage();
            panelMensual = new Panel();
            tabQuincenal = new TabPage();
            panelQuincenal = new Panel();
            tabSemanal = new TabPage();
            panelSemanal = new Panel();
            tabResumen = new TabPage();
            panelResumen = new Panel();
            panelLeft.SuspendLayout();
            panelTipoNomina.SuspendLayout();
            tabPrincipal.SuspendLayout();
            tabPagePrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabMensual.SuspendLayout();
            tabQuincenal.SuspendLayout();
            tabSemanal.SuspendLayout();
            tabResumen.SuspendLayout();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(23, 24, 29);
            panelLeft.Controls.Add(btnSalir);
            panelLeft.Controls.Add(panelTipoNomina);
            panelLeft.Controls.Add(btnTipoNomina);
            panelLeft.Controls.Add(btnExpandir);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(250, 819);
            panelLeft.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.Dock = DockStyle.Top;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Cambria", 12F, FontStyle.Bold);
            btnSalir.ForeColor = Color.White;
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalir.Location = new Point(0, 381);
            btnSalir.Name = "btnSalir";
            btnSalir.Padding = new Padding(17, 0, 0, 0);
            btnSalir.Size = new Size(250, 79);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // panelTipoNomina
            // 
            panelTipoNomina.BackColor = Color.FromArgb(32, 33, 36);
            panelTipoNomina.Controls.Add(btnSemanal);
            panelTipoNomina.Controls.Add(btnQuincenal);
            panelTipoNomina.Controls.Add(btnMensual);
            panelTipoNomina.Dock = DockStyle.Top;
            panelTipoNomina.Location = new Point(0, 132);
            panelTipoNomina.Name = "panelTipoNomina";
            panelTipoNomina.Size = new Size(250, 249);
            panelTipoNomina.TabIndex = 3;
            panelTipoNomina.Visible = false;
            // 
            // btnSemanal
            // 
            btnSemanal.Dock = DockStyle.Top;
            btnSemanal.FlatAppearance.BorderSize = 0;
            btnSemanal.FlatStyle = FlatStyle.Flat;
            btnSemanal.Font = new Font("Cambria", 12F, FontStyle.Bold);
            btnSemanal.ForeColor = Color.White;
            btnSemanal.Image = (Image)resources.GetObject("btnSemanal.Image");
            btnSemanal.ImageAlign = ContentAlignment.MiddleLeft;
            btnSemanal.Location = new Point(0, 158);
            btnSemanal.Name = "btnSemanal";
            btnSemanal.Padding = new Padding(20, 0, 0, 0);
            btnSemanal.Size = new Size(250, 79);
            btnSemanal.TabIndex = 3;
            btnSemanal.Text = "Semanal";
            btnSemanal.UseVisualStyleBackColor = true;
            btnSemanal.Click += btnSemanal_Click;
            // 
            // btnQuincenal
            // 
            btnQuincenal.Dock = DockStyle.Top;
            btnQuincenal.FlatAppearance.BorderSize = 0;
            btnQuincenal.FlatStyle = FlatStyle.Flat;
            btnQuincenal.Font = new Font("Cambria", 12F, FontStyle.Bold);
            btnQuincenal.ForeColor = Color.White;
            btnQuincenal.Image = (Image)resources.GetObject("btnQuincenal.Image");
            btnQuincenal.ImageAlign = ContentAlignment.MiddleLeft;
            btnQuincenal.Location = new Point(0, 79);
            btnQuincenal.Name = "btnQuincenal";
            btnQuincenal.Padding = new Padding(20, 0, 0, 0);
            btnQuincenal.Size = new Size(250, 79);
            btnQuincenal.TabIndex = 2;
            btnQuincenal.Text = "Quincenal";
            btnQuincenal.UseVisualStyleBackColor = true;
            btnQuincenal.Click += btnQuincenal_Click;
            // 
            // btnMensual
            // 
            btnMensual.Dock = DockStyle.Top;
            btnMensual.FlatAppearance.BorderSize = 0;
            btnMensual.FlatStyle = FlatStyle.Flat;
            btnMensual.Font = new Font("Cambria", 12F, FontStyle.Bold);
            btnMensual.ForeColor = Color.White;
            btnMensual.Image = (Image)resources.GetObject("btnMensual.Image");
            btnMensual.ImageAlign = ContentAlignment.MiddleLeft;
            btnMensual.Location = new Point(0, 0);
            btnMensual.Name = "btnMensual";
            btnMensual.Padding = new Padding(20, 0, 0, 0);
            btnMensual.Size = new Size(250, 79);
            btnMensual.TabIndex = 1;
            btnMensual.Text = "Mensual";
            btnMensual.UseVisualStyleBackColor = true;
            btnMensual.Click += btnMensual_Click;
            // 
            // btnTipoNomina
            // 
            btnTipoNomina.Dock = DockStyle.Top;
            btnTipoNomina.FlatAppearance.BorderSize = 0;
            btnTipoNomina.FlatStyle = FlatStyle.Flat;
            btnTipoNomina.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTipoNomina.ForeColor = Color.White;
            btnTipoNomina.Image = (Image)resources.GetObject("btnTipoNomina.Image");
            btnTipoNomina.ImageAlign = ContentAlignment.MiddleLeft;
            btnTipoNomina.Location = new Point(0, 53);
            btnTipoNomina.Name = "btnTipoNomina";
            btnTipoNomina.Padding = new Padding(15, 0, 0, 0);
            btnTipoNomina.Size = new Size(250, 79);
            btnTipoNomina.TabIndex = 2;
            btnTipoNomina.Text = "  Tipo de Nómina";
            btnTipoNomina.UseVisualStyleBackColor = true;
            btnTipoNomina.Click += DesplegarTipoNomina;
            // 
            // btnExpandir
            // 
            btnExpandir.Dock = DockStyle.Top;
            btnExpandir.Font = new Font("Cambria", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExpandir.Location = new Point(0, 0);
            btnExpandir.Name = "btnExpandir";
            btnExpandir.Size = new Size(250, 53);
            btnExpandir.TabIndex = 0;
            btnExpandir.Text = "≡";
            btnExpandir.UseVisualStyleBackColor = true;
            btnExpandir.Click += btnExpandir_Click;
            // 
            // tabPrincipal
            // 
            tabPrincipal.Controls.Add(tabPagePrincipal);
            tabPrincipal.Controls.Add(tabMensual);
            tabPrincipal.Controls.Add(tabQuincenal);
            tabPrincipal.Controls.Add(tabSemanal);
            tabPrincipal.Controls.Add(tabResumen);
            tabPrincipal.Dock = DockStyle.Fill;
            tabPrincipal.Location = new Point(250, 0);
            tabPrincipal.Name = "tabPrincipal";
            tabPrincipal.SelectedIndex = 0;
            tabPrincipal.Size = new Size(1468, 819);
            tabPrincipal.TabIndex = 5;
            // 
            // tabPagePrincipal
            // 
            tabPagePrincipal.Controls.Add(label3);
            tabPagePrincipal.Controls.Add(label1);
            tabPagePrincipal.Controls.Add(pictureBox1);
            tabPagePrincipal.Location = new Point(4, 29);
            tabPagePrincipal.Name = "tabPagePrincipal";
            tabPagePrincipal.Padding = new Padding(3);
            tabPagePrincipal.Size = new Size(1460, 786);
            tabPagePrincipal.TabIndex = 0;
            tabPagePrincipal.Text = "Principal";
            tabPagePrincipal.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.Font = new Font("Cambria", 12F, FontStyle.Bold);
            label3.Location = new Point(116, 453);
            label3.Name = "label3";
            label3.Size = new Size(479, 51);
            label3.TabIndex = 7;
            label3.Text = "!Seleccione una de las opciones del panel izquierdo para comenzar¡";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("Cambria", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(101, 74);
            label1.Name = "label1";
            label1.Size = new Size(581, 388);
            label1.TabIndex = 1;
            label1.Text = "!BIENVENIDO AL SISTEMA DE CÁLULO DE NÓMINA¡";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(710, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(682, 548);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tabMensual
            // 
            tabMensual.Controls.Add(panelMensual);
            tabMensual.Location = new Point(4, 29);
            tabMensual.Name = "tabMensual";
            tabMensual.Padding = new Padding(3);
            tabMensual.Size = new Size(1460, 786);
            tabMensual.TabIndex = 1;
            tabMensual.Text = "Mensual";
            tabMensual.UseVisualStyleBackColor = true;
            // 
            // panelMensual
            // 
            panelMensual.Dock = DockStyle.Fill;
            panelMensual.Location = new Point(3, 3);
            panelMensual.Name = "panelMensual";
            panelMensual.Size = new Size(1454, 780);
            panelMensual.TabIndex = 0;
            // 
            // tabQuincenal
            // 
            tabQuincenal.Controls.Add(panelQuincenal);
            tabQuincenal.Location = new Point(4, 29);
            tabQuincenal.Name = "tabQuincenal";
            tabQuincenal.Size = new Size(1460, 786);
            tabQuincenal.TabIndex = 2;
            tabQuincenal.Text = "Quincenal";
            tabQuincenal.UseVisualStyleBackColor = true;
            // 
            // panelQuincenal
            // 
            panelQuincenal.Dock = DockStyle.Fill;
            panelQuincenal.Location = new Point(0, 0);
            panelQuincenal.Name = "panelQuincenal";
            panelQuincenal.Size = new Size(1460, 786);
            panelQuincenal.TabIndex = 0;
            // 
            // tabSemanal
            // 
            tabSemanal.Controls.Add(panelSemanal);
            tabSemanal.Location = new Point(4, 29);
            tabSemanal.Name = "tabSemanal";
            tabSemanal.Size = new Size(1460, 786);
            tabSemanal.TabIndex = 3;
            tabSemanal.Text = "Semanal";
            tabSemanal.UseVisualStyleBackColor = true;
            // 
            // panelSemanal
            // 
            panelSemanal.Dock = DockStyle.Fill;
            panelSemanal.Location = new Point(0, 0);
            panelSemanal.Name = "panelSemanal";
            panelSemanal.Size = new Size(1460, 786);
            panelSemanal.TabIndex = 0;
            // 
            // tabResumen
            // 
            tabResumen.Controls.Add(panelResumen);
            tabResumen.Location = new Point(4, 29);
            tabResumen.Name = "tabResumen";
            tabResumen.Padding = new Padding(3);
            tabResumen.Size = new Size(1460, 786);
            tabResumen.TabIndex = 4;
            tabResumen.Text = "Resumen";
            tabResumen.UseVisualStyleBackColor = true;
            // 
            // panelResumen
            // 
            panelResumen.Dock = DockStyle.Fill;
            panelResumen.Location = new Point(3, 3);
            panelResumen.Name = "panelResumen";
            panelResumen.Size = new Size(1454, 780);
            panelResumen.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1718, 819);
            Controls.Add(tabPrincipal);
            Controls.Add(panelLeft);
            Name = "MainForm";
            Text = "Nominas";
            panelLeft.ResumeLayout(false);
            panelTipoNomina.ResumeLayout(false);
            tabPrincipal.ResumeLayout(false);
            tabPagePrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabMensual.ResumeLayout(false);
            tabQuincenal.ResumeLayout(false);
            tabSemanal.ResumeLayout(false);
            tabResumen.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLeft;
        private Button btnTipoNomina;
        private Button btnExpandir;
        private Button btnSalir;
        private Panel panelTipoNomina;
        private Button btnSemanal;
        private Button btnQuincenal;
        private Button btnMensual;
        private TabControl tabPrincipal;
        private TabPage tabPagePrincipal;
        private Label label3;
        private Label label1;
        private PictureBox pictureBox1;
        private TabPage tabMensual;
        private Panel panelMensual;
        private TabPage tabQuincenal;
        private Panel panelQuincenal;
        private TabPage tabSemanal;
        private Panel panelSemanal;
        private TabPage tabResumen;
        private Panel panelResumen;
    }
}