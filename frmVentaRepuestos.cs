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
        struct Repuesto
        {
            public char marca; //P , R, F
            public char origen; // I, N
            public int numeroRepuesto;
            public string descripcion;
            public float precio;
        }

        Repuesto[] vecRepuestos = new Repuesto[100];
        int cantidad = 0;


        public frmVentaRepuestos()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (cantidad >= 100)
            {
                MessageBox.Show("No se pueden cargar más de 100 repuestos.");
                return;
            }

           
            if (cboMarca.SelectedIndex == -1 || cboOrigen.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar marca y origen.");
                return;
            }

            if (!int.TryParse(txtNumero.Text, out int numero) || txtNumero.Text.Length > 6)
            {
                MessageBox.Show("Número inválido (máximo 6 dígitos).");
                return;
            }

            for (int i = 0; i < cantidad; i++)
            {
                if (vecRepuestos[i].numeroRepuesto == numero)
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

            Repuesto r;
            r.marca = cboMarca.SelectedItem.ToString()[0];   // P, F o R
            r.origen = cboOrigen.SelectedItem.ToString()[0]; // N o I
            r.numeroRepuesto = numero;
            r.descripcion = txtDescripcion.Text;
            r.precio = precio;

            vecRepuestos[cantidad] = r;   // se guarda en el arreglo
            cantidad++;                   // suma 1 al contador
        }
    }
}


