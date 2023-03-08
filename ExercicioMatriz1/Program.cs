internal class Program
{
    private static void Main(string[] args)
    {
        float[,] media = new float[5, 3];

        media = InserirNotas(media);

        media = LerMedia(media);

        media = ImprimirNotas(media);

        float[,] ImprimirNotas(float[,] media)
        {
            Console.Clear();
            for (int linha = 0; linha < 5; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    if (coluna == 2)
                    {
                        Console.WriteLine($" = {media[linha, coluna]}");
                    }
                    else
                    {
                        Console.Write($"{coluna + 1}º {media[linha, coluna]}  ");
                    }
                }
            }
            return media;
        }

        float[,] LerMedia(float[,] tabela)
        {
            float media;
            for (int linha = 0; linha < 5; linha++)
            {
                media = 0;
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    if (coluna == 2)
                    {
                        tabela[linha, coluna] = media / 2;
                    }
                    media += tabela[linha, coluna];
                }
            }
            return tabela;
        }

        float[,] InserirNotas(float[,] tabela)
        {

            for (int coluna = 0; coluna < 2; coluna++)
            {
                Console.Clear();
                for (int linha = 0; linha < 5; linha++)
                {
                    Console.Write($"Insira  a {coluna + 1}º nota do aluno {linha + 1}: ");
                    media[linha, coluna] = float.Parse(Console.ReadLine());
                }
            }
            return tabela;
        }

    }
}
