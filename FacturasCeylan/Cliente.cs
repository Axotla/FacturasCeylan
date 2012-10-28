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
        public String rfc { get { return RFC; } }
        String Nombre;
        public String nombre { get { return Nombre; } }
        String Colonia;
        public String colonia { get { return Colonia; } }
        String Calle;
        public String calle { get { return Calle; } }
        String Numero;
        public String numero { get { return Numero; } }
        String NumInt;
        public String numint { get { return NumInt; } }
        int CodigoPostal;
        public int codigopostal { get { return CodigoPostal; } }
        String DelegMunip;
        public String delegmunip { get { return DelegMunip; } }
        String Estado;
        public String estado { get { return Estado; } }
        String Correo;
        public String correo { get { return Correo; } }
        String Telefono;
        public String telefono { get { return Telefono; } }
        //CONSTRUCTURES
        //--------------
   
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
                this.Colonia = cad[2];
                this.Calle = cad[3];
                this.Numero = cad[4];
                this.NumInt = cad[5];
                this.CodigoPostal =Convert.ToInt32(cad[6]);
                this.DelegMunip = cad[7];
                this.Estado = cad[8];
                this.Correo = cad[9];
                this.Telefono = cad[10];
            }
            if (String.IsNullOrEmpty(this.RFC)) 
                return false;
            return true;

        }
        public bool creaCliente(String RFC, String Nombre, String Colonia, String Calle,String Numero, String NumeroInt, int CodigoPostal, String DelegMunip, String Estado, String Correo, String Telefono)
        {
            BD bd = new BD();
            if (bd.ExecuteNonQuery("INSERT INTO cliente VALUES ('" + RFC + "','" + Nombre + "','" + Colonia + "','" + Calle + "','" + Numero + "','" + NumeroInt + "','" + CodigoPostal + "','" + DelegMunip + "','" + Estado + "','" + Telefono + "','" + Correo + "');"))
            {
                MessageBox.Show("CLIENTE DADO DE ALTA CORRECTAMENTE");
                this.RFC = RFC;
                this.Nombre = Nombre;
                this.Colonia = Colonia;
                this.Calle = Calle;
                this.Numero = Numero;
                this.NumInt = NumeroInt;
                this.CodigoPostal = CodigoPostal;
                this.DelegMunip = DelegMunip;
                this.Estado = Estado;
                this.Telefono = Telefono;
                this.Correo= Correo;
                return true;
            }
            else
            {
                MessageBox.Show("CLIENTE NO DADO DE ALTA CONSULTE AL ADMIN");
                return false;
            }
        }
    }
    
}
