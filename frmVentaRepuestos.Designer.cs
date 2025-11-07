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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentaRepuestos));
            cboMarca = new ComboBox();
            lblMarca = new Label();
            lblOrigen = new Label();
            cboOrigen = new ComboBox();
            lblNumero = new Label();
            txtNumero = new MaskedTextBox();
            lblDescripcion = new Label();
            txtDescripcion = new TextBox();
            lblPrecio = new Label();
            btnCargar = new Button();
            btnConsultar = new Button();
            txtPrecio = new TextBox();
            grpCarga = new GroupBox();
            grpConsulta = new GroupBox();
            optImportado = new RadioButton();
            optNacional = new RadioButton();
            lblOrigenC = new Label();
            lblMarcaC = new Label();
            cboMarcaC = new ComboBox();
            dgvDatos = new DataGridView();
            colNRepuesto = new DataGridViewTextBoxColumn();
            colDescripcion = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            grpCarga.SuspendLayout();
            grpConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // cboMarca
            // 
            cboMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMarca.FormattingEnabled = true;
            cboMarca.Items.AddRange(new object[] { "P", "F", "R" });
            cboMarca.Location = new Point(139, 72);
            cboMarca.Margin = new Padding(3, 4, 3, 4);
            cboMarca.Name = "cboMarca";
            cboMarca.Size = new Size(229, 28);
            cboMarca.TabIndex = 0;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(43, 75);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(50, 20);
            lblMarca.TabIndex = 1;
            lblMarca.Text = "Marca";
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Location = new Point(43, 159);
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
            cboOrigen.Location = new Point(139, 156);
            cboOrigen.Margin = new Padding(3, 4, 3, 4);
            cboOrigen.Name = "cboOrigen";
            cboOrigen.Size = new Size(229, 28);
            cboOrigen.TabIndex = 3;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(43, 235);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(63, 20);
            lblNumero.TabIndex = 4;
            lblNumero.Text = "Número";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(139, 235);
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
            lblDescripcion.Location = new Point(43, 318);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(87, 20);
            lblDescripcion.TabIndex = 6;
            lblDescripcion.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(139, 318);
            txtDescripcion.Margin = new Padding(3, 4, 3, 4);
            txtDescripcion.MaxLength = 50;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(229, 27);
            txtDescripcion.TabIndex = 7;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(43, 394);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(50, 20);
            lblPrecio.TabIndex = 8;
            lblPrecio.Text = "Precio";
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(275, 460);
            btnCargar.Margin = new Padding(3, 4, 3, 4);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(93, 31);
            btnCargar.TabIndex = 10;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(263, 209);
            btnConsultar.Margin = new Padding(3, 4, 3, 4);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(93, 31);
            btnConsultar.TabIndex = 11;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(139, 391);
            txtPrecio.Margin = new Padding(3, 4, 3, 4);
            txtPrecio.MaxLength = 50;
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(229, 27);
            txtPrecio.TabIndex = 12;
            // 
            // grpCarga
            // 
            grpCarga.Controls.Add(txtPrecio);
            grpCarga.Controls.Add(btnCargar);
            grpCarga.Controls.Add(lblPrecio);
            grpCarga.Controls.Add(txtDescripcion);
            grpCarga.Controls.Add(lblDescripcion);
            grpCarga.Controls.Add(txtNumero);
            grpCarga.Controls.Add(lblNumero);
            grpCarga.Controls.Add(cboOrigen);
            grpCarga.Controls.Add(lblOrigen);
            grpCarga.Controls.Add(lblMarca);
            grpCarga.Controls.Add(cboMarca);
            grpCarga.Location = new Point(35, 47);
            grpCarga.Name = "grpCarga";
            grpCarga.Size = new Size(394, 514);
            grpCarga.TabIndex = 15;
            grpCarga.TabStop = false;
            grpCarga.Text = "Carga de repuestos";
            // 
            // grpConsulta
            // 
            grpConsulta.Controls.Add(optImportado);
            grpConsulta.Controls.Add(optNacional);
            grpConsulta.Controls.Add(lblOrigenC);
            grpConsulta.Controls.Add(lblMarcaC);
            grpConsulta.Controls.Add(btnConsultar);
            grpConsulta.Controls.Add(cboMarcaC);
            grpConsulta.Location = new Point(471, 47);
            grpConsulta.Name = "grpConsulta";
            grpConsulta.Size = new Size(386, 262);
            grpConsulta.TabIndex = 16;
            grpConsulta.TabStop = false;
            grpConsulta.Text = "Consulta de repuestos";
            // 
            // optImportado
            // 
            optImportado.AutoSize = true;
            optImportado.Location = new Point(240, 155);
            optImportado.Name = "optImportado";
            optImportado.Size = new Size(101, 24);
            optImportado.TabIndex = 16;
            optImportado.TabStop = true;
            optImportado.Text = "Importado";
            optImportado.UseVisualStyleBackColor = true;
            // 
            // optNacional
            // 
            optNacional.AutoSize = true;
            optNacional.Location = new Point(127, 155);
            optNacional.Name = "optNacional";
            optNacional.Size = new Size(89, 24);
            optNacional.TabIndex = 15;
            optNacional.TabStop = true;
            optNacional.Text = "Nacional";
            optNacional.UseVisualStyleBackColor = true;
            // 
            // lblOrigenC
            // 
            lblOrigenC.AutoSize = true;
            lblOrigenC.Location = new Point(31, 155);
            lblOrigenC.Name = "lblOrigenC";
            lblOrigenC.Size = new Size(54, 20);
            lblOrigenC.TabIndex = 13;
            lblOrigenC.Text = "Origen";
            lblOrigenC.Click += lblOrigenC_Click;
            // 
            // lblMarcaC
            // 
            lblMarcaC.AutoSize = true;
            lblMarcaC.Location = new Point(31, 76);
            lblMarcaC.Name = "lblMarcaC";
            lblMarcaC.Size = new Size(50, 20);
            lblMarcaC.TabIndex = 14;
            lblMarcaC.Text = "Marca";
            // 
            // cboMarcaC
            // 
            cboMarcaC.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMarcaC.FormattingEnabled = true;
            cboMarcaC.Items.AddRange(new object[] { "P", "F", "R" });
            cboMarcaC.Location = new Point(127, 72);
            cboMarcaC.Margin = new Padding(3, 4, 3, 4);
            cboMarcaC.Name = "cboMarcaC";
            cboMarcaC.Size = new Size(229, 28);
            cboMarcaC.TabIndex = 13;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.AllowUserToOrderColumns = true;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colNRepuesto, colDescripcion, colPrecio });
            dgvDatos.Location = new Point(471, 336);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowHeadersWidth = 51;
            dgvDatos.Size = new Size(386, 202);
            dgvDatos.TabIndex = 17;
            // 
            // colNRepuesto
            // 
            colNRepuesto.HeaderText = "N de repuesto";
            colNRepuesto.MinimumWidth = 6;
            colNRepuesto.Name = "colNRepuesto";
            colNRepuesto.Width = 125;
            // 
            // colDescripcion
            // 
            colDescripcion.HeaderText = "Descripción";
            colDescripcion.MinimumWidth = 6;
            colDescripcion.Name = "colDescripcion";
            colDescripcion.Width = 125;
            // 
            // colPrecio
            // 
            colPrecio.HeaderText = "Precio";
            colPrecio.MinimumWidth = 6;
            colPrecio.Name = "colPrecio";
            colPrecio.Width = 125;
            // 
            // frmVentaRepuestos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 605);
            Controls.Add(dgvDatos);
            Controls.Add(grpConsulta);
            Controls.Add(grpCarga);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "frmVentaRepuestos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Carga de Repuestos";
            Load += frmVentaRepuestos_Load;
            grpCarga.ResumeLayout(false);
            grpCarga.PerformLayout();
            grpConsulta.ResumeLayout(false);
            grpConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
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
        private Button btnCargar;
        private Button btnConsultar;
        private TextBox txtPrecio;
        private GroupBox grpCarga;
        private GroupBox grpConsulta;
        private Label lblOrigenC;
        private Label lblMarcaC;
        private ComboBox cboMarcaC;
        private RadioButton optNacional;
        private RadioButton optImportado;
        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn colNRepuesto;
        private DataGridViewTextBoxColumn colDescripcion;
        private DataGridViewTextBoxColumn colPrecio;
    }
}