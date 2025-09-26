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
        public frmVentaRepuestos()
        {
            InitializeComponent();
        }

        struct Repuesto
        {
            public char marca; //P , R, F
            public char origen; // I, N
            public int numeroRepuesto;             
            public string descripcion;
            public float precio; 
        }

        Repuesto[] vecRespuestos = new Repuesto[100];
            
            vecRespuestos[0].marca = xxx; 
            vecRespuestos[1].origen= xxx; 
            vecRespuestos[2].numeroRepuesto = xxx;  
            vecRespuestos[3].descripcion = xxx; 
            vecRespuestos[4].precio = xxx; 
       


    private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back))           
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }
    }
}
        

