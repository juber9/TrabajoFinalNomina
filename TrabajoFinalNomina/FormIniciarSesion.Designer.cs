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
            button2 = new Button();
            button1 = new Button();
            checkBox1 = new CheckBox();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
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
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(116, 86, 171);
            button2.Location = new Point(406, 207);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(241, 49);
            button2.TabIndex = 21;
            button2.Text = "CLEAR";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(116, 86, 171);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(406, 131);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(241, 49);
            button1.TabIndex = 20;
            button1.Text = "LOG IN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += LogIn;
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
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(230, 231, 233);
            textBox2.Location = new Point(37, 247);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(286, 29);
            textBox2.TabIndex = 16;
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
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(230, 231, 233);
            textBox1.Location = new Point(37, 163);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(286, 29);
            textBox1.TabIndex = 14;
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
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
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
        private Button button1;
        private CheckBox checkBox1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
    }
}