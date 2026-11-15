namespace CombustiPlus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cmbCombustible.Items.AddRange(new object[] { "Premium", "Regular", "Gasoil" });
            cmbPago.Items.AddRange(new object[] { "Efectivo", "Tarjeta" });
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
        private bool DatosValidos()
        {
            if (txtPlaca.Text.Length != 7)
            {
                MessageBox.Show("La placa debe tener 7 caracteres para psar.\nUn Ejemplo: ZX12345", "Placa inválida esta mal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (nudGalones.Value <= 0)
            {
                MessageBox.Show("Los galones deben ser más de 0.", "Galones inválidos esta mal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnCotizar_Click_1(object sender, EventArgs e)
        {
            if (!DatosValidos()) return;
        }

        private void btnDespachar_Click_1(object sender, EventArgs e)
        {
            if (!DatosValidos()) return;
        }
    }
}
