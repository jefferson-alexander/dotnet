class Program
{
    static void Main(string[] args)
    {
        bool shouldExit = false;
        bool operadorsinal = false;
        Console.WriteLine("======= Calculadora =======");
        do
        {
            
            Console.WriteLine("Escolha a operação: + Adição | - Subtração | * Multiplicação | / Divisão | % Resto da Divisão | S para SAIR");
            char operacao = Console.ReadKey().KeyChar; 
            Console.WriteLine();  

            if (operacao == 'S' || operacao == 's')
            {
                shouldExit = true;
            }
            
            else if (operacao == '+' || operacao == '-' || operacao == '*' || operacao == '/' || operacao == '%') 
            //Console.WriteLine("teste");           
            {   

                if (operacao == '+')
                {    
                    Console.Write("Digite o primeiro número: ");
                    double n1 = double.Parse(Console.ReadLine());
                    Console.Write("Digite o segundo número: ");
                    double n2 = double.Parse(Console.ReadLine());                             
                    double resultado = n1 + n2;
                    Console.WriteLine($"Resultado da adição: {resultado}");
                }
                else if (operacao == '-')
                {
                    Console.Write("Digite o primeiro número: ");
                    double n1 = double.Parse(Console.ReadLine());
                    Console.Write("Digite o segundo número: ");
                    double n2 = double.Parse(Console.ReadLine());
                    double resultado = n1 - n2;
                    Console.WriteLine($"Resultado da subtração: {resultado}");
                }
                else if (operacao == '*')
                {
                    Console.Write("Digite o primeiro número: ");
                    double n1 = double.Parse(Console.ReadLine());
                    Console.Write("Digite o segundo número: ");
                    double n2 = double.Parse(Console.ReadLine());
                    double resultado = n1 * n2;
                    Console.WriteLine($"Resultado da multiplicação: {resultado}");
                }
                else if (operacao == '/')
                {
                    Console.Write("Digite o primeiro número: ");
                    double n1 = double.Parse(Console.ReadLine());
                    Console.Write("Digite o segundo número: ");
                    double n2 = double.Parse(Console.ReadLine());
                    double resultado = n1 / n2;
                    Console.WriteLine($"Resultado da divisão: {resultado}");
                }
                else if (operacao == '%')
                {
                    Console.Write("Digite o primeiro número: ");
                    double n1 = double.Parse(Console.ReadLine());
                    Console.Write("Digite o segundo número: ");
                    double n2 = double.Parse(Console.ReadLine());
                    double resultado = n1 % n2;
                    Console.WriteLine($"Resultado do resto da divisão: {resultado}");
                }                
            }
            
            else
            {
                Console.WriteLine("Operação inválida. Tente novamente.");
            }

            //Console.WriteLine("Pressione uma tecla para continuar ou 'Q' para sair.");
        } while (!shouldExit);

        Console.WriteLine("Obrigado por usar a Calculadora!");
    }
}

