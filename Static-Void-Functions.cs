
public class Program
{
     
    static void Main()
    {
        Console.WriteLine("Hola");
        Espacio();
        Nombre();
        Sumar(5, 3);
        AlCuadrado(numero:5);
        Console.ReadKey();
    }

    static void Espacio()
    {
        Console.WriteLine("");
    }

    static void Nombre()
    {
        //Escribir solo Write imprime lo que escribes en la misma linea en vez de abajo.
        Console.Write("Escribe tu nombre: ");
        string nombre = Console.ReadLine();
        Console.WriteLine($"Tu nombre es {nombre}");
    }

    static void Sumar(int n1, int n2)
    {
        int suma = n1 + n2;
        Console.WriteLine($"{n1}+{n2} = {suma}");
    }

    static void AlCuadrado(float numero)
    {
        float cuadrado = numero * numero;
        Console.WriteLine($"{numero}^2 = {cuadrado}");
    }
}
