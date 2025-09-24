namespace pryBaldovinoSP3ExR
{
    partial class frmVentaRepuestos
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
            comboBox1 = new ComboBox();
            lblMarca = new Label();
            lblOrigen = new Label();
            cboOrigen = new ComboBox();
            lblNumero = new Label();
            txtNumero = new MaskedTextBox();
            lblDescripcion = new Label();
            textBox1 = new TextBox();
            lblPrecio = new Label();
            txtPrecio = new MaskedTextBox();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "P", "F", "R" });
            comboBox1.Location = new Point(186, 37);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(201, 23);
            comboBox1.TabIndex = 0;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(37, 40);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(105, 15);
            lblMarca.TabIndex = 1;
            lblMarca.Text = "Marca de repuesto";
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Location = new Point(37, 100);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(108, 15);
            lblOrigen.TabIndex = 2;
            lblOrigen.Text = "Origen de repuesto";
            // 
            // cboOrigen
            // 
            cboOrigen.FormattingEnabled = true;
            cboOrigen.Items.AddRange(new object[] { "N", "I" });
            cboOrigen.Location = new Point(186, 92);
            cboOrigen.Name = "cboOrigen";
            cboOrigen.Size = new Size(201, 23);
            cboOrigen.TabIndex = 3;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(37, 154);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(116, 15);
            lblNumero.TabIndex = 4;
            lblNumero.Text = "Número de repuesto";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(186, 146);
            txtNumero.Mask = "999999";
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(201, 23);
            txtNumero.TabIndex = 5;
            txtNumero.ValidatingType = typeof(int);
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(37, 205);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(137, 15);
            lblDescripcion.TabIndex = 6;
            lblDescripcion.Text = "Descripción del repuesto";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(186, 202);
            textBox1.MaxLength = 50;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(201, 23);
            textBox1.TabIndex = 7;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(37, 261);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(108, 15);
            lblPrecio.TabIndex = 8;
            lblPrecio.Text = "Precio del repuesto";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(186, 258);
            txtPrecio.Mask = "$999999999";
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(201, 23);
            txtPrecio.TabIndex = 9;
            // 
            // frmVentaRepuestos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 400);
            Controls.Add(txtPrecio);
            Controls.Add(lblPrecio);
            Controls.Add(textBox1);
            Controls.Add(lblDescripcion);
            Controls.Add(txtNumero);
            Controls.Add(lblNumero);
            Controls.Add(cboOrigen);
            Controls.Add(lblOrigen);
            Controls.Add(lblMarca);
            Controls.Add(comboBox1);
            Name = "frmVentaRepuestos";
            Text = "Carga de Repuestos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label lblMarca;
        private Label lblOrigen;
        private ComboBox cboOrigen;
        private Label lblNumero;
        private MaskedTextBox txtNumero;
        private Label lblDescripcion;
        private TextBox textBox1;
        private Label lblPrecio;
        private MaskedTextBox txtPrecio;
    }
}