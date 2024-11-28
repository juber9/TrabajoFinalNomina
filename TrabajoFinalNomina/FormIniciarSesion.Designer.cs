namespace Canal10
{
    partial class FormIniciarSesion
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
            button3 = new Button();
            label5 = new Label();
            btnInciarSesion = new Button();
            checkBox1 = new CheckBox();
            this.txtContraseña = new TextBox();
            label3 = new Label();
            txtUsuario = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(48, 56, 79);
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(116, 86, 171);
            button3.Location = new Point(455, 339);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(159, 31);
            button3.TabIndex = 23;
            button3.Text = "Back to Register";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8F);
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(455, 317);
            label5.Name = "label5";
            label5.Size = new Size(169, 19);
            label5.TabIndex = 22;
            label5.Text = "Do you wan t an account?";
            // 
            // btnInciarSesion
            // 
            btnInciarSesion.BackColor = Color.FromArgb(116, 86, 171);
            btnInciarSesion.Cursor = Cursors.Hand;
            btnInciarSesion.FlatAppearance.BorderSize = 0;
            btnInciarSesion.FlatStyle = FlatStyle.Flat;
            btnInciarSesion.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInciarSesion.ForeColor = Color.White;
            btnInciarSesion.Location = new Point(406, 131);
            btnInciarSesion.Margin = new Padding(3, 4, 3, 4);
            btnInciarSesion.Name = "btnInciarSesion";
            btnInciarSesion.Size = new Size(241, 49);
            btnInciarSesion.TabIndex = 20;
            btnInciarSesion.Text = "LOG IN";
            btnInciarSesion.UseVisualStyleBackColor = false;
            btnInciarSesion.Click += LogIn;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Cursor = Cursors.Hand;
            checkBox1.ForeColor = Color.Transparent;
            checkBox1.Location = new Point(200, 285);
            checkBox1.Margin = new Padding(3, 4, 3, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(132, 24);
            checkBox1.TabIndex = 19;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = Color.FromArgb(230, 231, 233);
            this.txtContraseña.Location = new Point(37, 247);
            this.txtContraseña.Margin = new Padding(3, 4, 3, 4);
            this.txtContraseña.Multiline = true;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new Size(286, 29);
            this.txtContraseña.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Snow;
            label3.Location = new Point(37, 215);
            label3.Name = "label3";
            label3.Size = new Size(93, 28);
            label3.TabIndex = 15;
            label3.Text = "Password";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(230, 231, 233);
            txtUsuario.Location = new Point(37, 163);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.Multiline = true;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(286, 29);
            txtUsuario.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(37, 131);
            label2.Name = "label2";
            label2.Size = new Size(99, 28);
            label2.TabIndex = 13;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(37, 89);
            label1.Name = "label1";
            label1.Size = new Size(103, 40);
            label1.TabIndex = 12;
            label1.Text = "Log In";
            // 
            // FormIniciarSesion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 56, 79);
            ClientSize = new Size(685, 460);
            Controls.Add(button3);
            Controls.Add(label5);
            Controls.Add(btnInciarSesion);
            Controls.Add(checkBox1);
            Controls.Add(this.txtContraseña);
            Controls.Add(label3);
            Controls.Add(txtUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormIniciarSesion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Label label5;
        private Button button2;
        private Button btnInciarSesion;
        private CheckBox checkBox1;
        private TextBox txtContraseña;
        private TextBox textBox2;
        private Label label3;
        private TextBox txtUsuario;
        private Label label2;
        private Label label1;
    }
}