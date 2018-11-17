using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public class Dao : IArchivos<Votacion>
    {
        SqlConnection conexion;
        SqlCommand comando;

        public Dao()
        {
            string connectionStr = "Data Source=LAB3PC08\\SQLEXPRESS;Initial Catalog =votacion-sp-2018; Integrated Security = True";
            conexion = new SqlConnection(connectionStr);
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
        }

        public bool Guardar(string ruta, Votacion obj)
        {
            try
            {
                comando.CommandText = "INSERT INTO dbo.Votaciones (nombreLey ,afirmativos,negativos,abstenciones,nombreAlumno) VALUES ('" + obj.NombreLey + "' , '" + obj.ContadorAfirmativo + "' , '" + obj.ContadorNegativo + "' , '" + obj.ContadorAbstencion + "' , '" + ruta + "');";
                conexion.Open();
                comando.ExecuteNonQuery();
                return true;
            }
            catch(Exception e)
            {
                throw e;
            }
            
        }

        public Votacion Leer(string ruta)
        {
            throw new NotImplementedException();
        }
    }
}
