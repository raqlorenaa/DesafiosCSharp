using System;

public class Carro
{
    public string Placa { get; private set; }
    public string Modelo { get; private set; }
    public Motor Motor { get; private set; }

    public Carro(string placa, string modelo, Motor motor)
    {
        if (string.IsNullOrEmpty(placa) || string.IsNullOrEmpty(modelo) || motor == null)
        {
            throw new ArgumentException("Placa, modelo e motor são obrigatórios.");
        }

        Placa = placa;
        Modelo = modelo;
        Motor = motor;
        Motor.InstalarNoCarro(this);
    }

    public void TrocarMotor(Motor novoMotor)
    {
        if (novoMotor == null)
        {
            throw new ArgumentException("O carro não pode ficar sem motor.");
        }

        Motor.RemoverDoCarro();
        Motor = novoMotor;
        Motor.InstalarNoCarro(this);
    }

    public int CalcularVelocidadeMaxima()
    {
        if (Motor.Cilindrada <= 1.0)
        {
            return 140;
        }
        else if (Motor.Cilindrada <= 1.6)
        {
            return 160;
        }
        else if (Motor.Cilindrada <= 2.0)
        {
            return 180;
        }
        else
        {
            return 220;
        }
    }
}
