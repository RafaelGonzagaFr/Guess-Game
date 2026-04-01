using System.Net;
bool continuar = true;
Ranking ranking = new Ranking();
while (continuar)
{
    Partida partida = new Partida();
    ranking.AcrescentarPontuacao(partida.Tentativas);
    ranking.MostrarPontuacao();
    Console.Write("Novo Jogo? (S/N)\n-> ");
    while (true)
    {
        string? entrada = Console.ReadLine();
        if(entrada != "S" & entrada != "s" & entrada != "n" & entrada != "N")
        {
            Console.Write("Insira um valor válido\n-> ");
            continue;
        } else if(entrada == "S" || entrada == "s")
        {
            continuar = true;
            break;
        } else
        {
            continuar = false;
            break;    
        }
    }
}

