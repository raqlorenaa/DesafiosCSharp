using System;

class Program
{
    static void Main(string[] args)
    {
        Cliente cliente = Cliente.SolicitarDados();
        Console.WriteLine("\nDados do Cliente:");
        Console.WriteLine($"Nome: {cliente.Nome}");
        Console.WriteLine($"CPF: {cliente.CPF}");
        Console.WriteLine($"Data de Nascimento: {cliente.DataNascimento:dd/MM/yyyy}");
        Console.WriteLine($"Renda Mensal: {cliente.RendaMensal:F2}");
        Console.WriteLine($"Estado Civil: {cliente.EstadoCivil}");
        Console.WriteLine($"Dependentes: {cliente.Dependentes}");
    }
}
