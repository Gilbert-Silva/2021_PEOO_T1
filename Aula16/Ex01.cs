using System;

class Program {
  public static void Main() {
    Console.Write("Informe o número de países: ");
    int k = int.Parse(Console.ReadLine());
    Pais[] vetor = new Pais[k];
    for (int i = 0; i < k; i++) {
      Console.Write("Nome: ");
      string nome = Console.ReadLine();
      Console.Write("Nº habitantes: ");
      int habs = int.Parse(Console.ReadLine());
      Console.Write("Área: ");
      double area = double.Parse(Console.ReadLine());
      Pais p = new Pais(nome, habs, area);
      vetor[i] = p;
    }       
    foreach(Pais p in vetor)
      Console.WriteLine(p);
    //Pais a = new Pais("Brasil", 209000000, 8516000);
    //Pais b = new Pais("Rússia", 144526636, 17124442);
    //Console.WriteLine(a.ToString());
    //Console.WriteLine(b.ToString());
  }
}

class Pais {
  private string nome;
  private int populacao;
  private double area;
  public Pais(string nome, int populacao, double area) {
    this.nome = nome;
    if (populacao > 0) this.populacao = populacao;
    if (area > 0) this.area = area;
  }
  public override string ToString() {
    return $"{this.nome} - {this.populacao} hab - {this.area} km2";
  }
}