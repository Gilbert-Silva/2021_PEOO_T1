using System;

class Program {
  public static void Main() {
    /*
    // Tipos de Variáveis - Por Valor
    struct
    enum
    // Tipos de Variáveis - Por Referência
    string
    class
    */
    int x = 5;
    int y = 10;
    int.Parse("100");
    Console.WriteLine((x.ToString() + y.ToString()));
    string s = "Teste";
    Console.WriteLine(s.Substring(2,2));
    string r = "123";
    Aluno a;
    Professor p = new Professor();
    p.idade = 45;
    p.nome = "Gilbert";
    a.idade = 20;
    a.nome = "Gustavo";

    Console.WriteLine(x + y);
    Console.WriteLine(s + r);
  
  }
}

struct Aluno {
  public int idade;
  public string nome;
}
class Professor {
  public int idade;
  public string nome;
}
