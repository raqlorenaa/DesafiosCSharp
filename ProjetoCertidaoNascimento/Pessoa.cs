using System;

public class Pessoa
{
    public string Nome { get; }
    private CertidaoNascimento _certidao;

    public CertidaoNascimento Certidao => _certidao;

    public Pessoa(string nome)
    {
        Nome = nome;
    }

    public void AssociarCertidao(CertidaoNascimento certidao)
    {
        if (_certidao == null)
        {
            _certidao = certidao;
        }
        else
        {
            throw new InvalidOperationException("A pessoa já possui uma certidão associada e ela não pode ser alterada.");
        }
    }
}