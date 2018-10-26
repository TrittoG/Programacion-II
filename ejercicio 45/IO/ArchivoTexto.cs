using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IO
{
  public static class ArchivoTexto
  {
    public static void Guardar(string path, string texto)
    {
      StreamWriter st = new StreamWriter(path);
      st.WriteLine(texto);
      st.Close();
    }

    public static string Leer(string path)
        {
            try
            {
                StreamReader st = new StreamReader(path);

                string retorno = st.ReadToEnd();
                st.Close();
                return retorno;

            }
            catch(FileNotFoundException e)
            {
                return e.Message;
            }
        }


  }
}
