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
    }
}
