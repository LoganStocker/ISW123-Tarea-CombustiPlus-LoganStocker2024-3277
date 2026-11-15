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

        public decimal PrecioPorGalon(string combustible) => combustible switch
        {
            "Premium" => 290m,
            "Regular" => 272m,
            "Gasoil" => 225m,
            _ => 0m
        };

        public decimal CalcularTotal()
        {
            decimal galones = nudGalones.Value;
            decimal precio = PrecioPorGalon(cmbCombustible.Text);
            decimal total = galones * precio;

            lstDetalle.Items.Clear();
            lstDetalle.Items.Add($"{galones:0.0} galxRD$ {precio:N2} = RD$ {total:N2}");

            if (galones >= 20)
            {
                total = total * 0.98m;
                lstDetalle.Items.Add($"Descuento 20+galones -2%: RD$ {total:N2}");
            }

            if (cmbPago.Text == "Tarjeta")
            {
                total = total * 1.03m;
                lstDetalle.Items.Add($"Tarjeta+3%: RD$ {total:N2}");
            }

            lstDetalle.Items.Add($"TOTAL: RD$ {total:N2}");
            return total;
        }

        private void ActualizarResumen()
        {
            decimal vendido = 0;
            decimal galones = 0;
            Despacho mayor = despachos[0];

            foreach (Despacho d in despachos)
            {
                vendido += d.Total;
                galones += d.Galones;
                if (d.Total > mayor.Total) mayor = d;
            }

            lblResumen.Text = $"{despachos.Count} despachos - Vendido RD$ {vendido:N2} - Galones {galones:0.0} - Mayor: #{mayor.Numero:00} {mayor.Placa} (RD$ {mayor.Total:N2})";
        }

        public List<Despacho> despachos = new List<Despacho>();

        private void btnCotizar_Click_1(object sender, EventArgs e)
        {
            if (!DatosValidos()) return;
            CalcularTotal();

        }

        private void btnDespachar_Click_1(object sender, EventArgs e)
        {
            if (!DatosValidos()) return;

            Despacho des = new Despacho();
            des.Numero = despachos.Count + 1;
            des.Placa = txtPlaca.Text;
            des.Combustible = cmbCombustible.Text;
            des.Galones = nudGalones.Value;
            des.Pago = cmbPago.Text;
            des.Total = CalcularTotal();
            despachos.Add(des);

            lstDespachos.Items.Add(des);
            ActualizarResumen();

        }

        private void btnPorCombustible_Click(object sender, EventArgs e)
        {
            Dictionary<string, decimal> galonesPorCombustible = new Dictionary<string, decimal>();

            foreach (Despacho des in despachos)
            {
                if (galonesPorCombustible.ContainsKey(des.Combustible))
                    galonesPorCombustible[des.Combustible] += des.Galones;
                else
                    galonesPorCombustible[des.Combustible] = des.Galones;
            }

            string linea = "";
            foreach (var par in galonesPorCombustible)
                linea += $"{par.Key} {par.Value:0.0} - ";

            lstDetalle.Items.Clear();
            lstDetalle.Items.Add(linea.TrimEnd(' ', '-'));
        }
    }
}
