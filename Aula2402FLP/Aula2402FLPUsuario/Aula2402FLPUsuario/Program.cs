
double a, b, c, delta, raiz1, raiz2;

Console.WriteLine("Digite o valor de a:");
    while (!double.TryParse(Console.ReadLine(), out a))
    {
        Console.WriteLine("Valor inválido. Digite um número:");
    }

Console.WriteLine("Digite o valor de b:");
    while (!double.TryParse(Console.ReadLine(), out b))
    {
        Console.WriteLine("Valor inválido. Digite um número:");
    }

Console.WriteLine("Digite o valor de c:");
    while (!double.TryParse(Console.ReadLine(), out c))
    {
        Console.WriteLine("Valor inválido. Digite um número:");
    }

    delta = b * b - 4 * a * c;

    if (delta < 0)
    {
        Console.WriteLine("A equação não possui raízes reais.");
    } else if (delta == 0)
    {
        double raiz = -b / (2 * a);
        Console.WriteLine($"A equação possui uma raiz real dupla: {raiz:F2}");
    } else
    {
        raiz1 = (-b + Math.Sqrt(delta)) / (2 * a);
        raiz2 = (-b - Math.Sqrt(delta)) / (2 * a);
        Console.WriteLine($"As raízes da equação são: {raiz1:F2} e {raiz2:F2}");
    }

   Console.ReadKey();