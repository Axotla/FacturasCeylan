using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FacturasCeylan
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Facturacion factura = new Facturacion();
            factura.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Impresion OldSis = new Impresion();
            OldSis.Show();
        }
    }
}
