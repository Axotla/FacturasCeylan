using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacturasCeylan
{
    class Factura
    {
        Cliente cliente;
        List<Articulo> arts;
        public Factura(Cliente c, List<Articulo> a)
        {
            this.cliente = c;
            this.arts = a;
        }
        public void pushFactura()
        {
            BD bd = new BD();
            foreach (Articulo aux in arts)
            {
                bd.ExecuteNonQuery("INSERT INTO articulo VALUES(NULL, '" + aux.nombre + "','" + aux.cantidad.ToString() + "','" + aux.precio.ToString() + "','" + aux.tipo + "');");
            }
        }
    }
}
