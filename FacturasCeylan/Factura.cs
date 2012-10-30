using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibPrintTicket;
using System.Drawing;
using System.Windows.Forms;
namespace FacturasCeylan
{
    class Factura
    {
        Cliente cliente;
        List<Articulo> arts;
        int folio = 20656;
        float Total=0;
        float Subtotal=0;
        float Iva=0;
        public Factura(Cliente c, List<Articulo> a)
        {
            this.cliente = c;
            this.arts = a;
            
        }
        private void getFolio()
        {
            BD bd = new BD();
            List<String[]> rs =bd.Execute("SELECT Folio FROM factura ORDER BY Folio ASC");
            if (rs.Count != 0)
            {
                foreach (String[] data in rs)
                {
                    folio = Convert.ToInt32(data[0]);
                    folio++;
                }
            }
        }
        public void pushFactura()
        {
            BD bd = new BD();
            getFolio();
            foreach (Articulo aux in arts)
            {
                bd.ExecuteNonQuery("INSERT INTO articulo VALUES(NULL, '" + aux.nombre + "','" + aux.cantidad.ToString() + "','" + aux.precio.ToString() + "','" + aux.tipo + "',"+folio+");");
            }
            
            bd.ExecuteNonQuery("INSERT INTO factura VALUES(" + folio + ",'" + cliente.rfc + "','" + DateTime.Today.ToString("yyyy-MM-dd") + "')");
            this.printFact();
        }
        public void printFact()
        {
            Image img = Image.FromFile("C:\\CBB.jpg");            
            Ticket ticket = new Ticket();
            ticket.HeaderImage = img;
            ticket.AddHeaderLine("         FERRETERIA CEYLAN");
            ticket.AddHeaderLine("");
            ticket.AddHeaderLine("EXPEDIDO POR:");
            ticket.AddHeaderLine("LUIS ANTONIO MAYEN RIOS");
            ticket.AddHeaderLine("RFC: MARL-730815-A83");
            ticket.AddHeaderLine("AV.CEYLAN #1133 COL. INDUSTRIAL VALLEJO");
            ticket.AddHeaderLine("CP 02300 AZCAPOTZALCO MEXICO DF");
            ticket.AddHeaderLine("");
            ticket.AddHeaderLine("FACTURADO A :");
            ticket.AddHeaderLine("");
            ticket.AddHeaderLine(cliente.nombre);
            ticket.AddHeaderLine(cliente.rfc);
            ticket.AddHeaderLine("Calle: " + cliente.calle);
            ticket.AddHeaderLine("Col.: " + cliente.colonia);
            ticket.AddHeaderLine("Numero: " + cliente.numero + " Int: " + cliente.numint);
            ticket.AddHeaderLine("CP: " + cliente.codigopostal + "  " + cliente.delegmunip + " " + cliente.estado);
            ticket.AddSubHeaderLine("FACTURA # "+folio);
            ticket.AddSubHeaderLine(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString());
            //NECESITAMOS CONFIGURARLO AQUI PARA Q SOLO IMPRIMA LA FECHA DE LA FACTURA
            foreach (Articulo aux in arts)
            {
                ticket.AddItem(aux.cantidad.ToString() + " " + aux.tipo, aux.nombre, (aux.precio/1.16).ToString("C2"));
                Subtotal += aux.precio;
            }
            Total = Subtotal;
            Subtotal = Subtotal / 1.16f;            
            Iva = Total - Subtotal;
            ticket.AddTotal("SUBTOTAL", Subtotal.ToString("C2"));
            ticket.AddTotal("IVA", Iva.ToString("C2"));
            ticket.AddTotal("TOTAL", Total.ToString("C2"));
            NumLetra tot = new NumLetra();
            ticket.AddTotal("", "");
            //MessageBox.Show(Total.ToString("F2"));
            ticket.AddFooterLine(tot.Convertir(Total.ToString("F2"), true));
            ticket.AddFooterLine("EFECTOS FISCALES AL PAGO");
            ticket.AddFooterLine("PAGO EN EFECTIVO");
            ticket.AddFooterLine("");
            ticket.AddFooterLine("PAGO EN UNA SOLA EXHIBICION ");
            ticket.AddFooterLine("");            
            ticket.AddFooterLine("Régimen Fiscal: Régimen de las personas Físicas con Actividades Empresariales y Profesionales");
            ticket.AddFooterLine("");          
            ticket.AddFooterLine("NUMERO APROBACION SICOFI: 23260721");
            ticket.AddFooterLine("");          
            ticket.AddFooterLine("La reproducción apócrifa de este comprobante constituye un delito en los términos de las disposiciones fiscales Este comprobante tendrá una vigencia de dos años contados a partir de la fecha de aprobación de la asignación de folios, la cual es: 20001-22000 el día 02/05/2012");
            ticket.PrintTicket("EC Printer EC-80320");
        }
    }
}
