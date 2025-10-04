using System;
class URI
{//4)
    static void Main(string[] args)
    {
        while (true)
        {
            string entrada = Console.ReadLine();
            if (int.TryParse(entrada, out int num))
            {
                if (num == 0)
                    break;
                int[,] a = BuildArray(num);
                PrintArray(a);
                Console.WriteLine();
            }
        }
    }
    static int[,] BuildArray(int num)
    {
        int[,] array = new int[num, num];
        int layout = (num + 1) / 2;
        for (int l = 0; l < layout; l++)
        {
            int valor = l + 1;
            int comeco = l;
            int final = num - 1 - l;
            for (int j = comeco; j <= final; j++)
            {
                array[comeco, j] = valor;
                array[final, j] = valor;
            }
            for (int i = comeco; i <= final; i++)
            {
                array[i, comeco] = valor;
                array[i, final] = valor;
            }
        }
        return array;
    }
    static void PrintArray(int[,] array)
    {
        int n = array.GetLength(0);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(array[i, j].ToString().PadLeft(3));
                if (j < n - 1)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
    //3)
    static void Main(string[] args)
    {
        int mes = int.Parse(Console.ReadLine());
        Console.WriteLine(nomeMeses(mes));
    }
    static string nomeMeses(int num)
    {
        return num switch
        {
            1 => "Janeiro",
            2 => "Fevereiro",
            3 => "Março",
            4 => "Abril",
            5 => "Maio",
            6 => "Junho",
            7 => "jULHO",
            8 => "Agosto",
            9 => "Setembro",
            10 => "Outubro",
            11 => "Novembro",
            12 => "Dezembro"
        };
    }
}