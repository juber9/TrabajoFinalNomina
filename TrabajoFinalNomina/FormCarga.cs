namespace Canal10
{
    public partial class FormCarga : Form
    {
        public FormCarga()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Width += 3;
            if (panel1.Width >= 599)
            {
                timer1.Stop();
                FormRegistro fm2 = new FormRegistro();
                fm2.Show();
                this.Hide();
            }
        }
    }
}
