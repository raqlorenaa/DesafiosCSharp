using System;

public class CertidaoNascimento
{
    public DateTime DataEmissao { get; }
    public Pessoa Pessoa { get; }

    public CertidaoNascimento(Pessoa pessoa, DateTime dataEmissao)
    {
        Pessoa = pessoa ?? throw new ArgumentNullException(nameof(pessoa));
        DataEmissao = dataEmissao;
        pessoa.AssociarCertidao(this);
    }
}