using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ejercicio_60
{
    public class SQLConection
    {        
        SqlConnection conexion;
        SqlCommand comando;

        /// <summary>
        /// inicializa una coneccion con una base de datos sql
        /// </summary>
        /// <param name="instanciaServidor">la instancia del servidor LAB3PC08\SQLEXPRESS</param>
        /// <param name="nombreBase">nombre de la base de datos  AdventureWorks2012</param>
        public SQLConection(string instanciaServidor, string nombreBase)
        {
            string connectionStr = "Data Source=" + instanciaServidor + ";Initial Catalog =" + nombreBase + "; Integrated Security = True";
            conexion = new SqlConnection(connectionStr);
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
        }

        public List<Producto> Mostrar()
        {
            comando.CommandText = "SELECT ProductID,Name,ProductNumber FROM TablaGGT2";
            conexion.Open();

            SqlDataReader oDr = comando.ExecuteReader();

            List<Producto> productos = new List<Producto>();

            while(oDr.Read())
            {
                Producto prod = new Producto(oDr["Name"].ToString(), oDr["ProductNumber"].ToString(), oDr["ProductID"].ToString());
                productos.Add(prod);
            }

            conexion.Close();
            return productos;
        }


        public bool Agregar(Producto p)
        {

            comando.CommandText = "INSERT INTO TablaGGT2 (Name,ProductNumber) VALUES ('" + p.Nombre + "' , '" + p.ProductNumber + "');";
            conexion.Open();
            comando.ExecuteNonQuery();


            conexion.Close();
            return true;

        }   

        public void Borrar(Producto p)
        {
            comando.CommandText = "DELETE FROM TablaGGT2 WHERE ProductID = '" + p.Id + "'";
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
