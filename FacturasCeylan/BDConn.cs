using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
namespace FacturasCeylan
{
    class BD
    {
         //Atributos
        //String Server = "127.0.0.1";
        //String Database = "test";
        //String Uid = "root";
        //String Pwd = "Markox";
        bool status = false;
        MySqlConnection con;
        /* -------------------------------*/
        public BD()
        {
            status = BDConn();           
        }
        private bool BDConn(){
            con = new MySqlConnection();
            String cad;
            try
            {
                cad = "Server=127.0.0.1; Database=factura;Uid=root; Pwd=Markox;";
                con.ConnectionString = cad;
                con.Open();
                //MessageBox.Show("CONECTADO CON LA BD");
				
                return true;
            }
            catch (MySqlException)
            {
                MessageBox.Show("ERROR AL CONECTAR CON LA BD");
				
                return false;
            }
        }

        public List<String[]> Execute(String Query)
        {
            if (!status)
                return null;
            MySqlCommand query = con.CreateCommand();
            query.CommandText = Query;
            MySqlDataReader reader = query.ExecuteReader();
            List<String[]> ResultSet = new List<string[]>();
            while (reader.Read())
            {
                String[] fila = new String[reader.VisibleFieldCount];
                for (int i = 0; i < reader.VisibleFieldCount; i++)
                {
                    fila[i] = reader.GetValue(i).ToString();
                }
                ResultSet.Add(fila);
            }
            return ResultSet;

        }
        public bool ExecuteNonQuery(String Query)
        {
            if (!status)
                return false;
            MySqlCommand query = con.CreateCommand();
            query.CommandText = Query;
            //MessageBox.Show(Query); podemos observar q ocurre con la query
            if (query.ExecuteNonQuery() == -1)//ERROR 
                return false;
            else
                return true;           
        }



    }
}
