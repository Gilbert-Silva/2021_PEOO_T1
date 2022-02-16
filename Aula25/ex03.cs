using System;
using System.Collections.Generic;

class Program {
  public static void Main() {
    //Pais<Jpg> p1 = new Pais<Jpg>();
    //Pais<Png> p2 = new Pais<Png>();

    Pais p1 = new Pais("Argent", 9, 7, 2);
    Pais p2 = new Pais("Brasil", 9, 7, 4);
    Pais p3 = new Pais("Russia", 7, 4, 2);
    Pais p4 = new Pais("Aleman", 7, 15, 2);
    Pais p5 = new Pais("Japao ", 7, 15, 2);
    Pais p6 = new Pais("Belgic", 7, 15, 2);
    List<Pais> lp = new List<Pais>();
    lp.Add(p1);
    lp.Add(p2);
    lp.Add(p3);
    lp.Add(p4);
    lp.Add(p5);
    lp.Add(p6);
    lp.Sort(); // p2.CompareTo(p1)
    foreach(Pais p in lp)
      Console.WriteLine(p);
  }
}

//class Pais<T> {
class Pais : IComparable<Pais> {
  private string nome;
  private int ouro, prata, bronze;
  // private T bandeira;
  public Pais(string n, int o, int p, int b) {
    nome = n;
    ouro = o;
    prata = p;
    bronze = b;
  }
  public override string ToString() {
    return $"{nome} - Ouro={ouro} - Prata={prata} - Bronze={bronze}";
  }
  public int CompareTo(Pais obj) {
    //Pais x = (Pais) obj;
    // Console.WriteLine($"Comp: {nome} x {obj.nome}");
    // -1, 0, 1
    if (this.ouro > obj.ouro) return -1;
    if (this.ouro < obj.ouro) return 1;
    if (this.prata > obj.prata) return -1;
    if (this.prata < obj.prata) return 1;
    if (this.bronze > obj.bronze) return -1;
    if (this.bronze < obj.bronze) return 1;
    //return 0;
    return this.nome.CompareTo(obj.nome);
  }
}