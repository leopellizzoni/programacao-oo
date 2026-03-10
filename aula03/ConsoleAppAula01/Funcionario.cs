using System;

namespace ConsoleAppAula01;

public class Funcionario
{
    public Funcionario(String nome, decimal salarioBruto)
    {
        Nome = nome;
        SalarioBruto = salarioBruto;   
        GerarSalarioLiquido(); 
    }

    public String Nome { get; set; }

    public Cargo Dev { get; set; }

    public decimal SalarioBruto { get; set; }

    public decimal SalarioLiquido { get; private set;}

    public decimal GerarSalarioLiquido()
    {
        DescontarINSS();
        DescontarIR();
        ContribuirFGTS();

        return SalarioLiquido;
    }

    private void DescontarINSS()
    {
        if (SalarioBruto <= 1518)
        {
            SalarioLiquido = SalarioBruto * 0.925m;
        }   
    }

    private void DescontarIR()
    {   
    }

    private void ContribuirFGTS()
    {
        
    }

    
}
