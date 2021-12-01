using System;

class Program {
  // int x = 0; // Atributo

  public static void Main() {
    Console.WriteLine("Digite dois valores inteiros");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int m; // Variável local

    m = MaiorValor(a, b); // Enviando a e b
    Console.WriteLine(m);

    m = Program.MaiorValor(a, b); // Enviando a e b
    Console.WriteLine(m);

    m = Math.Max(a, b); // Enviando a e b
    Console.WriteLine(m);

    m = Matematica.MenorValor(a, b); // Enviando a e b
    Console.WriteLine(m);

    if (a > b)
      m = a;
    else 
      m = b;
    Console.WriteLine(m);  
  }
  public static int MaiorValor(int x, int y) {
    if (x > y)
      return x;
    else 
      return y;
  }
}

class Matematica {
  public static int MenorValor(int x, int y) {
    if (x < y)
      return x;
    else 
      return y;
  }
}