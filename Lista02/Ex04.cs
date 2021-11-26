using System;

class Program {
  public static void Main() {
    Console.WriteLine("Digite a base e a altura do retângulo");
    double b = double.Parse(Console.ReadLine());
    double h = double.Parse(Console.ReadLine());
    double a = b * h;
    double p = b + b + h + h;
    double d = Math.Sqrt(b * b + h * h); // Square root
    Console.WriteLine($"Área = {a:0.00} - Perímetro = {p:f2} - Diagonal = {d:0.00}");
  }
}