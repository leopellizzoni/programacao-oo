using System;

namespace ConsoleAppAula01;

public class ExcecaoDeRegraDoSistema : Exception
{
    public ExcecaoDeRegraDoSistema(String mensagem) : base(mensagem)   
    {
        
    }
}
