using System;

class Program {
  public static void Main() {
    /*
    int dia = 19;
    int mes = 8;
    int ano = 2021;
    Console.WriteLine("{0}/{1:00}/{2}", dia, mes, ano);
    Console.WriteLine($"{dia}/{mes:00}/{ano}");
    Console.WriteLine(dia.ToString() + "/" + mes.ToString("00") + "/" + ano.ToString());  // str(dia)
    */
    double x = 1.0049;
    Console.WriteLine(x);
    Console.WriteLine($"{x}");
    Console.WriteLine($"{x:f3}");
    Console.WriteLine($"{x:f4}");
    Console.WriteLine($"{x:f5}");
    Console.WriteLine($"{x:.000}");
    Console.WriteLine($"{x:0.000}");
    Console.WriteLine($"{x:00.0000}");
    double y = 0.000001;
    Console.WriteLine($"{y:f3}");
    Console.WriteLine($"{y:g3}");
    double z = 1000000000;
    Console.WriteLine($"{z:f3}");
    Console.WriteLine($"{z:g3}");

    string s = Console.ReadLine();
    string[] v = s.Split(' ');
    double a = double.Parse(v[0]); // a = float(v[0])
    double b = double.Parse(v[1]);
    double c = double.Parse(v[2]);
    Console.WriteLine($"TRIANGULO: {a*c/2:f3}");
    Console.WriteLine($"CIRCULO: {c*c*3.14159:0.000}");
    Console.WriteLine($"TRAPEZIO: {(a+b)*c/2:0.000}");
    Console.WriteLine($"QUADRADO: {b*b:0.000}");
    Console.WriteLine($"RETANGULO: {a*b:0.000}");
  }
}
