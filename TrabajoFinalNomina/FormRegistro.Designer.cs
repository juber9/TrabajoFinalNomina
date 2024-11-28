namespace Canal10
{
    partial class FormRegistro
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
            label1 = new Label();
            label2 = new Label();
            txtUsuario = new TextBox();
            label3 = new Label();
            txtContraseña = new TextBox();
            txtConfirmarContraseña = new TextBox();
            label4 = new Label();
            checkBox1 = new CheckBox();
            btnRegistro = new Button();
            label5 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(40, 53);
            label1.Name = "label1";
            label1.Size = new Size(161, 40);
            label1.TabIndex = 0;
            label1.Text = "Get Stared";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(40, 93);
            label2.Name = "label2";
            label2.Size = new Size(99, 28);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(230, 231, 233);
            txtUsuario.Location = new Point(40, 125);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.Multiline = true;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(286, 29);
            txtUsuario.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Snow;
            label3.Location = new Point(40, 177);
            label3.Name = "label3";
            label3.Size = new Size(93, 28);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = Color.FromArgb(230, 231, 233);
            txtContraseña.Location = new Point(40, 209);
            txtContraseña.Margin = new Padding(3, 4, 3, 4);
            txtContraseña.Multiline = true;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(286, 29);
            txtContraseña.TabIndex = 4;
            // 
            // txtConfirmarContraseña
            // 
            txtConfirmarContraseña.BackColor = Color.FromArgb(230, 231, 233);
            txtConfirmarContraseña.Location = new Point(40, 301);
            txtConfirmarContraseña.Margin = new Padding(3, 4, 3, 4);
            txtConfirmarContraseña.Multiline = true;
            txtConfirmarContraseña.Name = "txtConfirmarContraseña";
            txtConfirmarContraseña.Size = new Size(286, 29);
            txtConfirmarContraseña.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Snow;
            label4.Location = new Point(40, 269);
            label4.Name = "label4";
            label4.Size = new Size(168, 28);
            label4.TabIndex = 5;
            label4.Text = "Confirm Password";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Cursor = Cursors.Hand;
            checkBox1.ForeColor = Color.Transparent;
            checkBox1.Location = new Point(203, 340);
            checkBox1.Margin = new Padding(3, 4, 3, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(132, 24);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnRegistro
            // 
            btnRegistro.BackColor = Color.FromArgb(116, 86, 171);
            btnRegistro.Cursor = Cursors.Hand;
            btnRegistro.FlatAppearance.BorderSize = 0;
            btnRegistro.FlatStyle = FlatStyle.Flat;
            btnRegistro.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistro.ForeColor = Color.White;
            btnRegistro.Location = new Point(409, 93);
            btnRegistro.Margin = new Padding(3, 4, 3, 4);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(241, 49);
            btnRegistro.TabIndex = 8;
            btnRegistro.Text = "REGISTER";
            btnRegistro.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8F);
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(458, 280);
            label5.Name = "label5";
            label5.Size = new Size(169, 19);
            label5.TabIndex = 10;
            label5.Text = "Already Have an Account?";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(48, 56, 79);
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(116, 86, 171);
            button3.Location = new Point(458, 301);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(159, 31);
            button3.TabIndex = 11;
            button3.Text = "Go to LOGIN";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // FormRegistro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 56, 79);
            ClientSize = new Size(685, 460);
            Controls.Add(button3);
            Controls.Add(label5);
            Controls.Add(btnRegistro);
            Controls.Add(checkBox1);
            Controls.Add(txtConfirmarContraseña);
            Controls.Add(label4);
            Controls.Add(txtContraseña);
            Controls.Add(label3);
            Controls.Add(txtUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormRegistro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsuario;
        private Label label3;
        private TextBox txtContraseña;
        private TextBox txtConfirmarContraseña;
        private Label label4;
        private CheckBox checkBox1;
        private Button btnRegistro;
        private Label label5;
        private Button button3;
    }
}