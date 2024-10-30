using System;

public class Piramide
{
    public int N { get; private set; }

    public Piramide(int n)
    {
        if (n < 1)
        {
            throw new ArgumentException("N deve ser maior ou igual a 1");
        }
        N = n;
    }

    public void Desenha()
    {
        for (int i = 1; i <= N; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }

        for (int i = N - 1; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
}
