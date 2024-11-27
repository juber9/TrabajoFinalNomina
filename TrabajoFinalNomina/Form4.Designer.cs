namespace Canal10
{
    partial class Form4
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
            label4 = new Label();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            button2 = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(116, 86, 171);
            label4.Location = new Point(59, 18);
            label4.Name = "label4";
            label4.Size = new Size(117, 37);
            label4.TabIndex = 6;
            label4.Text = "NominOS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(116, 86, 171);
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(55, 47);
            label1.TabIndex = 7;
            label1.Text = "㊂";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(116, 86, 171);
            button1.Location = new Point(114, 112);
            button1.Name = "button1";
            button1.Size = new Size(85, 97);
            button1.TabIndex = 9;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(75, 76);
            label2.Name = "label2";
            label2.Size = new Size(153, 21);
            label2.TabIndex = 10;
            label2.Text = "Start a new project";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLight;
            label3.Location = new Point(114, 212);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 11;
            label3.Text = "Blank document";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLight;
            label5.Location = new Point(386, 76);
            label5.Name = "label5";
            label5.Size = new Size(127, 21);
            label5.TabIndex = 12;
            label5.Text = "Recent projects";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(48, 56, 90);
            panel1.Location = new Point(386, 112);
            panel1.Name = "panel1";
            panel1.Size = new Size(364, 263);
            panel1.TabIndex = 13;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(116, 86, 171);
            button2.Location = new Point(691, 25);
            button2.Name = "button2";
            button2.Size = new Size(117, 30);
            button2.TabIndex = 14;
            button2.Text = "Log Out";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 56, 79);
            ClientSize = new Size(833, 451);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label1;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Panel panel1;
        private Button button2;
    }
}