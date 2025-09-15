using System;

class Program
{
    static void Main()
    {
        // Solicita dois números ao usuário
        Console.Write("Digite o primeiro número: ");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        // Faz a soma
        int resultado = numero1 + numero2;

        // Exibe o resultado
        Console.WriteLine("A soma é: " + resultado);
    }
}
