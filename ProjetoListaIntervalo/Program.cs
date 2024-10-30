using System;
using shared; 

class ListaIntervaloTeste
{
    static void Main(string[] args)
    {
        ListaIntervalo lista = new ListaIntervalo();

        Intervalo intervalo1 = new Intervalo(new DateTime(2024, 10, 30, 8, 0, 0), new DateTime(2024, 10, 30, 10, 0, 0));
        Intervalo intervalo2 = new Intervalo(new DateTime(2024, 10, 30, 11, 0, 0), new DateTime(2024, 10, 30, 12, 0, 0));
        Intervalo intervalo3 = new Intervalo(new DateTime(2024, 10, 30, 9, 0, 0), new DateTime(2024, 10, 30, 11, 0, 0)); // Intersecciona com intervalo1

        Console.WriteLine($"Adicionado intervalo 1: {lista.Add(intervalo1)}"); // True
        Console.WriteLine($"Adicionado intervalo 2: {lista.Add(intervalo2)}"); // True
        Console.WriteLine($"Adicionado intervalo 3: {lista.Add(intervalo3)}"); // False

        foreach (var intervalo in lista.Intervalos)
        {
            Console.WriteLine($"Intervalo: {intervalo.DataHoraInicial} - {intervalo.DataHoraFinal}");
        }
    }
}
