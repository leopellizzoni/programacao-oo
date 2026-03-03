using System;

namespace ConsoleAppAula01;

public class Veiculo
{
    public Veiculo()
    {   
        Placa = "Não informada";
        Marca = "Não informada";
        Modelo = "Precisa definir";
    }

    public Veiculo(String placa, String marca) : this()
    {
        Placa = placa;
        Marca = marca;
    }

    public String Placa;

    public String Marca;

    public String Modelo;
}
