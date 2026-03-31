using System;

namespace SistemaGestaoEventos;

public class MeusLocais
{
    private Local[] todosLocais;

    public MeusLocais()
    {
        todosLocais = [];
    }

    public Local[] Adicionar(Local novo)
    {
        Local[] novoVetor = new Local[todosLocais.Length + 1];

        int cont;

        for (cont = 0; cont < todosLocais.Length; cont++)
        {
            novoVetor[cont] = todosLocais[cont];
        }

        novoVetor[novoVetor.Length - 1] = novo;

        return novoVetor;
    }

    public Local Obter(int index)
    {
        return todosLocais[index];
    }

    public void Listar() 
    {
        for(int i = 0; i <= todosLocais.Count(); i++)
        {
            Console.WriteLine($"{i + 1}) {todosLocais[i].ObterDescricao()}");
        }
    }
}
