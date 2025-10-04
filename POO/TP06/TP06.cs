using System;
//1)
class Funcionario
{
private string nome;
private decimal salario;
}
class Program
{
static void Main()
{
Funcionario funcionario = new Funcionario();
}
}
//2) 
class Funcionario
{
private string nome;
private decimal salario;
public Funcionario(string nome, decimal salario)
{
this.nome = nome;
this.salario = salario < 0 ? 0 : salario;
}
public void Exibir()
{
Console.WriteLine("Nome do Funcinário: {0}", nome);
Console.WriteLine("Salário: R$ {0}", salario);
}
}
class Program
{
static void Main()
{
Console.WriteLine("Digite o nome do fucinário: ");
string nome = Console.ReadLine();
Console.WriteLine("Digite o salário: ");
decimal salario = decimal.Parse(Console.ReadLine());
Funcionario funcionario = new Funcionario(nome, salario);
Console.WriteLine("Dados do Funcionário");
funcionario.Exibir();
}
}

//3)
class NotaFiscal
{
private int Numitem;
private string descriitem;
private int quantidde;
private decimal preco;
public NotaFiscal(int Numitem, string descriitem, int quantidade, 
decimal preco)
{
this.Numitem = Numitem;
this.descriitem = descriitem;
this.quantidde = quantidade < 0 ? 0 : quantidade;
this.preco = preco < 0 ? 0 : preco;
}
public decimal GetInvoiceAmount()
{
return quantidde * preco;
}
public void Exibir()
{
Console.WriteLine("Nº do Item: {0}", Numitem);
Console.WriteLine("Descrição: {0}", descriitem);
Console.WriteLine("Quantidade: {0}", quantidde);
Console.WriteLine("Preço único: {0}", preco);
Console.WriteLine("Valor total: {0}", GetInvoiceAmount());
}
}
class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o nº do item: ");
        int Numitem = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a descrição do item: ");
        string descriitem = Console.ReadLine();
        Console.WriteLine("Digite a quantidade comprada: ");
        int quantidde = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o preço unitário: ");
        decimal preco = decimal.Parse(Console.ReadLine());
        NotaFiscal nota = new NotaFiscal(Numitem, descriitem,
        quantidde, preco);
    }
}