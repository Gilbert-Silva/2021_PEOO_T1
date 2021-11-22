using System;

class Program {
  public static void Main() {
    Console.WriteLine("Digite um valor inteiro");
    int x = int.Parse(Console.ReadLine());

    int n = 0;
    while(n < x) {
      n = n + 2;
      Console.WriteLine(n);
    }
    Console.WriteLine($"Depois da repetição {n}");

    for (n = 0; n < x; n = n + 2) {
      Console.WriteLine(n);
    }
    Console.WriteLine($"Depois da repetição {n}");

    n = 0;
    do {
      Console.WriteLine(n);
      n = n + 2;
    } while(n < x);
    Console.WriteLine($"Depois da repetição {n}");
  }
}