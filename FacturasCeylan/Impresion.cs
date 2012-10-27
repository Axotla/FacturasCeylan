using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LibPrintTicket;
namespace FacturasCeylan
{
    public partial class Impresion : Form
    {
        public Impresion()
        {
            InitializeComponent();
        }

        private void Folio_TextChanged(object sender, EventArgs e)
        {
            //Aqui aplica para validar el cambio de texto
        }

        private void Imprime_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile("C:\\CBB.jpg");
            
            //VALIDAR Q EL FOLIO SEA UN NUMERO Y ADEMAS EXISTA EN LA BD
            Ticket ticket = new Ticket();
            ticket.HeaderImage = img;
            ticket.AddHeaderLine("FERRETERIA CEYLAN");
            ticket.AddHeaderLine("EXPEDIDO POR:");
            ticket.AddHeaderLine("LUIS ANTONIO MAYEN RIOS");
            ticket.AddHeaderLine("RFC: MARL-730815-A83");
            ticket.AddHeaderLine("Av Ceylan #1133 Col. Industrial VallejoSDAJSKDSLKKDSHKDHSASAJDSJHADKJSDSKJADHDSJSKJDSHADHAKJD CP 02300 Azcapotzalco Mexico DF");

            ticket.AddSubHeaderLine("FACTURA # 1");
            ticket.AddSubHeaderLine(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString());
            //NECESITAMOS CONFIGURARLO AQUI PARA Q SOLO IMPRIMA LA FECHA DE LA FACTURA
            ticket.AddItem("1", "Nombre producto que vamos a vender esta largo", "Total");

            ticket.AddTotal("SUBTOTAL", "12.00");
            ticket.AddTotal("IVA", "0");
            ticket.AddTotal("TOTAL", "24");
            ticket.AddTotal("", "");
            ticket.AddTotal("RECIBIDO", "0");
            ticket.AddTotal("CAMBIO", "0");
            ticket.AddTotal("", "");

            ticket.AddFooterLine("VUELVA PRONTO");
            
            ticket.PrintTicket("HP LaserJet Professional P1102w"); //Nombre de la impresora de tickets
        }
    }
}
