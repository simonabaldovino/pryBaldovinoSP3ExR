using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryBaldovinoSP3ExR
{
    public partial class frmVentaRepuestos : Form
    {

        void CargarDatos()
        {
            matRepuestos[0, 0] = "P"; matRepuestos[0, 1] = "N"; matRepuestos[0, 2] = "123456"; matRepuestos[0, 3] = "Filtro de aire"; matRepuestos[0, 4] = "4500.50";
            matRepuestos[1, 0] = "F"; matRepuestos[1, 1] = "I"; matRepuestos[1, 2] = "654321"; matRepuestos[1, 3] = "Pastillas de freno"; matRepuestos[1, 4] = "8200.00";
            matRepuestos[2, 0] = "R"; matRepuestos[2, 1] = "N"; matRepuestos[2, 2] = "111111"; matRepuestos[2, 3] = "Bujía estándar"; matRepuestos[2, 4] = "1200.75";
            matRepuestos[3, 0] = "P"; matRepuestos[3, 1] = "I"; matRepuestos[3, 2] = "222222"; matRepuestos[3, 3] = "Aceite sintético"; matRepuestos[3, 4] = "9500.00";
            filaActual = 4;
        }

        struct Repuesto
        {
            public char marca; //P , R, F
            public char origen; // I, N
            public int numeroRepuesto;
            public string descripcion;
            public float precio;
        }

        string[,] matRepuestos = new string[100, 5];
        int filaActual = 0;

  
        public frmVentaRepuestos()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
  
            if (filaActual >= 100)
            {
                MessageBox.Show("No se pueden cargar más de 100 repuestos.");
                return;
            }

            if (cboMarca.SelectedIndex == -1 || cboOrigen.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar marca y origen.");
                return;
            }

            string numero = txtNumero.Text.Trim();
            if (numero.Length == 0 || numero.Length > 6)
            {
                MessageBox.Show("Número inválido (máximo 6 dígitos).");
                return;
            }

            // Verifica duplicado
            for (int i = 0; i < filaActual; i++)
            {
                if (matRepuestos[i, 2] == numero)
                {
                    MessageBox.Show("Ya existe un repuesto con ese número.");
                    return;
                }
            }

            if (txtDescripcion.Text.Length == 0 || txtDescripcion.Text.Length > 50)
            {
                MessageBox.Show("Descripción inválida.");
                return;
            }

            if (!float.TryParse(txtPrecio.Text, out float precio))
            {
                MessageBox.Show("Precio inválido.");
                return;
            }

            // Carga en la matriz
            matRepuestos[filaActual, 0] = cboMarca.SelectedItem.ToString().Substring(0, 1);
            matRepuestos[filaActual, 1] = cboOrigen.SelectedItem.ToString().Substring(0, 1);
            matRepuestos[filaActual, 2] = numero;
            matRepuestos[filaActual, 3] = txtDescripcion.Text;
            matRepuestos[filaActual, 4] = precio.ToString("0.00");

            filaActual++;

            MessageBox.Show("Repuesto cargado correctamente.");
        }

        private void frmVentaRepuestos_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (cboMarcaC.SelectedIndex == -1 || (optNacional.Checked && !optImportado.Checked))
            {
                MessageBox.Show("Debe seleccionar una marca y un origen para consultar.");
                return;
            }

            string marca = cboMarcaC.SelectedItem.ToString().Substring(0, 1);
            string origen = optNacional.Checked ? "N" : "I";

            txtDatos.Clear();
            txtDatos.AppendText("N° Repuesto\tDescripción\t\tPrecio\r\n");
            txtDatos.AppendText("----------------------------------------------------------\r\n");

            bool hayDatos = false;
            for (int i = 0; i < filaActual; i++)
            {
                if (matRepuestos[i, 0] == marca && matRepuestos[i, 1] == origen)
                {
                    txtDatos.AppendText($"{matRepuestos[i, 2]}\t{matRepuestos[i, 3]}\t\t${matRepuestos[i, 4]}\r\n");
                    hayDatos = true;
                }
            }

            if (!hayDatos)
                MessageBox.Show("No se encontraron repuestos con esos filtros.");
        }

        private void lblOrigenC_Click(object sender, EventArgs e)
        {

        }
    }
}


