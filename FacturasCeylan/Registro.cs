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
    public partial class Registro : Form
    {
        
        string RFC;
        public Registro()
        {
            InitializeComponent();
        }
        public Registro(string rfc)
        {
            RFC = rfc;
            InitializeComponent();
            RRFC.Text = RFC;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(RNameCliente.Text) || String.IsNullOrEmpty(RRFC.Text) || String.IsNullOrEmpty(RCalle.Text) || String.IsNullOrEmpty(RColonia.Text) || String.IsNullOrEmpty(RNumero.Text) || String.IsNullOrEmpty(RCPostal.Text) || String.IsNullOrEmpty(RMunip.Text) || String.IsNullOrEmpty(REstado.Text)))
            {
                Cliente nuevo = new Cliente();
                if (!nuevo.searchCliente(RRFC.Text))
                {
                    nuevo.creaCliente(RRFC.Text, RNameCliente.Text, RColonia.Text,RCalle.Text,RNumero.Text,RNumeroInt.Text,Convert.ToInt32(RCPostal.Text),RMunip.Text,REstado.Text, REmail.Text, RPhone.Text);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("CLIENTE YA EXISTE");
                }
                
            }
        }
    }
}
