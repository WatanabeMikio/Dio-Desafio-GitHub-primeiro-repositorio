//Escreva um algoritmo para calcular e escrever o valor de S, sendo S dado pela fórmula:
//S = 1 + 1 / 2 + 1 / 3 + … +1 / 100

//A saída contém um valor correspondente ao valor de S.
//O valor deve ser impresso com dois dígitos após o ponto decimal.

using System;

class DIO
{

    static void Main(string[] args)
    {

        double c, S = 0;
        for (double n = 1; n<=3; n++)
        {
            c =  1/n;  //coloque a sua lógica nos espaços em branco
            S = S + c;
        }
        var x = Math.Round(S, 2);
        Console.WriteLine(x);

    }

}