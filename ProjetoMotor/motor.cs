using System;

public class Motor
{
    public double Cilindrada { get; private set; }
    public Carro CarroInstalado { get; private set; }

    public Motor(double cilindrada)
    {
        if (cilindrada <= 0)
        {
            throw new ArgumentException("A cilindrada deve ser maior que zero.");
        }
        Cilindrada = cilindrada;
    }

    public void InstalarNoCarro(Carro carro)
    {
        if (CarroInstalado != null)
        {
            throw new InvalidOperationException("O motor já está instalado em outro carro.");
        }

        CarroInstalado = carro;
    }

    public void RemoverDoCarro()
    {
        CarroInstalado = null;
    }
}
