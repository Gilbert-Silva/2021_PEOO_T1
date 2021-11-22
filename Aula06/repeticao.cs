using System;

class Program {
  public static void Main() {

  // while, for (teste início), do-while (teste fim)
  // foreach (coleção)
    int nota = -10;
  /*
    do {
      Console.WriteLine("Digite a nota da disciplina (0-100)");
      nota = int.Parse(Console.ReadLine()); 
      // if (0 <= nota && nota <= 100) 
      if (nota >= 0 && nota <= 100) 
        Console.WriteLine("Nota válida");
      else  
        Console.WriteLine("Nota inválida");
    } while (nota < 0 || nota > 100);
  }
  */
    while (nota < 0 || nota > 100){
      Console.WriteLine("Digite a nota da disciplina (0-100)");
      nota = int.Parse(Console.ReadLine()); 
      // if (0 <= nota && nota <= 100) 
      if (nota >= 0 && nota <= 100) 
        Console.WriteLine("Nota válida");
      else  
        Console.WriteLine("Nota inválida");
    } 
  }
}  
    