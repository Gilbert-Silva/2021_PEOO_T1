using System;

class Program {
  public static void Main() {
    /*
    int[] vi = new int[5];
    vi[0] = 5;
    vi[1] = 9;
    vi[2] = 2;
    vi[3] = 0;
    vi[4] = 10;
    Console.WriteLine(vi);

    for(int i = 0; i < 5; i++)
      Console.WriteLine(vi[i]);

    foreach(int x in vi)  
      Console.WriteLine(x);

    string[] vs = new string[5];
    vs[0] = "C#";
    vs[1] = "Java";
    vs[2] = "Python";
    vs[3] = "Ruby";
    vs[4] = "C++";
    Console.WriteLine(vs);

    for(int i = 0; i < 5; i++)
      Console.WriteLine(vs[i]);

    foreach(string x in vs)  
      Console.WriteLine(x);
    Console.ReadLine();    
    */

    Produto p1 = new Produto("Refri", 5, 2.5);
    Produto p2 = new Produto("Arroz", -5, 3.5);
    Produto p3 = new Produto("Feijão", 2, 5.5);
    Produto p4 = new Produto("Chocolate", 10, 2);
    /*
    Console.WriteLine(p1);
    Console.WriteLine(p1.GetDescricao());
    Console.WriteLine(p1.GetQtd());
    Console.WriteLine(p1.GetPreco());
    Console.WriteLine(p2);
    Console.WriteLine(p3);
    Console.WriteLine(p4);
    */
    Carrinho c = new Carrinho();
    Console.WriteLine(c.Listar());
    foreach(Produto x in c.Listar())
      Console.WriteLine(x);
    c.Inserir(p1);
    c.Inserir(p2);
    c.Inserir(p3);
    c.Inserir(p4);
    Console.WriteLine("Resultado de Listar2");
    foreach(Produto x in c.Listar2())
      if (x != null) Console.WriteLine(x);
    Console.WriteLine();
    double total = 0;
    foreach(Produto x in c.Listar()) {
      Console.WriteLine(x.GetQtd() * x.GetPreco());
      total = total + x.GetQtd() * x.GetPreco();
    }
    Console.WriteLine(total);
    Console.WriteLine(c.Somar());
    Console.WriteLine(c.NumItens());
  }
}

class Carrinho {
  private Produto[] vetor; // ref
  //private List<Produto> lista = new List<Produto>();
  //private Produto[] vetor = new Produto[10];
  private int max;
  private int qtd;
  public Carrinho() {
    max = 10;
    qtd = 0;
    vetor = new Produto[max];
    //vetor.Length = 5;
  }
  public void Inserir(Produto p) {
    if (qtd < vetor.Length) {
      vetor[qtd] = p;
      qtd++;
    }
    //vetor[qtd++] = p;
  }
  public Produto[] Listar() {
    Produto[] aux = new Produto[qtd];
    for (int i = 0; i < qtd; i++)
      aux[i] = vetor[i];
    //Array.Copy(vetor, aux, qtd);
    return aux;
  }
  public Produto[] Listar2() {
    return vetor;
  }
  public double Somar() {
    double total = 0;
    foreach(Produto x in this.Listar()) {
      total = total + x.GetQtd() * x.GetPreco();
    } 
    return total;   
  }
  public int NumItens() {
    /*
    int total = 0;
    for(int i = 0; i < max; i++) {
      Produto x = vetor[i];
      if (x != null) total = total + x.GetQtd();
    }
    */
    int total = 0;
    foreach(Produto x in vetor) {
      if (x != null) total = total + x.GetQtd();
    } 
    return total;   
  }
}

class Produto {
  private string descricao;
  private int qtd;
  private double preco;
  public Produto(string d, int qtd, double p) {
    this.descricao = d;
    if (qtd > 0) this.qtd = qtd; 
    else this.qtd = 1;
    if (p > 0) preco = p; 
    else preco = 1.5;
  }
  public string GetDescricao() {
    return descricao;
  }
  public int GetQtd() {
    return qtd;
  }
  public double GetPreco() {
    return preco;
  }
  public override string ToString() {
    return $"{descricao} - {qtd} - {preco:0.00}";
  }
}