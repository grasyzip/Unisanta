//alunas: Daniela Catarino e Grasielly Ribeiro

//declaração de variáveis
double a, b, c, delta, raiz, raiz1, raiz2;

//valores das variáveis
//operações possíveis: 
    //a = 1, b = 2, c = -3 [1, 3]
    //a = 2, b = -3, c = 1 [1, 0.5]
    //a = -3, b = 1, c = 2 [-0.6, 1]
    //a = -3, b = -1, c = 2 [-1, 0.6]
    //a = -3, b = -1, c = -2 [0.6, -1]
    //a = -3, b = -1, c = -2 [não possui raízes reais]

    a = 1;
    b = 2;
    c = -3;

//calcula o delta
    delta = b * b - 4 * a * c;

//verifica a equação tem raízes reais
    if (delta < 0)
    {
        //delta for = zero, a equação tem uma raiz real dupla, duas raízes iguais
        Console.WriteLine("A equação não possui raízes reais.");
    }
    else if (delta == 0)
    {
        //calcula a raiz única
        raiz = -b / (2 * a);
        Console.WriteLine("A equação possui uma raiz real dupla: " + raiz);
    }
    else
    {
        //calcula as duas raízes reais
        //delta = positivo, a equação tem duas raízes reais distintas
        raiz1 = (-b + Math.Sqrt(delta)) / (2 * a);
        raiz2 = (-b - Math.Sqrt(delta)) / (2 * a);
        Console.WriteLine("A equação das raízes são: " + raiz1 + " e " + raiz2);
    }
    Console.ReadKey();
