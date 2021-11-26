using System;

class Program {
  public static void Main() {

    string s;
    do { // Teste no fim
      s = Console.ReadLine();
      if (s != "2002")
        Console.WriteLine("Senha Invalida");
    } while (s != "2002"); 
    Console.WriteLine("Acesso Permitido");

/*    
    string s = Console.ReadLine();
    while (s != "2002") { // Teste no fim
      Console.WriteLine("Senha Invalida");
      s = Console.ReadLine();
    }; 
    Console.WriteLine("Acesso Permitido");
*/
  }
}
