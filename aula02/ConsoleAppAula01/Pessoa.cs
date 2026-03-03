using System;

namespace ConsoleAppAula01;




public class Pessoa
{   
    //construtor
    public Pessoa(string nome, string sobrenome, int idade)
    {
        Nome = nome;
        Sobrenome = sobrenome;
        Idade = idade;
    }

    //propriedades
    public String Nome;
    public String Sobrenome;
    public int Idade;

    public String CPF;

    public bool APessoaEhIgual(Pessoa outraPessoa)
    {
        if (CPF == outraPessoa.CPF)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool Igual_NaoFazer(Pessoa primeiraPessoa, Pessoa outraPessoa)
    {
        if (primeiraPessoa.Nome == outraPessoa.Nome && 
        primeiraPessoa.Sobrenome == outraPessoa.Sobrenome && 
        primeiraPessoa.Idade == outraPessoa.Idade)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool EhMaiorDeIdade()
    {
        if (Idade >= 18)
        {
            return true;
        }
        return false;
    }
}
