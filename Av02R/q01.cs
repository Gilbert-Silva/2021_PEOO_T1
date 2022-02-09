using System;

class Program {
  public static void Main() {
    Console.Write("Informe o número de contas: ");
    int n = int.Parse(Console.ReadLine());
    /*
    Energia vetor[0];
    Energia vetor[1];
    ....
    Energia vetor[n-1];
    */

    Energia[] vetor = new Energia[n];

    for (int i = 0; i < n; i++) { // n vezes
      Console.Write("Informe o mês/ano: ");
      string ma = Console.ReadLine();
      Console.Write("Informe o consumo em kWh: ");
      int c = int.Parse(Console.ReadLine());
      Console.Write("Informe o valor em R$: ");
      double v = double.Parse(Console.ReadLine());
      Energia e = new Energia(ma, c, v);
      vetor[i] = e;
    }
    int totalc = 0;
    double totalg = 0;
    foreach(Energia e in vetor) {
      totalc = totalc + e.GetConsumo();
      totalg = totalg + e.GetValor();
    }
    /*
    for (int i = 0; i < n; i++) {
      totalc = totalc + vetor[i].GetConsumo();
      totalg = totalg + vetor[i].GetValor();
    }
    */
    Console.WriteLine($"Consumo total em kWh - {totalc}");
    Console.WriteLine($"Total gasto em R$ - {totalg:0.00}");
  }
}

class Energia {
  private string mesAno;
  private int consumo;
  private double valor;
  public Energia(string ma, int c, double v) {
    this.mesAno = ma;
    this.consumo = c;
    this.valor = v;
  }
  public string GetMesAno() {
    return mesAno;
  }
  public int GetConsumo() {
    return consumo;
  }
  public double GetValor() {
    return valor;
  }
}
