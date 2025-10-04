using System;
class Program
{
    //1)
    static void Main()
    {
        bool exeProgram = true;
        while (exeProgram)
        {
            Console.Write("Digite um n° entre 1 e 10 (ou '0' para sair): ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int num))
            {
                if (num == 0)
                {
                    exeProgram = false;
                }
                else if (num >= 1 && num <= 10)
                {
                    string numExten = NumExten(num);
                    Console.WriteLine("Número por extenso: {0}", numExten);
                }
                else
                {
                    Console.WriteLine("Número fora do intervalo permitido(1 - 10).");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Digite um número inteiro.");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Programa encerrado.");
    }
    static string NumExten(int num)
    {
        string[] numsExtenso = {
            "um", "dois", "três", "quatro", "cinco",
            "seis", "sete", "oito", "nove", "dez"};
        return numsExtenso[num - 1];
    }

    //2)
    static void Main()
    {
        bool continua = true;
        while (continua)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("| CALCULADORA |");
            Console.WriteLine("----------------------");
            Console.WriteLine("| 1 - Adição |");
            Console.WriteLine("| 2 - Subtração |");
            Console.WriteLine("| 3 - Multiplicação |");
            Console.WriteLine("| 4 - Divisão |");
            Console.WriteLine("| 5 - Sair |");
            Console.WriteLine("----------------------");
            Console.WriteLine();
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();
            if (opcao == "5")
            {
                continua = false;
                Console.WriteLine("Programa fechando.");
            }
            else if (opcao == "1" || opcao == "2" || opcao == "3" ||
            opcao == "4")
            {
                Console.Write("Digite o primeiro número: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("Digite o segundo número: ");
                int num2 = int.Parse(Console.ReadLine());
                int result = ExeOp(opcao, num1, num2);
                Console.WriteLine("Resultado: {0}", result);
            }
            else
            {
                Console.WriteLine("Opção inválida! Tente novamente.");
            }
            Console.WriteLine();
        }
    }
    static int Adicao(int a, int b)
    { return a + b; }
    static int Subtracao(int a, int b)
    { return a - b; }
    static int Multiplicacao(int a, int b)
    { return a * b; }
    static int Divisao(int a, int b)
    {
        if (b == 0)
        {
            Console.WriteLine("Erro: Divisão por zero não é permitida!");
            return 0;
        }
        return a / b;
    }
    static int ExeOp(string opcao, int num1, int num2)
    {
        if (opcao == "1")
        { return Adicao(num1, num2); }
        else if (opcao == "2")
        { return Subtracao(num1, num2); }
        else if (opcao == "3")
        { return Multiplicacao(num1, num2); }
        else
        { return Divisao(num1, num2); }
    }

    //3)
    static void Main()
    {
        Console.Write("Digite um número para verificar se é primo: ");
        string input = Console.ReadLine();
        if (int.TryParse(input, out int num) && num > 0)
        {
            bool ePrimo = VerificaPrimo(num);
            if (ePrimo)
            {
                Console.WriteLine("{0} é um número primo.", num);
            }
            else
            {
                Console.WriteLine("{0} não é um número primo.", num);
            }
        }
        else
        {
            Console.WriteLine("Por favor, digite um número inteiro positivo válido.");
        }
    }
    static bool VerificaPrimo(int num)
    {
        if (num <= 1) return false;
        if (num == 2) return true;
        if (num % 2 == 0) return false;
        for (int divisor = 3; divisor * divisor <= num; divisor += 2)
        {
            if (num % divisor == 0)
            {
                return false;
            }
        }
        return true;
    }
    //4)
    static void Main()
    {
        bool continua = true;
        while (continua)
        {
            Console.WriteLine
            ("------------------------------------------");
            Console.WriteLine("| CALCULADORA DE IMC | ");
            Console.WriteLine("| Classificação conforme tabela da OMS | ");
            Console.WriteLine
            ("------------------------------------------");
            Console.WriteLine();
            Console.Write("Digite seu peso em kg (ex: 68,5): ");
            string inpPeso = Console.ReadLine();
            Console.Write("Digite sua altura em metros (ex: 1,75): ");
            string inpAltura = Console.ReadLine();
            if (float.TryParse(inpPeso, out float peso) &&
            float.TryParse(inpAltura, out float altura))
            {
                if (peso > 0 && altura > 0)
                {
                    float imc = CalculaIMC(peso, altura);
                    string classifica = ClassIMC(imc);
                    Console.WriteLine();
                    Console.WriteLine
                    ("--------------------------------");
                    Console.WriteLine("| RESULTADO | ");
                    Console.WriteLine
                    ("--------------------------------");
                    Console.WriteLine(" Peso: {0} kg", peso);
                    Console.WriteLine(" Altura: {0} m", altura);
                    Console.WriteLine(" IMC: {0:F2}", imc);
                    Console.WriteLine(" Classificação: {0}",
                    classifica);
                    Console.WriteLine
                    ("--------------------------------");
                }
                else
                {
                    Console.WriteLine("Erro: Peso e altura devem ser valores positivos.");
                }
            }
            else
            {
                Console.WriteLine("Erro: Por favor, digite valores numéricos válidos.");
            }
            Console.WriteLine();
            Console.Write("Deseja calcular outro IMC? (s/n): ");
            string resposta = Console.ReadLine();
            if (resposta.ToLower() != "s")
            {
                continua = false;
            }
        }
        Console.WriteLine("Programa encerrando.");
    }
    static float CalculaIMC(float peso, float altura)
    {
        return peso / (altura * altura);
    }
    static string ClassIMC(float imc)
    {
        return imc switch
        {
            < 18.5f => "Abaixo do peso",
            < 25f => "Peso normal",
            < 30f => "Sobrepeso",
            < 35f => "Obesidade grau I",
            < 40f => "Obesidade grau II",
            _ => "Obesidade grau III"
        };
    }
}
