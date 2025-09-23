using System;

public class Program
{
    static void Main()
    {
        Console.WriteLine("Escolha uma operação:");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.Write("Opção: ");
        int opcao = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o primeiro número: ");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o terceiro número: ");
        int numero3 = Convert.ToInt32(Console.ReadLine());

        int resultado = 0;

        if (opcao == 1)
        {
            resultado = Somar(numero1, numero2, numero3);
            Console.WriteLine("Resultado da soma: " + resultado);
        }
        else if (opcao == 2)
        {
            resultado = Subtrair(numero1, numero2, numero3);
            Console.WriteLine("Resultado da subtração: " + resultado);
        }
        else if (opcao == 3)
        {
            resultado = Multiplicar(numero1, numero2, numero3);
            Console.WriteLine("Resultado da multiplicação: " + resultado);
        }
        else
        {
            Console.WriteLine("Opção inválida!");
        }
    }

    // Função que soma três números
        public static int Somar(int a, int b, int c)
        {
            return a + b + c;
        }

        public static int Subtrair(int a, int b, int c)
        {
            return a - b - c;
        }

        public static int Multiplicar(int a, int b, int c)
        {
            return a * b * c;
        }
}
