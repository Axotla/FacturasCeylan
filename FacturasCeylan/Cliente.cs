using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FacturasCeylan
{
    class Cliente
    {
        String RFC;
        public String rfc
        {
            get
            {
                return RFC;
            }
        }
        String Nombre;
        public String nombre{
            get
            {
                return Nombre;
            }
        }
        String Direccion;
        public String direccion
        {
            get
            {
                return Direccion;
            }
        }
        String correo;
        String Telefono;
        //CONSTRUCTURES
        //--------------
        public Cliente(String RFC, String Nombre, String Direccion, String correo, String Telefono)
        {
            this.RFC = RFC;
            this.Nombre = Nombre;
            this.Direccion = Direccion;
            this.correo = correo;
            this.Telefono = Telefono;
        }
        //ESTE DE MOMENTO QUEDA ANULADO YA QUE SERA PARA UN POSTERIORI 
        
        public Cliente(String RFC)
        {
            if (searchCliente(RFC))
                MessageBox.Show("CLIENTE ENCONTRADO");
            else
                MessageBox.Show("NO EXISTE EL CLIENTE");
        }
        public Cliente() { }
        
        //FUNCIONES DE BUSQUEDA DE CLIENTE
        public bool searchCliente(String RFC)
        {
            BD bd = new BD();
            List<String[]> data;
            data = bd.Execute("SELECT * FROM cliente WHERE RFC = '" + RFC + "';");
            foreach (String[] cad in data)
            {
                this.RFC = cad[0];
                this.Nombre = cad[1];
                this.Direccion = cad[2];
                this.correo = cad[3];
                this.Telefono = cad[4];
            }
            if (String.IsNullOrEmpty(this.RFC)) 
                return false;
            return true;

        }
        public bool creaCliente(String RFC, String Nombre, String Direccion, String correo, String Telefono)
        {
            BD bd = new BD();
            if (bd.ExecuteNonQuery("INSERT INTO cliente VALUES ('" + RFC + "','" + Nombre + "','" + Direccion + "','" + correo + "','" + Telefono + "');"))
            {
                MessageBox.Show("CLIENTE DADO DE ALTA CORRECTAMENTE");
                this.RFC = RFC;
                this.Nombre = Nombre;
                this.Direccion = Direccion;
                this.Telefono = Telefono;
                this.correo = correo;
                return true;
            }
            else
            {
                MessageBox.Show("CLIENTE NO DADO DE ALTA CONSULTE AL ADMIN");
                return false;
            }
        }


        internal bool searchCliente(TextBox RFC)
        {
            throw new NotImplementedException();
        }
    }
    
}
