using System;

class Program {
  public static void Main() {
    /*
    if
    if else
    switch
    */
    Console.WriteLine("Digite a nota da disciplina (0-100)");
    int nota = int.Parse(Console.ReadLine()); 
    Console.WriteLine("Digite a frequencia na disciplina (0-100)");
    int freq = int.Parse(Console.ReadLine()); 
//    bool x = nota >= 60;
//  if (x) {

// = operador de atribuição  x = 5 + 9
// == operador relacional    x == 14
// Pascal := (atribuição) = (comparação) <> (diferença)
// C#     =               ==             !=
// operadores lógicos C#: e (&&) ou (||) negação (!)
// Python                    and     or           !

//  int x = 1 + (2 * 3);
/*
    if (nota >= 60 && freq >= 75) {
      Console.WriteLine("Parabéns");
      Console.WriteLine("Aprovado");
    }
    if (nota < 60 || freq < 75) {
      Console.WriteLine("Se dedique mais");
      Console.WriteLine("Reprovado");
    }
*/
    if (nota >= 60 && freq >= 75) {
      Console.WriteLine("Parabéns");
      Console.WriteLine("Aprovado");
    }
    else {
      Console.WriteLine("Se dedique mais");
      Console.WriteLine("Reprovado");
    }

  }
}
