internal class Program
{
    private static void Main(string[] args)
    {
        double[,] media = new double[5, 3];
        Random sorteio = new Random();

        media = InserirNotas(media);

        media = LerMedia(media);

        media = ImprimirNotas(media);

        double[,] ImprimirNotas(double[,] media)
        {
            Console.Clear();
            for (int linha = 0; linha < 5; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    if (coluna == 2)
                    {
                        Console.WriteLine($" = {media[linha, coluna].ToString("F2")}");
                    }
                    else
                    {
                        Console.Write($"  {coluna + 1}º Nota '{media[linha, coluna].ToString("F2")}'");
                    }
                }
            }
            return media;
        }

        double[,] LerMedia(double[,] tabela)
        {
            for (int linhas = 0; linhas < media.GetLength(0); linhas++)
            {
                tabela[linhas, 2] = ((tabela[linhas, 0] + tabela[linhas, 1]) / 2);
            }
            return tabela;
        }

        double[,] InserirNotas(double[,] tabela)
        {

            for (int coluna = 0; coluna < tabela.GetLength(1)-1; coluna++)
            {
                for (int linha = 0; linha < tabela.GetLength(0); linha++)
                {
                    tabela[linha, coluna] = (double) sorteio.Next(1000)/100;
                }
            }
            return tabela;
        }

    }
}
