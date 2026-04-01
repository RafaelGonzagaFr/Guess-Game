using System.ComponentModel;

class Partida
{
    private int tentativas;
    private int num;
    private int dificuldade;
    private int limiteChute;
    private bool acertou = false;
    private int chute;


    public Partida()
    { 
    }

    private int Num
    {
        get { return num; }
        set { num = value; }
    }

    public int Dificuldade
    {
        get { return dificuldade; }
        set { dificuldade = value; }
    }

    public int LimiteChute
    {
        get { return limiteChute; }
        set { limiteChute = value; }
    }

    public int Tentativas
    {
        get { return tentativas; }
        set { tentativas = value; }
    }

    public void EscolherDificuldade()
    {
        Console.WriteLine("Escolha a dificuldade");
        
        while (true)
        {
        Console.Write("----------------------|\n1 - Fácil (1 a 100)   |\n2 - Médio (1 a 300)   |\n3 - Difícil (1 a 500) |\n----------------------|\n-> ");
        string? entrada = Console.ReadLine();

        if (!int.TryParse(entrada, out int valor) || valor < 1 || valor > 3)
        {
            Console.WriteLine("\nDigite uma dificuldade válida");
            continue;
        } else
            {
                Dificuldade = valor;
                break;
            }
        }
    }

    public void GerarNumero()
    {
        switch (dificuldade)
        {
            case 1:
                (Num, LimiteChute) =  (Random.Shared.Next(1, 101),100);
                break;
            case 2:
                (Num, LimiteChute) =  (Random.Shared.Next(1, 301),300);
                break;
            case 3:
                (Num, LimiteChute) =  (Random.Shared.Next(1, 501),500);
                break;
        }
    }

    public void Chutar()
    {
        Console.WriteLine("DEFINIMOS A DIFICULDADE, VAMOS JOGAR!!!\n");
        while(!acertou)
        {
            Console.Write("\nChute um número\n-> ");
            string? valor  = Console.ReadLine();
            if(!int.TryParse(valor, out chute))
            {
                Console.WriteLine("\nChute um número válido");
                continue;
            }
            tentativas++;
            if(chute == num)
            {
                Console.WriteLine($"Parabéns!! Você ganhou - o número era {num}\nVocê acertou com {tentativas} tentativas");
                acertou = true;
            } else if (chute > num)
            {
                Console.WriteLine("\nChute um número menor");
            } else
            {
                Console.WriteLine("\nChute um número maior");
            }

        }

    }

    public void Jogar()
    {
        Console.WriteLine("Vamos começar o jogo\n");
        EscolherDificuldade();
        GerarNumero();
        Chutar();
    }
}