using System;

class Program {
  public static void Main() {
    int x = 5;
    x = x + 1;
    Console.WriteLine(x);    

    Quadrado q = new Quadrado();
    q.SetLado(100);
    Console.WriteLine(q.GetLado());

    x = q.GetLado();
    Console.WriteLine(x);

    Quadrado r = new Quadrado();
    Console.WriteLine(r.GetLado());
    r.SetLado(400);
    Console.WriteLine(r.GetLado());
    Console.WriteLine(r);

    Console.WriteLine(q);

    q = null;
    //q.lado = 200;
    //Console.WriteLine(q.lado);
  }
}

class Quadrado {
  private int lado = 10;
  public Quadrado() {
    lado = 20;
  }
  public void SetLado(int lado) {
    this.lado = lado; // parâmetro tem precedência
  }
  public int GetLado() {
    return this.lado;
  }
  public override string ToString() {
    return $"Eu sou um quadrado e meu lado vale {lado}";
  }
}

class Triangulo : object {

}

