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
            cboMarca = new ComboBox();
            lblMarca = new Label();
            lblOrigen = new Label();
            cboOrigen = new ComboBox();
            lblNumero = new Label();
            txtNumero = new MaskedTextBox();
            lblDescripcion = new Label();
            txtDescripcion = new TextBox();
            lblPrecio = new Label();
            txtPrecio = new MaskedTextBox();
            btnCargar = new Button();
            btnConsultar = new Button();
            SuspendLayout();
            // 
            // cboMarca
            // 
            cboMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMarca.FormattingEnabled = true;
            cboMarca.Items.AddRange(new object[] { "P", "F", "R" });
            cboMarca.Location = new Point(121, 31);
            cboMarca.Margin = new Padding(3, 4, 3, 4);
            cboMarca.Name = "cboMarca";
            cboMarca.Size = new Size(229, 28);
            cboMarca.TabIndex = 0;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(25, 35);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(50, 20);
            lblMarca.TabIndex = 1;
            lblMarca.Text = "Marca";
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Location = new Point(25, 108);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(54, 20);
            lblOrigen.TabIndex = 2;
            lblOrigen.Text = "Origen";
            // 
            // cboOrigen
            // 
            cboOrigen.DropDownStyle = ComboBoxStyle.DropDownList;
            cboOrigen.FormattingEnabled = true;
            cboOrigen.Items.AddRange(new object[] { "N", "I" });
            cboOrigen.Location = new Point(121, 104);
            cboOrigen.Margin = new Padding(3, 4, 3, 4);
            cboOrigen.Name = "cboOrigen";
            cboOrigen.Size = new Size(229, 28);
            cboOrigen.TabIndex = 3;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(25, 180);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(63, 20);
            lblNumero.TabIndex = 4;
            lblNumero.Text = "Número";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(121, 176);
            txtNumero.Margin = new Padding(3, 4, 3, 4);
            txtNumero.Mask = "999999";
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(229, 27);
            txtNumero.TabIndex = 5;
            txtNumero.ValidatingType = typeof(int);
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(25, 251);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(87, 20);
            lblDescripcion.TabIndex = 6;
            lblDescripcion.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(121, 247);
            txtDescripcion.Margin = new Padding(3, 4, 3, 4);
            txtDescripcion.MaxLength = 50;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(229, 27);
            txtDescripcion.TabIndex = 7;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(29, 325);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(50, 20);
            lblPrecio.TabIndex = 8;
            lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(121, 321);
            txtPrecio.Margin = new Padding(3, 4, 3, 4);
            txtPrecio.Mask = "$999999999";
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(229, 27);
            txtPrecio.TabIndex = 9;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(258, 399);
            btnCargar.Margin = new Padding(3, 4, 3, 4);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(93, 31);
            btnCargar.TabIndex = 10;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(159, 399);
            btnConsultar.Margin = new Padding(3, 4, 3, 4);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(93, 31);
            btnConsultar.TabIndex = 11;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            // 
            // frmVentaRepuestos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 461);
            Controls.Add(btnConsultar);
            Controls.Add(btnCargar);
            Controls.Add(txtPrecio);
            Controls.Add(lblPrecio);
            Controls.Add(txtDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(txtNumero);
            Controls.Add(lblNumero);
            Controls.Add(cboOrigen);
            Controls.Add(lblOrigen);
            Controls.Add(lblMarca);
            Controls.Add(cboMarca);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmVentaRepuestos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Carga de Repuestos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboMarca;
        private Label lblMarca;
        private Label lblOrigen;
        private ComboBox cboOrigen;
        private Label lblNumero;
        private MaskedTextBox txtNumero;
        private Label lblDescripcion;
        private TextBox txtDescripcion;
        private Label lblPrecio;
        private MaskedTextBox txtPrecio;
        private Button btnCargar;
        private Button btnConsultar;
    }
}