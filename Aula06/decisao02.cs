using System;

class Program {
  public static void Main() {
    Console.WriteLine("Digite a nota da disciplina (0-100)");
    int nota = int.Parse(Console.ReadLine()); 

    //Matemática: 0 <= nota <= 100
    //Programação: 0 <= nota && nota <= 100

/*
    if (nota < 0)
      Console.WriteLine("Valor menor que o permitido");
    if (nota >= 0 && nota <= 100)  
      Console.WriteLine("Valor dentro da faixa permitida");
    if (nota > 100)  
      Console.WriteLine("Valor maior que o permitido");
*/
    if (nota < 0) {
      Console.WriteLine("Valor menor que o permitido");
    }
    else {
      if (nota <= 100) {
        Console.WriteLine("Valor dentro da faixa permitida");
      }
      else  
        Console.WriteLine("Valor maior que o permitido");
    }    
  }
}