using System;

class PiramideTeste
{
    static void Main(string[] args)
    {
        Console.Write("Digite o valor de N para a pirâmide: ");
        int n = int.Parse(Console.ReadLine());

        try
        {
            Piramide piramide = new Piramide(n);
            piramide.Desenha();
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
