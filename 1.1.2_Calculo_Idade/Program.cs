class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite as primeira idade: ");
        int idade1 = int.Parse(Console.ReadLine());
        Console.Write("Digite a segunda idade: ");
        int idade2 = int.Parse(Console.ReadLine());
        Console.Write("Digite a terceira idade: ");
        int idade3 = int.Parse(Console.ReadLine());
        
        int soma     = (idade1 + idade2 + idade3);
        double media = (idade1 + idade2 + idade3 ) / 3;
        
        Console.Write($"A soma das idades é {soma}, e a média entre as idades é: {media}");
    }
}
