namespace DiamanteDeLetras //Exercício 5. 
{
    internal class Program
    {
        #region Parâmetros
        // Padrões do diamante de letras 
        // A partir de uma letra de 'A' a 'Z', iniciando em 'A' fornecida como ponto mais distante.
        // 1 - Definir as variáveís para o triângulo até a letra fornecida. 
        // 2 - Definir o espaçamento do triângulo entre as letras. 
        // 3 - Definir os códigos decrescentes do triângulo até a letra inicial. 
        #endregion
        static void Main(string[] args)
        {
            #region Solicitar a letra para o usuário
            Console.WriteLine("Digite uma letra entre A e Z: ");

            char qtdLetras = Convert.ToChar(Console.ReadLine());

            Console.WriteLine();
            #endregion
            #region Parte de cima do Diamante
            int quantidadeBranco = -1;
            int quantidadeEspacosExterior = qtdLetras - 'A'; // Char e int é a mesma coisa representando o mesmo valor da tabela ASCII

            for (char i = 'A'; i <= qtdLetras - 1; i++) // Ele para até a letra selecionada. 
            {
                for (int k = 0; k <= quantidadeEspacosExterior; k++) // DEFINE O ESPAÇO EXTERIOR
                {
                    Console.Write(" ");
                }
                Console.Write(i);
                //Variável char quando recebe ++ no laço de repetição ela sobe uma letra do alfabeto.

                for (int j = 0; j < quantidadeBranco; j++)//DEFINE O ESPAÇO INTERIOR

                {
                    Console.ForegroundColor = ConsoleColor.Yellow; //Mudança de cor da letra by Bruno Carvalho. 
                    Console.Write(".");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                if (i != 'A') // Escreve a letra no final. 
                {
                    Console.Write(i);
                }
                quantidadeBranco += 2;
                quantidadeEspacosExterior--;
                Console.WriteLine();

            }
            #endregion
            #region Parte de baixo do Diamante
            quantidadeEspacosExterior = 0;
            quantidadeBranco -= 1;
            for (char g = qtdLetras; g >= 'A'; g--) // Ele para até a letra selecionada. 
            {

                for (int k = 0; k <= quantidadeEspacosExterior; k++) // DEFINE O ESPAÇO EXTERIOR
                {
                    Console.Write(" ");
                }

                Console.Write(g);

                for (int j = 0; j <= quantidadeBranco; j++)//DEFINE O ESPAÇO INTERIOR

                {
                    Console.ForegroundColor = ConsoleColor.Yellow; //Mudança de cor da letra by Bruno Carvalho. 
                    Console.Write(".");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                if (g != 'A') // Escreve a letra no final. 
                {
                    Console.Write(g);
                }
                Console.WriteLine();
                quantidadeEspacosExterior++;
                quantidadeBranco -= 2;
            }
            
            Console.ReadLine();
            #endregion
        }   
    }
}