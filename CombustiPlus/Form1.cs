namespace CombustiPlus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cmbCombustible.Items.AddRange(new object[] { "Premium", "Regular", "Gasoil" });
            cmbPago.Items.AddRange(new object[] { "Efectivo", "Tarjeta" });

            cmbCombustible.SelectedIndex = 0;
            cmbPago.SelectedIndex = 0;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblResumen_Click(object sender, EventArgs e)
        {

        }
    }
}
