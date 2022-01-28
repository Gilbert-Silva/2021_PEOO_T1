using System;

class Program {
  public static void Main() {
    int[] v = { 1, 7, 3, 5, 6, 2, 0, 4 };
    string[] vs = { "Java", "Python", "C#", "C++" };

    Console.WriteLine("foreach");
    foreach (string x in vs)
      Console.WriteLine(x);

    Console.WriteLine("foreach");
    foreach (int x in v)
      Console.WriteLine(x);

    Console.WriteLine("for");
    for (int i = 0; i < vs.Length; i++)  
      Console.WriteLine($"{i} - {vs[i]}");

    Console.WriteLine("for");
    for (int i = 0; i < v.Length; i++)  
      Console.WriteLine($"{i} - {v[i]}");
    
    string[] aux = Teste();
    Console.WriteLine(aux);
    foreach(string s in aux)
      Console.WriteLine(s);
 
    Aluno[] va = new Aluno[5];
    // va[0] - null
    va[0] = new Aluno();
    Console.WriteLine(va);    
    Console.WriteLine(va[0]);    

  }


  public static string[] Teste() {
    string[] w = new string[5];
    w[0] = "Este";
    w[1] = "método";
    w[2] = "retorna";
    w[3] = "um";
    w[4] = "vetor";
    string[] q = { "abc", "def", "ghi" };
    return w;
  }
}

class Aluno {
  private string nome;
}