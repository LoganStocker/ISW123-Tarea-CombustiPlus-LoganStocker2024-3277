namespace CombustiPlus
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            lstDespachos = new ListBox();
            txtPlaca = new TextBox();
            cmbPago = new ComboBox();
            nudGalones = new NumericUpDown();
            cmbCombustible = new ComboBox();
            btnDespachar = new Button();
            btnCotizar = new Button();
            groupBox2 = new GroupBox();
            lstDetalle = new ListBox();
            btnPorCombustible = new Button();
            lblResumen = new Label();
            groupBox3 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudGalones).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lstDespachos);
            groupBox1.Location = new Point(312, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(846, 205);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Despachos del día";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // lstDespachos
            // 
            lstDespachos.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstDespachos.FormattingEnabled = true;
            lstDespachos.Location = new Point(15, 28);
            lstDespachos.Name = "lstDespachos";
            lstDespachos.Size = new Size(831, 224);
            lstDespachos.TabIndex = 1;
            lstDespachos.SelectedIndexChanged += lstDespachos_SelectedIndexChanged;
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(90, 64);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(152, 27);
            txtPlaca.TabIndex = 0;
            // 
            // cmbPago
            // 
            cmbPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPago.FormattingEnabled = true;
            cmbPago.Location = new Point(92, 177);
            cmbPago.Name = "cmbPago";
            cmbPago.Size = new Size(151, 28);
            cmbPago.TabIndex = 1;
            // 
            // nudGalones
            // 
            nudGalones.DecimalPlaces = 1;
            nudGalones.Location = new Point(93, 138);
            nudGalones.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudGalones.Name = "nudGalones";
            nudGalones.Size = new Size(150, 27);
            nudGalones.TabIndex = 2;
            // 
            // cmbCombustible
            // 
            cmbCombustible.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCombustible.FormattingEnabled = true;
            cmbCombustible.Location = new Point(108, 100);
            cmbCombustible.Name = "cmbCombustible";
            cmbCombustible.Size = new Size(151, 28);
            cmbCombustible.TabIndex = 3;
            cmbCombustible.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // btnDespachar
            // 
            btnDespachar.Location = new Point(121, 223);
            btnDespachar.Name = "btnDespachar";
            btnDespachar.Size = new Size(94, 29);
            btnDespachar.TabIndex = 4;
            btnDespachar.Text = "Despachar";
            btnDespachar.UseVisualStyleBackColor = true;
            btnDespachar.Click += btnDespachar_Click_1;
            // 
            // btnCotizar
            // 
            btnCotizar.Location = new Point(6, 223);
            btnCotizar.Name = "btnCotizar";
            btnCotizar.Size = new Size(94, 29);
            btnCotizar.TabIndex = 5;
            btnCotizar.Text = "Cotizar";
            btnCotizar.UseVisualStyleBackColor = true;
            btnCotizar.Click += btnCotizar_Click_1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lstDetalle);
            groupBox2.Location = new Point(22, 313);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(557, 290);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detalle";
            // 
            // lstDetalle
            // 
            lstDetalle.Font = new Font("Consolas", 10.2F);
            lstDetalle.FormattingEnabled = true;
            lstDetalle.Location = new Point(6, 26);
            lstDetalle.Name = "lstDetalle";
            lstDetalle.Size = new Size(545, 224);
            lstDetalle.TabIndex = 0;
            lstDetalle.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btnPorCombustible
            // 
            btnPorCombustible.Location = new Point(600, 284);
            btnPorCombustible.Name = "btnPorCombustible";
            btnPorCombustible.Size = new Size(245, 29);
            btnPorCombustible.TabIndex = 7;
            btnPorCombustible.Text = "Galones por combustible";
            btnPorCombustible.UseVisualStyleBackColor = true;
            btnPorCombustible.Click += btnPorCombustible_Click;
            // 
            // lblResumen
            // 
            lblResumen.AutoSize = true;
            lblResumen.Location = new Point(600, 316);
            lblResumen.Name = "lblResumen";
            lblResumen.Size = new Size(12, 20);
            lblResumen.TabIndex = 8;
            lblResumen.Text = ".";
            lblResumen.Click += lblResumen_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(cmbCombustible);
            groupBox3.Controls.Add(nudGalones);
            groupBox3.Controls.Add(cmbPago);
            groupBox3.Controls.Add(txtPlaca);
            groupBox3.Controls.Add(btnDespachar);
            groupBox3.Controls.Add(btnCotizar);
            groupBox3.Location = new Point(12, 32);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(306, 275);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Nuevo Despacho";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 185);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 12;
            label5.Text = "Pago:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 145);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 11;
            label4.Text = "Galones:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 108);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 10;
            label3.Text = "Combustible:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 64);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 9;
            label2.Text = "Placa:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 677);
            Controls.Add(groupBox3);
            Controls.Add(lblResumen);
            Controls.Add(btnPorCombustible);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "CombustiPlus - Estación Bávaro";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudGalones).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtPlaca;
        private ComboBox cmbPago;
        private NumericUpDown nudGalones;
        private ComboBox cmbCombustible;
        private Button btnDespachar;
        private Button btnCotizar;
        private GroupBox groupBox2;
        private ListBox lstDetalle;
        private ListBox lstDespachos;
        private Button btnPorCombustible;
        private Label lblResumen;
        private GroupBox groupBox3;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}
