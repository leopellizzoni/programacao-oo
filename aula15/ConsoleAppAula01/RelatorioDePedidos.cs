using System;

namespace ConsoleAppAula01;

public class RelatorioDePedidos
{
    public void ObterPorPeriodo(DateTime inicio, DateTime fim)
    {
        //Faz o processamento... busca na lista... achou os pedidos
        var pedido = new Pedido()
        {
            Id = 10, Nome = "Teste"   
        };

        Console.WriteLine("PEDIDO - "+ pedido.Id + "  " + pedido.Nome);
    }

    public void ObterPorPeriodoParaArquivo(DateTime inicio, DateTime fim)
    {
        //Faz o processamento... busca na lista... achou os pedidos
        var pedido = new Pedido()
        {
            Id = 10, Nome = "Teste"   
        };

        File.WriteAllText("nome-meu-arquivo.txt", "PEDIDO - "+ pedido.Id + "  " + pedido.Nome);
    }
}
