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
