using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacturasCeylan
{
    class Articulo
    {
        decimal precio;
        String Nombre;
        //String Codigo;
        int cantidad;
        String tipo;
        private string p;
        private decimal p_2;
        private int p_3;
        private string p_4;
      
        //A Singleton 
        public Articulo(String Nombre, decimal precio, int cantidad,String tipo)
        {
            this.Nombre = Nombre;
            
            this.cantidad = cantidad;
            this.precio = precio * cantidad;
            this.tipo = tipo;
        }        
    }
}
