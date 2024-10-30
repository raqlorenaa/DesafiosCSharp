using System;

class CarroTeste
{
    static void Main(string[] args)
    {
        Motor motor1 = new Motor(1.6);
        Carro carro1 = new Carro("ABC-1234", "Modelo X", motor1);

        Console.WriteLine($"Carro: {carro1.Modelo}, Placa: {carro1.Placa}, Velocidade Máxima: {carro1.CalcularVelocidadeMaxima()} km/h");

        Motor motor2 = new Motor(2.0);
        carro1.TrocarMotor(motor2);

        Console.WriteLine($"Carro: {carro1.Modelo}, Placa: {carro1.Placa}, Novo Motor: {motor2.Cilindrada}L, Velocidade Máxima: {carro1.CalcularVelocidadeMaxima()} km/h");

        // Teste para verificar a exceção ao tentar instalar o mesmo motor em dois carros
        try
        {
            Carro carro2 = new Carro("DEF-5678", "Modelo Y", motor2);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
