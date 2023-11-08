using System;

class Program {
  
  //Funções para as ações do jogador e do inimigo
  public static int AtaqueEnemy(ref int vidaPlayer){
    var rand = new Random();
    int danoAtaque = rand.Next(1,7);
    
    vidaPlayer = vidaPlayer - danoAtaque;
    
    Console.WriteLine("O inimigo ataca! Você recebeu {0} de dano.", danoAtaque);
    
    if (vidaPlayer <= 0){
      Console.WriteLine("Você morreu!");
    }
    return vidaPlayer;
  }
  
  public static int AtaquePlayer(ref int vidaEnemy){
    var rand = new Random();
    int danoAtaque = rand.Next(1,7);
    
    vidaEnemy = vidaEnemy - danoAtaque;
    
    Console.WriteLine("Você deu {0} de dano no inimigo!", danoAtaque);
    
    if (vidaEnemy <= 0){
      Console.WriteLine("O inimigo morreu!");
    }
    return vidaEnemy;
  }
  public static int CuraPlayer(ref int vidaPlayer){
    var rand = new Random();
    int curaTotal = rand.Next(7, 12);
    
    vidaPlayer = vidaPlayer + curaTotal;
    
    Console.WriteLine("A vida foi curada em {0}", curaTotal);
    return vidaPlayer;
  }

  public static int FogoAtaque(ref int vidaEnemy){
    var rand = new Random();
    int danoFogo = rand.Next(5, 10);
    
    vidaEnemy = vidaEnemy - danoFogo;
    Console.WriteLine("Você deu {0} de dano de fogo no inimigo!", danoFogo);
    
    if (vidaEnemy <= 0){
      Console.WriteLine("O inimigo morreu!");
    }
    return vidaEnemy;

  }
  // Fim das funções
  public static void Main (string[] args) {
    
    int vidaEnemy, vidaPlayer, opcao;
    vidaEnemy = 20;
    vidaPlayer = 15;
    opcao = 0;
    
    // Início de combate
    while (vidaEnemy > 0 && vidaPlayer > 0  && opcao != 4){
      Console.WriteLine("O inimigo tem {0} de vida e você tem {1}", vidaEnemy, vidaPlayer);
      Console.WriteLine("Atacar - 1, Fogo - 2, Cura - 3 ou Fugir - 4");
      opcao = int.Parse(Console.ReadLine());
      AtaqueEnemy(ref vidaPlayer);
        
      if (opcao == 1 && vidaPlayer > 0){
          AtaquePlayer(ref vidaEnemy);
      } else if (opcao == 2 && vidaPlayer > 0){
          FogoAtaque(ref vidaEnemy);
      } else if (opcao == 3 && vidaPlayer > 0){
          CuraPlayer(ref vidaPlayer);
      } else if (opcao == 4 && vidaPlayer > 0){
          Console.WriteLine("Você fugiu da batalha!");
      }
    } 

    // Fim de batalha
    Console.WriteLine("A batalha terminou.");
          
  }
}