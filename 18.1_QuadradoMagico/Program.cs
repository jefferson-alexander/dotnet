//Resultado quadrado mágico: 6,1,8,7,5,3,2,9,4
class Program
{
    static void Main()
    {
        //Resultado quadrado mágico: 6,1,8,7,5,3,2,9,4

        char caractere = '-';               // O caractere que você deseja replicar
        int quantidade = 45;                // O número de vezes que você deseja replicar o caractere
        int[,] QuadradoMagico=new int[3,3]; //array bidimensional de matriz
        int[]  NumerosDigitados=new int[9]; //array em fila dos númerios digitados

        string resultado = new string(caractere, quantidade);  //exibindo os caracteres '-'       
        
        //padrão de posicionamento 
        Console.WriteLine(resultado);    
        Console.WriteLine(string.Format("{0,-45}","-Quadrado Mágico")); // Alinhando à esquerda
        Console.WriteLine(string.Format("{0,30}","+Quadrado Mágico"));  // Alinhando ao centro
        Console.WriteLine(string.Format("{0,45}","*Quadrado Mágico"));  // Alinhando à direita
        Console.WriteLine(resultado);

        Console.WriteLine("Digite os 9 números para formar o quadrado mágico:");

        for(int i = 0; i < 9; i++){
            int nDigitado;
            do{
                Console.Write($"Digite o número {i + 1}: ");
            }while (!int.TryParse(Console.ReadLine(), out nDigitado) || Array.Exists(NumerosDigitados, num => num == nDigitado));

            NumerosDigitados[i]=nDigitado;
        }

        // Preencher o quadrado mágico com os números digitados
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                QuadradoMagico[i, j] = NumerosDigitados[i * 3 + j];
            }
        }         
        
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(QuadradoMagico[i, j] + " | ");
            }            
            Console.WriteLine();
        } 
        // Verificar se o quadrado é mágico
        int somaDiagonalPrincipal = 0;
        int somaDiagonalSecundaria = 0; 

        for(int i = 0; i < 3; i++)
        {
            int somaLinha=0;
            int somaColuna=0;

            for(int j = 0; j < 3; j++)
            {
                somaLinha  += QuadradoMagico[i,j]; 
                somaColuna += QuadradoMagico[j,i];
                if(i == j)                
                    somaDiagonalPrincipal += QuadradoMagico[i,j];
                if(i + j == 2)
                    somaDiagonalSecundaria +=QuadradoMagico[i,j];    
                
            }

            if(somaLinha != 15 || somaColuna != 15)
            {
                Console.WriteLine("Os números digitados não formam um Quadrado Mágico.");
                return;
            }else
            {
                Console.WriteLine("Os números digitados formam um Quradrado Mágico."); 
                return;         
            }
                        

        }  
        
    }
}
