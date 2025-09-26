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
            cboMarca.Location = new Point(106, 23);
            cboMarca.Name = "cboMarca";
            cboMarca.Size = new Size(201, 23);
            cboMarca.TabIndex = 0;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(22, 26);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(40, 15);
            lblMarca.TabIndex = 1;
            lblMarca.Text = "Marca";
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Location = new Point(22, 81);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(43, 15);
            lblOrigen.TabIndex = 2;
            lblOrigen.Text = "Origen";
            // 
            // cboOrigen
            // 
            cboOrigen.DropDownStyle = ComboBoxStyle.DropDownList;
            cboOrigen.FormattingEnabled = true;
            cboOrigen.Items.AddRange(new object[] { "N", "I" });
            cboOrigen.Location = new Point(106, 78);
            cboOrigen.Name = "cboOrigen";
            cboOrigen.Size = new Size(201, 23);
            cboOrigen.TabIndex = 3;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(22, 135);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(51, 15);
            lblNumero.TabIndex = 4;
            lblNumero.Text = "Número";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(106, 132);
            txtNumero.Mask = "999999";
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(201, 23);
            txtNumero.TabIndex = 5;
            txtNumero.ValidatingType = typeof(int);
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(22, 188);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(69, 15);
            lblDescripcion.TabIndex = 6;
            lblDescripcion.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(106, 185);
            txtDescripcion.MaxLength = 50;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(201, 23);
            txtDescripcion.TabIndex = 7;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(25, 244);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 8;
            lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(106, 241);
            txtPrecio.Mask = "$999999999";
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(201, 23);
            txtPrecio.TabIndex = 9;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(226, 299);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(81, 23);
            btnCargar.TabIndex = 10;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(139, 299);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(81, 23);
            btnConsultar.TabIndex = 11;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            // 
            // frmVentaRepuestos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 346);
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