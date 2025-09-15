using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Escolha uma operação:");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.Write("Opção: ");
        int opcao = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o primeiro número: ");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        int resultado = 0;

        if (opcao == 1)
        {
            resultado = Somar(numero1, numero2);
            Console.WriteLine("Resultado da soma: " + resultado);
        }
        else if (opcao == 2)
        {
            resultado = Subtrair(numero1, numero2);
            Console.WriteLine("Resultado da subtração: " + resultado);
        }
        else
        {
            Console.WriteLine("Opção inválida!");
        }
    }

    // Função que soma dois números
    static int Somar(int a, int b)
    {
        return a + b;
    }

    // Função que subtrai dois números
    static int Subtrair(int a, int b)
    {
        return a - b;
    }
}
