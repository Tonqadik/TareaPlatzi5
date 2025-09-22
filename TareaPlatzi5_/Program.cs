public class Tarjeta {

    // Atributos
    public string nombre { set; get; }
    public string desc { set; get; }
    private string[] afficiones { set; get; } = [];


    // Constructores
    public Tarjeta(string nombreTarjeta, string descripcion)
    {
        nombre = nombreTarjeta;
        desc = descripcion;
    }

    public Tarjeta(string nombreTarjeta, string descripcion, string[] afficionesTarjeta)
    {
        nombre = nombreTarjeta;
        desc = descripcion;
        afficiones = afficionesTarjeta;
    }



    // Métodos
    public void imprimirDesc() {
        Console.WriteLine($"Esta tarjeta pertenece a {nombre}, y su descripción es {desc} ");
        if (afficiones.Length > 0) { // En caso de tener afficiones, las imprime
            Console.Write("además, tienes las siguientes afficiones:\n");
            foreach (string s in afficiones)
            {
                Console.Write($"*{s}\n");
            }
        }else Console.Write("y no tiene afficiones.\n"); // En caso de no tenerla, imprime un mensaje que diga que no tiene afficiones
    }
}

public class Log {
    private string rutaDestino { set; get; }
    private string logStr      { set; get; } = "";

    public Log()
    {
        string directorio = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "/"; // Directorio del proyecto
        string pathResultado = directorio + "Log.txt";
        rutaDestino = pathResultado;
        addLinea("Programa iniciado");
    }

    public void addLinea(string linea)
    {
        logStr += $"[{DateTime.Now.ToString()}]{linea}\n";
    }

    public void crearLog()
    {
        addLinea("Programa terminado");
        System.IO.File.WriteAllText(rutaDestino, logStr);
    }

}



class Programa
{
    static void Main(string[] args)
    {
        Log lg = new Log();

        lg.addLinea("Creacion de clases");
        Tarjeta tj1 = new Tarjeta("Juan garces", "Empleado de una farmaceutica");
        Tarjeta tj2 = new Tarjeta("Tomas Torres", "Empleado de una empresa de electrodómesticos", ["Jugar", "Ver series", "Cocinar"]);

        lg.addLinea("Se imprimen las tarjetas");
        tj1.imprimirDesc();
        tj2.imprimirDesc();

        lg.crearLog();
    }
}

enum Tipo_trabajo
{
    COMERCIO,
    SALUD,
    HUMANIDADES,

}