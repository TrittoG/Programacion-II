using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ejercicio60
{
    public class SqlConexion
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        public SqlConexion()
        {
            string conexionStr = "Data Source=LAB3PC07\\SQLEXPRESS;Initial Catalog=AdventureWorks2012;Integrated Security=True";
            conexion = new SqlConnection(conexionStr);
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
        }

        public List<Producto> Mostrar(string tabla)
        {
            comando.CommandText = "SELECT ProductID,Name,ProductNumber FROM "+tabla;
            conexion.Open();
            SqlDataReader oDr = comando.ExecuteReader();
            List<Producto> productos = new List<Producto>();
            while(oDr.Read())
            {
                productos.Add(new Producto(oDr["Name"].ToString(), oDr["ProductNumber"].ToString(), oDr["ProductID"].ToString()));
            }
            conexion.Close();
            return productos;
        }

        public void Agregar(Producto p)
        {
            comando.CommandText = "INSERT INTO Product2 (Name, ProductNumber) VALUES ('" + p.Nombre + "', '" + p.Serial + "');";
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void Modificar(Producto p, string tabla)
        {
            comando.CommandText = "UPDATE " + tabla + " SET Name = '" + p.Nombre + "', ProductNumber = '" + p.Serial + "' WHERE ProductID = " + p.ID;
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void Borrar(Producto p, string tabla)
        {
            comando.CommandText = "DELETE FROM " + tabla + " WHERE ProductID = " + p.ID;
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
