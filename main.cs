using System;

class Program {
  public int AtaqueEnemy(ref int vidaPlayer){
    var rand = new Random();
    int danoAtaque = rand.Next(1,7);
    
    vidaPlayer = vidaPlayer - danoAtaque;
    
    Console.WriteLine("O inimigo ataca! Você recebeu {0} de dano.", danoAtaque);
    
    if (vidaPlayer <= 0){
      Console.WriteLine("Você morreu!");
    }
    return vidaPlayer;
  }
  
  public int AtaquePlayer(ref int vidaEnemy){
    var rand = new Random();
    int danoAtaque = rand.Next(1,7);
    
    vidaEnemy = vidaEnemy - danoAtaque;
    
    Console.WriteLine("Você deu {0} de dano no inimigo!", danoAtaque);
    
    if (vidaEnemy <= 0){
      Console.WriteLine("O inimigo morreu!");
    }
    return vidaEnemy;
  }
  public int CuraPlayer(ref int vidaPlayer){
    var rand = new Random();
    int curaTotal = rand.Next(7, 12);
    
    vidaPlayer = vidaPlayer + curaTotal;
    
    Console.WriteLine("A vida foi curada em {0}", curaTotal);
    return vidaPlayer;
  }

  public int FogoAtaque(ref int vidaEnemy){
    var rand = new Random();
    int danoFogo = rand.Next(5, 10);
    
    vidaEnemy = vidaEnemy - danoFogo;
    Console.WriteLine("Você deu {0} de dano de fogo no inimigo!", danoFogo);
    
    if (vidaEnemy <= 0){
      Console.WriteLine("O inimigo morreu!");
    }
    return vidaEnemy;

  }
  
  public static void Main (string[] args) {
    Program combate = new Program();
    int vidaEnemy, vidaPlayer, opcao;
    vidaEnemy = 20;
    vidaPlayer = 15;
    opcao = 0;
    

    while (vidaEnemy > 0 && vidaPlayer > 0  && opcao != 4){
      Console.WriteLine("O inimigo tem {0} de vida e você tem {1}", vidaEnemy, vidaPlayer);
      Console.WriteLine("Atacar - 1, Fogo - 2, Cura - 3 ou Fugir - 4");
      opcao = int.Parse(Console.ReadLine());
      combate.AtaqueEnemy(ref vidaPlayer);
        
      if (opcao == 1 && vidaPlayer > 0){
          combate.AtaquePlayer(ref vidaEnemy);
      }
      if (opcao == 2 && vidaPlayer > 0){
          combate.FogoAtaque(ref vidaEnemy);
      }
      if (opcao == 3 && vidaPlayer > 0){
          combate.CuraPlayer(ref vidaPlayer);
      }
      if (opcao == 4 && vidaPlayer > 0){
          Console.WriteLine("Você fugiu da batalha!");
      }
    } 
    
    Console.WriteLine("A batalha terminou.");

    //Antes estava um amontoado de else if como no exemplo abaixo
    
          /*
          } else if (vidaEnemy > 0 && opcao == 2) {
              combate.FogoAtaque(ref vidaEnemy);
          } else if (vidaEnemy > 0 && opcao == 3) {
              combate.CuraPlayer(ref vidaPlayer);
          } else if (vidaEnemy > 0 && opcao == 4){
              Console.WriteLine("Você fugiu da batalha!");
          }
          */

    //Preferi só com if, achei que fica mais limpa a visualização do código
          
  }
}