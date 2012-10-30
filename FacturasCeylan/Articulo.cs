using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacturasCeylan
{
    class Articulo
    {
        float Precio;
        String Nombre;
        int Cantidad;
        String Tipo;   
        //A Singleton 
        public float precio
        {
            get
            {
                return Precio;
            }
        }
        public String nombre
        {
            get
            {
                return Nombre;
            }
        }
        public int cantidad
        {
            get
            {
                return Cantidad;
            }
        }
        public String tipo
        {
            get
            {
                return Tipo;
            }
        }

        public Articulo(String Nombre, float precio, int cantidad,String tipo)
        {
            this.Nombre = Nombre;
            
            this.Cantidad = cantidad;
            this.Precio = precio * cantidad;
            this.Tipo = tipo;
        }  
    }
}
