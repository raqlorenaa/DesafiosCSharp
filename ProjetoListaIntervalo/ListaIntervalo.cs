using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using shared;

public class ListaIntervalo
{
    private List<Intervalo> intervalos;

    public ListaIntervalo()
    {
        intervalos = new List<Intervalo>();
    }

    public bool Add(Intervalo novoIntervalo)
    {
        foreach (var intervalo in intervalos)
        {
            if (novoIntervalo.TemIntersecao(intervalo))
            {
                return false;
            }
        }
        intervalos.Add(novoIntervalo);
        intervalos.Sort((i1, i2) => i1.DataHoraInicial.CompareTo(i2.DataHoraInicial));
        return true;
    }

    public ReadOnlyCollection<Intervalo> Intervalos
    {
        get { return intervalos.AsReadOnly(); }
    }
}
