//EXCEPCIONES
try
{
    // Código
}
catch (OverflowException e)
{
    Console.WriteLine(e.Message);
}
catch (DivideByZeroException e)
{
    Console.WriteLine(e.Message);
}
finally
{
    Console.WriteLine("Pulse una tecla para continuar...");
}



//crear excepcion
using System;

public class EmployeeListNotFoundException : Exception
{
    public EmployeeListNotFoundException()
    {
    }

    public EmployeeListNotFoundException(string message)
        : base(message)
    {
    }

    public EmployeeListNotFoundException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
























//GENERICS
public class Mensajero<T, U>
{
    private T miAtr1;
    private U miAtr2;
    private Dictionary<T, U> miDiccionario;
}

Mensaje<string, int> tipoTexto =
    new Mensaje<string, int>();
Mensaje<char, MiClase> tipoMio =
    new Mensaje<char, MiClase>();


public class Mensajero<T> where T : Mensaje
{ }
class EjemploComplejo<K, V, U>
    // Implemente interfaz
    where U : System.IComparable<U>
    // V tenga constructor por defecto
    where V : new()
{ }

class Prueba
{
    public static void OpTest<T>(T s, T t) where T : class
    {
        System.Console.WriteLine(s == t);
    }

    public void OpTest2<T>(T s, T t) where T : class
    {
        System.Console.WriteLine(s == t);
    }
}









//INTERFACES

public interface MIInterfaz
{
    public string MiMetodo();
    //solo se declara la firma, en donde se use la interfaz se implementa
}













//SERIALIZACION XML

    //ESCRITURA

using System.Xml;
using System.Xml.Serialization;
//...
Dato p = new Dato();   //Objeto a serializar.
XmlTextWriter writer;  //Objeto que escribirá en XML.
XmlSerializer ser;     //Objeto que serializará.

//Se indica ubicación del archivo XML y su codificación.
writer = new XmlTextWriter(ArchivoXml, Codificación);
//Se indica el tipo de objeto ha serializar.
ser = new XmlSerializer(typeof(Dato));
//Serializa el objeto p en el archivo contenido en writer.
ser.Serialize(writer, p);
//Se cierra la conexión al archivo
writer.Close();


    //LECTURA
using System.Xml;
using System.Xml.Serialization;
//...
//Objeto que alojará los datos contenidos en el archivo XML.
Dato aux = new Dato();
XmlTextReader reader;   //Objeto que leerá XML.
XmlSerializer ser;      //Objeto que Deserializará.

//Se indica ubicación del archivo XML.
reader = new XmlTextReader(ArchivoXml);
//Se indica el tipo de objeto ha serializar.
ser = new XmlSerializer(typeof(Dato));
//Deserializa el archivo contenido en reader, lo guarda en aux.
aux = (Dato) ser.Deserialize(reader);
//Se cierra el objeto reader.
reader.Close();











//SERIALIZACION BINARIA

    Para poder hacer una serialización binaria se debe agregar el marcador[Serializable]

    [Serializable]
class MiClase
{
}

//ESCRITURA
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
//...
Dato aux = new Dato(); // Objeto a serializar.
FileStream fs;         //Objeto que escribirá en binario.
BinaryFormatter ser;   //Objeto que serializará.

//Se indica ubicación del archivo binario y el modo.
fs = new FileStream(ArchivoBinario, FileMode.Create);
//Se crea el objeto serializador.
ser = new BinaryFormatter();
//Serializa el objeto p en el archivo contenido en fs.
ser.Serialize(fs, p);
//Se cierra el objeto fs
fs.Close();


    //LECTURA
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
//...
//Objeto que alojará los datos contenidos en el archivo binario.
Dato aux = new Dato();
FileStream fs;            //Objeto que leerá en binario.
BinaryFormatter ser;      //Objeto que Deserializará.

//Se indica ubicación del archivo binario y el modo.
fs = new FileStream(pathBinario, FileMode.Open);
//Se crea el objeto deserializador.
ser = new BinaryFormatter();
//Deserializa el archivo contenido en fs, lo guarda en aux.
aux = (Dato) ser.Deserialize(fs);
//Se cierra el objeto fs.
fs.Close();








//SQL

    String connectionStr = "Data Source=[Instancia Del Servidor]; Initial Catalog =[Nombre de la Base de Datos]; Integrated Security = True";
    using System.Data.SqlClient;
    SqlConnection conexion;
    conexion = new SqlConnection(connectionStr);

//ejemplo de command
SqlCommand comando;

comando = new SqlCommand();
comando.CommandType = System.Data.CommandType.Text;

comando.Connection = conexion;

//ejemplo de consulta SELECT
comando.CommandText = "SELECT nombre FROM Personas";
conexion.Open();

SqlDataReader oDr = comando.ExecuteReader();

while (oDr.Read())
{
    string aux = oDr["nombre"].ToString();
}

//Ejemplo Insert, Update y Delete

String consulta;
consulta = "UPDATE Personas SET nombre = 'Fer' WHERE id = 1";
consulta = "INSERT INTO Personas (nombre)  VALUES('Pedro')";
consulta = "DELETE FROM Personas WHERE id = 1";

comando.CommandText = consulta;
conexion.Open();
comando.ExecuteNonQuery();













//THREAD

    // Agrego la biblioteca
using System.Threading;


// Creo el hilo
Thread t = new Thread(UnMetodo);
// Inicio el Hilo
t.Start();



//EJEMPLO CON PARAMETROS
// Creo el hilo
Thread t = new Thread(new ParameterizedThreadStart(Metodo));
// Inicio el Hilo, indicando el parámetro
t.Start(1000);


private void Metodo(object o)
{
    Console.WriteLine((int)o);
}



//EJEMPLO EN FORMS
private void Metodo(object o)
{
    if (this.label.InvokeRequired)
    {
        this.label.BeginInvoke((MethodInvoker)delegate ()
        {
            this.label.Text = (int)o;
        }
        );
    }
    else
    {
        this.label.Text = (int)o;
    }
}













//DELEGADOS
public delegate void MiDelegado(object sender, EventArgs e);

public event MiDelegado ElEvento;

objEmisor.evento += MetodoManejador;






//METODOS DE EXTENCION

    namespace MetodoDeExtension
{
    public static class MiExtension
    {
        public static int Metodo(this [tipo][nombre])
        {
            return 0;
        }
    }
}