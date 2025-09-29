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

        Repuesto[] vecRespuestos = new Repuesto[100];
        int indice = 0;


        public frmVentaRepuestos()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {

        }
    }
}
        

