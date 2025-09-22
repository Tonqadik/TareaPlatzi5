enum Tipo_trabajo { 
    COMERCIO,
    SALUD,
    HUMANIDADES,

}
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



class Programa
{
    static void Main(string[] args)
    {
        Tarjeta tj1 = new Tarjeta("Juan garces", "Empleado de una farmaceutica");
        Tarjeta tj2 = new Tarjeta("Tomas Torres", "Empleado de una empresa de electrodómesticos", ["Jugar", "Ver series", "Cocinar"]);

        tj1.imprimirDesc();
        tj2.imprimirDesc();
    }
}




