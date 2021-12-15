using System;

class Program {
  public static void Main() {
    // r1 e r2 são referências
    Retangulo r1 = new Retangulo();
    Retangulo r2 = new Retangulo(30, 40);
    /*
    r1.b = -10;
    r1.h = 20;
    r2.b = 30;
    r2.h = 40;
    */
    r1.SetBase(-10);
    r1.SetAltura(20);
    //r2.SetBase(30);
    //r2.SetAltura(40);
    int x = 10;
    int y = 20;
    x = y;

    // c1 e c2 são instâncias
    Circulo c1;
    Circulo c2;
    c1.raio = -10;
    c1.cor = "verde";
    c2.raio = -20;
    c2.cor = "amarelo";

    //c1 = c2;

    Console.WriteLine(r1);
    double resultado = r1.GetBase();
    Console.WriteLine(resultado);
    Console.WriteLine(r2);
    Console.WriteLine(r2.GetBase());
    Console.WriteLine(c1);
    Console.WriteLine(c2);
    Console.WriteLine(c1.raio);
    Console.WriteLine(c2.raio);
 
    /*
    r1 = r2;
    r1.b = 100;
    Console.WriteLine(r2.b);
    r1 = null;

    // C++: delete r1;
    r1 = null;
    */
  }
}
struct Circulo {
  public double raio; // campo ou atributo
  public string cor;
}
class Retangulo {
  private double b, h;
  public Retangulo() {
    b = 0;
    h = 0;
  }
  public Retangulo(double v1, double v2) {
    if (v1 >= 0) b = v1;
    if (v2 >= 0) h = v2;
  }
  public void SetBase(double v) {
    if (v > 0) b = v;
  }
  public void SetAltura(double v) {
    if (v > 0) h = v;
  }
  public double GetBase() {
    return b;
  }
  public double GetAltura() {
    return h;
  }
  public override string ToString() {
    return "retângulo";
  }
}


