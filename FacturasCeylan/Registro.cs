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
            if (!(String.IsNullOrEmpty(RNameCliente.Text) || String.IsNullOrEmpty(RRFC.Text) || String.IsNullOrEmpty(RDomici.Text)))
            {
                Cliente nuevo = new Cliente();
                ///ESTE METODO SOLO ENTRA CUANDO NO ESTAN VACIOS LOS 3 CAMPOS ANTERIORES
                if (!nuevo.searchCliente(RRFC.Text))
                {
                    nuevo.creaCliente(RRFC.Text, RNameCliente.Text, RDomici.Text, REmail.Text, RPhone.Text);
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
