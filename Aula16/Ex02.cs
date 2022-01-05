using System;

class Program {
  public static void Main() {
    Apto x = new Apto();
    Console.WriteLine(x);
    Console.WriteLine("Andares do Apto X");
    //x.GetNumeros();
    Apto y = new Apto();
    y.SetNumAndares(2);
    y.SetNumAptosAndar(4);
    Console.WriteLine(y);
    Console.WriteLine("Andares do Apto Y");
    //y.GetNumeros();
    int[] w = y.GetNumeros2();
    foreach(int i in w)
      Console.WriteLine(i);
  }
}

class Apto {
  private int numAndares = 1;
  private int numAptosAndar = 1;
  public void SetNumAndares(int i) {
    if (i >= 1) numAndares = i;
  }
  public void SetNumAptosAndar(int i) {
    if (i >= 1) numAptosAndar = i;
  }
  public void GetNumeros() {
    for (int i = 1; i <= numAndares; i++) {
      Console.WriteLine($"{i}º Andar");
      for (int j = 1; j <= numAptosAndar; j++)
        Console.WriteLine($"Apto {i*100+j}");
    }
  } 
  public int[] GetNumeros2() {
    int[] vetor = new int[numAndares * numAptosAndar];
    int k = 0;
    for (int i = 1; i <= numAndares; i++) {
      for (int j = 1; j <= numAptosAndar; j++)
        vetor[k++] = i*100+j;
    }
    return vetor;
  } 
  public override string ToString() {
    return $"Nº Andares = {numAndares} - Nº Aptos por andar = {numAptosAndar}";
  }
}
