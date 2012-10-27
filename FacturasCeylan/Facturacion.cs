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
    public partial class Facturacion : Form
    {
        Cliente cliente;
        List<Articulo> articulos = new List<Articulo>();
        //DATOS DE LA FACTURACION 
        public Facturacion()
        {
            InitializeComponent();
        }
        private void search_Click(object sender, EventArgs e)
        {
            cliente = new Cliente();
            if (cliente.searchCliente(RFCdata.Text))
            {
                //AQUI CARGO EL CLIENTE
                ClienteLabel.Text = cliente.nombre;
                DomLabel.Text = cliente.direccion;
                RFCLabel.Text = cliente.rfc;
                Accept.Enabled = true;
                
            }
            else
            {
                ClienteLabel.Text = "NULL";
                DomLabel.Text = "NULL";
                RFCLabel.Text = "NULL";
                Accept.Enabled = false;
                MessageBox.Show("CLIENTE NO EXISTE");
                Registro reg = new Registro(RFCdata.Text);
                reg.Show();
            }
            
        }

        private void AAdd_Click(object sender, EventArgs e)
        {
            if ((!String.IsNullOrEmpty(AArtName.Text)) && (!String.IsNullOrEmpty(AType.Text)))
            {
                articulos.Add(new Articulo(AArtName.Text,APrecio.Value,Convert.ToInt32(ACant.Value),AType.Text));
                MessageBox.Show("AGREAGADO CREO");
            }
        }

        private void FACTURAR_Click(object sender, EventArgs e)
        {
            if (articulos.Count != 0 && cliente != null)
            {
                Factura nuevo = new Factura(cliente, articulos);
            }
            else
            {
                MessageBox.Show("ERROR FALTA CLIENTE O ARTICULOS");
            }
        }
    }
}