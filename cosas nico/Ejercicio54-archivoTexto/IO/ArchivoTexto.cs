using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Ejercicio42
{
    public static class ArchivoTexto
    {
        public static void Guardar(string path, string info)
        {
            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine(info);
            sw.Close();
        }

        public static string Leer(string path)
        {
            try
            {
                StreamReader sr = new StreamReader(path);
                if(sr != null)
                    return sr.ReadToEnd();
            }
            catch (Exception ex)
            {
                //throw new FileNotFoundException("Archivo no encontrado", ex);
            }
            return "";
        }
    }
}
