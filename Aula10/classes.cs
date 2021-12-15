using System;

// Entrada e Saída
class Program {
  public static void Main() {
    Triangulo x = null;
    x = new Triangulo();
    x.b = -10;
    x.h = 20;
    Triangulo y = new Triangulo();
    y.b = 40;
    y.h = 100;
    Console.WriteLine($"{x} {x.b} {x.h}");
    Console.WriteLine($"{y} {y.b} {y.h}");
    int a = 10;
    int b = 30;
    Console.WriteLine(a);
    Console.WriteLine(b);
  }
}

// Entidade
class Triangulo {
  public double b;
  public double h;
  public Triangulo() { } // Construtor
}
/*
struct int {

}
*/
// Python
/*
class Triangulo:
    pass
x = Triangulo() // Triangulo x = new Triangulo()
print(x)

<__main__.Triangulo object at 0x03245030>
*/
