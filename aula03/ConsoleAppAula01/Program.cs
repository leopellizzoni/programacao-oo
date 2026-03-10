using ConsoleAppAula01;

internal class Program
{
    private static void Main(string[] args)
    {
        Funcionario joao = new Funcionario("João", 25000);

        Console.WriteLine("O salario liquido do joao é: " + joao.SalarioLiquido);

        Funcionario pedro = new Funcionario("Pedro", 5000);

        Funcionario maria = new Funcionario("Maria", 5000);


    }
}