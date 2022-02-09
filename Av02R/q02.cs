using System;

class Program {
  public static void Main() {
    Jogador j1 = new Jogador("J1", 1, true);
    Jogador j2 = new Jogador("J2", 2, false);
    Jogador j3 = new Jogador("J3", 3, true);
    //Console.WriteLine(j1);
    //Console.WriteLine(j2);
    //Console.WriteLine(j3);
    Time t = new Time("Time");
    t.Inserir(j1);
    t.Inserir(j2);
    t.Inserir(j3);
    foreach(Jogador j in t.Listar())
      Console.WriteLine(j);
    Console.WriteLine(t.Capitao());  
  }
}

class Time {
  private string nome;
  private Jogador[] vetor = new Jogador[11];
  private int k;
  public Time(string n) {
    this.nome = n;
  }
  public void Inserir(Jogador j) {
    //if (Capitao() != null && j.GetCapitao()) return;
    if (Capitao() == null || j.GetCapitao()==false)
      if (k < 11) {
        vetor[k] = j;
        k++;
      }
  }
  public Jogador[] Listar() {
    Jogador[] aux = new Jogador[k];
    Array.Copy(vetor, aux, k);
    return aux;
  }
  public Jogador Capitao() {
    foreach(Jogador j in vetor)
      if (j != null && j.GetCapitao()) return j;
    return null;      
  }
}

class Jogador {
  private string nome;
  private int camisa;
  private bool capitao;
  public Jogador(string n, int c, bool x) {
    this.nome = n;
    this.camisa = c;
    this.capitao = x;
  }
  public bool GetCapitao() {
    return capitao;
  }
  public override string ToString() {
    return $"{nome} - {camisa} - {capitao}";
  }
}
