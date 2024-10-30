using System;

class IntervaloTeste
{
    static void Main(string[] args)
    {
        DateTime inicio1 = new DateTime(2024, 10, 30, 8, 0, 0);
        DateTime fim1 = new DateTime(2024, 10, 30, 10, 0, 0);
        Intervalo intervalo1 = new Intervalo(inicio1, fim1);

        DateTime inicio2 = new DateTime(2024, 10, 30, 9, 0, 0);
        DateTime fim2 = new DateTime(2024, 10, 30, 11, 0, 0);
        Intervalo intervalo2 = new Intervalo(inicio2, fim2);

        Console.WriteLine($"Duração do intervalo 1: {intervalo1.Duracao}");
        Console.WriteLine($"Duração do intervalo 2: {intervalo2.Duracao}");

        Console.WriteLine($"Intervalos têm interseção? {intervalo1.TemIntersecao(intervalo2)}");

        DateTime inicio3 = new DateTime(2024, 10, 30, 8, 0, 0);
        DateTime fim3 = new DateTime(2024, 10, 30, 10, 0, 0);
        Intervalo intervalo3 = new Intervalo(inicio3, fim3);

        Console.WriteLine($"Intervalo 1 é igual ao intervalo 3? {intervalo1.Igual(intervalo3)}");
    }
}
