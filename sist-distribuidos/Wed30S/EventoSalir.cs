namespace EventosTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormClosing += confirmClosing;
        }

        private void confirmClosing(object sender, FormClosingEventArgs e)
        {
            label1.Text = "Adios :(";
            var quiereSalir = MessageBox.Show("Confirma", "queres salir", MessageBoxButtons.OKCancel);

            if (quiereSalir  == DialogResult.Cancel)
            {
                // cancel the closure of the form.
                e.Cancel = true;
            }

        }
    }
}
