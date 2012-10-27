using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacturasCeylan
{
    class Articulo
    {
        float precio;
        String Nombre;
        //String Codigo;
        int cantidad;
        String tipo;
      
        //A Singleton 
        Articulo(String Nombre, float precio, int cantidad,String tipo)
        {
            this.Nombre = Nombre;
            
            this.cantidad = cantidad;
            this.precio = precio * cantidad;
            this.tipo = tipo;
        }

        
    }
}
