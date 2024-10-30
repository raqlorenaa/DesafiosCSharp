using System;


public class Intervalo
{
    public DateTime DataHoraInicial { get; private set; }
    public DateTime DataHoraFinal { get; private set; }

    public Intervalo(DateTime dataHoraInicial, DateTime dataHoraFinal)
    {
        if (dataHoraInicial > dataHoraFinal)
        {
            throw new ArgumentException("Data/hora inicial deve ser menor ou igual a data/hora final.");
        }
        DataHoraInicial = dataHoraInicial;
        DataHoraFinal = dataHoraFinal;
    }

    public bool TemIntersecao(Intervalo outro)
    {
        return DataHoraInicial < outro.DataHoraFinal && DataHoraFinal > outro.DataHoraInicial;
    }

    public bool Igual(Intervalo outro)
    {
        return DataHoraInicial == outro.DataHoraInicial && DataHoraFinal == outro.DataHoraFinal;
    }

    public TimeSpan Duracao
    {
        get
        {
            return DataHoraFinal - DataHoraInicial;
        }
    }
}
