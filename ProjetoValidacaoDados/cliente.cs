using System;
using System.Globalization;

public class Cliente
{
    public string Nome { get; private set; }
    public string CPF { get; private set; }
    public DateTime DataNascimento { get; private set; }
    public float RendaMensal { get; private set; }
    public char EstadoCivil { get; private set; }
    public int Dependentes { get; private set; }

    public static Cliente SolicitarDados()
    {
        Cliente cliente = new Cliente();

        while (true)
        {
            Console.Write("Nome (mínimo 5 caracteres): ");
            string nome = Console.ReadLine();
            if (nome.Length >= 5)
            {
                cliente.Nome = nome;
                break;
            }
            Console.WriteLine("Nome inválido. Tente novamente.");
        }

        while (true)
        {
            Console.Write("CPF (somente números): ");
            string cpf = Console.ReadLine();
            if (ValidarCPF(cpf))
            {
                cliente.CPF = cpf;
                break;
            }
            Console.WriteLine("CPF inválido. Tente novamente.");
        }

        while (true)
        {
            Console.Write("Data de Nascimento (DD/MM/AAAA): ");
            if (DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataNascimento))
            {
                if (DateTime.Now.Year - dataNascimento.Year >= 18)
                {
                    cliente.DataNascimento = dataNascimento;
                    break;
                }
            }
            Console.WriteLine("Data de nascimento inválida ou cliente menor de 18 anos. Tente novamente.");
        }

        while (true)
        {
            Console.Write("Renda Mensal (valor com duas casas decimais e vírgula decimal): ");
            if (float.TryParse(Console.ReadLine(), NumberStyles.AllowDecimalPoint, new CultureInfo("pt-BR"), out float rendaMensal) && rendaMensal >= 0)
            {
                cliente.RendaMensal = rendaMensal;
                break;
            }
            Console.WriteLine("Renda mensal inválida. Tente novamente.");
        }

        while (true)
        {
            Console.Write("Estado Civil (C, S, V, D): ");
            char estadoCivil = char.ToUpper(Console.ReadLine()[0]);
            if ("CSV".Contains(estadoCivil) || "D".Contains(estadoCivil))
            {
                cliente.EstadoCivil = estadoCivil;
                break;
            }
            Console.WriteLine("Estado civil inválido. Tente novamente.");
        }

        while (true)
        {
            Console.Write("Dependentes (0 a 10): ");
            if (int.TryParse(Console.ReadLine(), out int dependentes) && dependentes >= 0 && dependentes <= 10)
            {
                cliente.Dependentes = dependentes;
                break;
            }
            Console.WriteLine("Número de dependentes inválido. Tente novamente.");
        }

        return cliente;
    }

    public static bool ValidarCPF(string cpf)
    {
        cpf = cpf.Replace(".", "").Replace("-", "");

        if (cpf.Length != 11 || cpf.Distinct().Count() == 1)
        {
            return false;
        }

        int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
        int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

        string tempCpf = cpf.Substring(0, 9);
        int soma = 0;

        for (int i = 0; i < 9; i++)
        {
            soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
        }

        int resto = soma % 11;
        if (resto < 2)
        {
            resto = 0;
        }
        else
        {
            resto = 11 - resto;
        }

        string digito = resto.ToString();
        tempCpf = tempCpf + digito;
        soma = 0;

        for (int i = 0; i < 10; i++)
        {
            soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
        }

        resto = soma % 11;
        if (resto < 2)
        {
            resto = 0;
        }
        else
        {
            resto = 11 - resto;
        }

        digito = digito + resto.ToString();

        return cpf.EndsWith(digito);
    }
}
