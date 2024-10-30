using System;

class ArmstrongTeste
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 10000; i++)
        {
            if (i.IsArmstrong())
            {
                Console.WriteLine(i);
            }
        }
    }
}
