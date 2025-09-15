using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o primeiro número: ");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        // Chama a função de soma
        int resultadoSoma = Somar(numero1, numero2);
        Console.WriteLine("A soma é: " + resultadoSoma);

        // Chama a função de subtração
        int resultadoSubtracao = Subtrair(numero1, numero2);
        Console.WriteLine("A subtração é: " + resultadoSubtracao);
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
