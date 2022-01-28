using System;

class Program {
  public static void Main() {
    double[] vetor = new double[100];
    for (int i = 0; i < 10; i++) {
      vetor[i] = double.Parse(Console.ReadLine());
    }
    for (int i = 0; i < 10; i++) {
      if (vetor[i] <= 10)
        Console.WriteLine($"A[{i}] = {vetor[i]:0.0}");
    }
  }
}