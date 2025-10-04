using System;

class Program
{
    //1)
    static void Main()
    {
        Console.Write("Digite um n° positivo: ");
        int num = int.Parse(Console.ReadLine());
        if (num < 1)
        {
            Console.Write("Digite um n° positivo maio que zero.");
            return;
        }
        int result = somaRecur(num);
        Console.Write("A soma dos n° de 1 até {0} é: {1}", num, result);
    }
    static int somaRecur(int a)
    {
        if (a == 0)
        {
            return 0;
        }
        else
        {
            return a + somaRecur(a - 1);
        }
    }
    //2)
    static void Main()
    {
        int[] a = { 10, 45, -10, 0, -60, 25, 30 };
        Console.Write("Array: ");
        for (int i = 0; i < a.Length; i++)
        {
            if (i > 0) Console.Write(", ");
            Console.Write(a[i]);
        }
        Console.WriteLine();
        int maior = encontrar(a, 0);
        Console.WriteLine("Maior elemento: {0}", maior);
    }
    static int encontrar(int[] array, int index)
    {
        return (index == array.Length - 1) ? array[index] : Math.Max(array[index], encontrar(array, index + 1));
    }

    //3)
    public static void Main()
    {
        Console.Write("Digite um n° inteiro positivo: ");
        string input = Console.ReadLine();
        if (int.TryParse(input, out int num) && num >= 0)
        {
            int result = soma_digitos(num);
            Console.WriteLine("A soma dos dígitos de {0} é: {1}", num, result);
        }
        else
        {
            Console.WriteLine("Digite um n° inteiro positivo válido!");
        }
    }
    public static int soma_digitos(int num)
    {
        if (num < 10)
        {
            return num;
        }
        else
        {
            return (num % 10) + soma_digitos(num / 10);
        }
    }
}
