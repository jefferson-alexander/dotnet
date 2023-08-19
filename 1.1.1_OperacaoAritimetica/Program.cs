class Program
{
  static void Main(string[] args) //parâmetro que permite passar argumentos para o programa na linha de comando.
  {    
        Console.Write("Digite o primeiro número: ");    
        double n1 = double.Parse(Console.ReadLine());
        Console.Write("Digite o segundo número: ");
        double n2 = double.Parse(Console.ReadLine());

       double adicao        = n1 + n2;
       double multiplicacao = n1 * n2;
       double subtracao     = n1 - n2;
       double divisao       = n1 / n2;
       double r_divisao     = n1 % n2;

        Console.WriteLine($"O valor da adição é:           {adicao}");
        Console.WriteLine($"O valor da multiplicação é:    {multiplicacao}");
        Console.WriteLine($"O valor da subtração é:        {subtracao}");
        Console.WriteLine($"O valor da divisão é:          {divisao}");
        Console.WriteLine($"O valor do resto da divisão é: {r_divisao}");
  }
    
  
}