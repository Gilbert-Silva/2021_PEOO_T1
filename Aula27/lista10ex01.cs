using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

class Program {
  public static void Main() {

    XmlSerializer xml = new XmlSerializer(typeof(List<Retangulo>));
    StreamReader fr = null;
    List<Retangulo> lr = null;
    try {
      fr = new StreamReader("./retangulos.xml");
      lr = (List<Retangulo>) xml.Deserialize(fr);
      fr.Close();
      foreach(Retangulo r in lr) Console.WriteLine(r);      
    }
    catch (Exception erro) {
      Console.WriteLine(erro.Message);
    }

    Console.WriteLine("Informe base e altura de um retângulo");
    Retangulo r1 = new Retangulo();
    try {
      r1.SetBase(double.Parse(Console.ReadLine()));
      r1.SetAltura(double.Parse(Console.ReadLine()));
    }
    catch(FormatException) {
      Console.WriteLine("O valor informado não é um nº válido");
    }
    catch(ArgumentOutOfRangeException) {
      Console.WriteLine("O valor informado não pode ser negativo");      
    }
    Console.WriteLine(r1);

    Retangulo r2 = new Retangulo { Base = 20, Altura = 40};
    Console.WriteLine(r2);

    lr = new List<Retangulo>();
    lr.Add(r1);
    lr.Add(r2);
    foreach(Retangulo r in lr)
      Console.WriteLine(r);

    //XmlSerializer xml = new XmlSerializer(typeof(List<Retangulo>));
    StreamWriter fw = new StreamWriter("./retangulos.xml");
    xml.Serialize(fw, lr);
    fw.Close();
  }
}

public class Retangulo {
  private double b, h;
  public double Base { 
    get { return b; }
    set { SetBase(value); }
  }
  public double Altura { 
    get { return h; }
    set { SetAltura(value); }
  }
  public void SetBase(double b) { // Argumento inválido
    if (b > 0) this.b = b;
    else {
      ArgumentOutOfRangeException erro 
        = new ArgumentOutOfRangeException();
      throw erro;
    }
  }
  public void SetAltura(double h) {
    if (h > 0) this.h = h;
    else {
      ArgumentOutOfRangeException erro 
        = new ArgumentOutOfRangeException();
      throw erro;
    }
  }
  public override string ToString() {
    return $"Base = {b}, Altura = {h}";
  }
}