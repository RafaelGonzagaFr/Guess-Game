class Ranking
{
    List<int> ranking = new List<int>();

    public void AcrescentarPontuacao(int tentativas)
    {
        ranking.Add(tentativas);
        ranking.Sort();
        if (ranking.Count > 5)
        {
            ranking.RemoveAt(ranking.Count - 1);
        }
    }

    public void MostrarPontuacao()
    {
        Console.WriteLine("\nRanking:");
        if (ranking.Count == 0)
        {
            Console.WriteLine("Nenhuma pontuação ainda.");
            return;
        }
        for(int i = 0; i < Math.Min(5, ranking.Count); i++)
        {
            Console.WriteLine($"{i+1}º lugar - {ranking[i]}");
        }
    }
}