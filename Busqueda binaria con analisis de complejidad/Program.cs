using Busqueda_binario_con_analisis_de_complejidad;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] datos = { 10, 20, 30, 40, 50 };
        Console.WriteLine("Posición: " + Busqueda.Binaria(datos, 30));
        Console.WriteLine("Tiempo: O(log n)");
        Console.WriteLine("Espacio: O(1)");
    }
}