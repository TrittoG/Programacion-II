using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ejercicio40
{
    public class ProvincialDAO
    {
        SqlConnection conexion;
        SqlCommand comando;
        public ProvincialDAO()
        {
            conexion = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Centralita;Integrated Security=True");
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
        }

        public void Leer(Centralita c)
        {
            comando.CommandText = "SELECT ID, Duracion, Origen, Destino, Costo, Tipo FROM Llamadas";
            conexion.Open();
            SqlDataReader sDr = comando.ExecuteReader();
            while(sDr.Read())
            {
                if (sDr["Tipo"].ToString() == "1")
                    c += new Provincial(sDr["Origen"].ToString(), Franja.Franja_1, (float)sDr["Duracion"], sDr["Destino"].ToString());
            }
            conexion.Close();
        }
    }
}
