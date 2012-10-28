using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//CODIGO PARA RESTAURAR BASE DE DATOS mysql -u root -p -A <dumpfile.SQLa
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
            AListadoArt.ColumnCount = 4;
            AListadoArt.ColumnHeadersVisible = true;
            AListadoArt.Columns[0].Name = "CANTIDAD";
            AListadoArt.Columns[1].Name = "NOMBRE";
            AListadoArt.Columns[2].Name = "UNITARIO";
            AListadoArt.Columns[3].Name = "IMPORTE";
            
        }
        private void search_Click(object sender, EventArgs e)
        {
            cliente = new Cliente();
            if (cliente.searchCliente(RFCdata.Text))
            {
                //AQUI CARGO EL CLIENTE
                RFCLabel.Text = cliente.rfc;   
                ClienteLabel.Text = cliente.nombre;
                ColLabel.Text = cliente.colonia;
                CalleLabel.Text = cliente.calle;
                NumLabel.Text = cliente.numero;
                NumIntLabel.Text = cliente.numint;
                CPLabel.Text = cliente.codigopostal.ToString();
                DelMunLabel.Text = cliente.delegmunip;
                EstadoLabel.Text = cliente.estado;
                EmailLabel.Text = cliente.correo;
                TelLabel.Text = cliente.telefono;                            
            }
            else
            {
                cliente = null;
                RFCLabel.Text = "---";
                ClienteLabel.Text = "---";
                ColLabel.Text = "---";
                CalleLabel.Text = "---";
                NumLabel.Text = "---";
                NumIntLabel.Text = "---";
                CPLabel.Text = "---";
                DelMunLabel.Text = "---";
                EstadoLabel.Text = "---";
                EmailLabel.Text = "---";
                TelLabel.Text = "---";
                MessageBox.Show("CLIENTE NO EXISTE");
                Registro reg = new Registro(RFCdata.Text);
                reg.Show();
            }
            
        }

        private void AAdd_Click(object sender, EventArgs e)
        {
            if ((!String.IsNullOrEmpty(AArtName.Text)) && (!String.IsNullOrEmpty(AType.Text)))
            {
                articulos.Add(new Articulo(AArtName.Text, APrecio.Value, Convert.ToInt32(ACant.Value), AType.Text));              
                AListadoArt.Rows.Add(Convert.ToInt32(ACant.Value),AArtName.Text, APrecio.Value,  APrecio.Value * ACant.Value);
            }
        }

        private void FACTURAR_Click(object sender, EventArgs e)
        {
            if (articulos.Count != 0 && cliente != null)
            {
                Factura nuevo = new Factura(cliente, articulos);
                nuevo.pushFactura();
            }
            else
            {
                MessageBox.Show("ERROR FALTA CLIENTE O ARTICULOS");
            }
        }
    }
}