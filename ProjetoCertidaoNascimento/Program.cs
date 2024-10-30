public class Program
{
    public static void Main()
    {
        Pessoa pessoa1 = new Pessoa("João Silva");
        CertidaoNascimento certidao1 = new CertidaoNascimento(pessoa1, new DateTime(2023, 1, 1));

        Console.WriteLine($"Pessoa: {pessoa1.Nome}, Data de emissão da certidão: {pessoa1.Certidao.DataEmissao.ToShortDateString()}");
    }
}