using System; // Espaço de Nomes - namespace -> Biblioteca
  // Console, String, Math, Int32, Double

class Program { 
  public static void Main() {
    Console.WriteLine("Olá Mundo"); 
    // Console é uma classe
    // WriteLine é um método
    // "Olá Mundo" é um argumento (parâmetro)   
    Pessoa a = new Pessoa(18); // a é uma referência para um
    //a.idade = 10;            // objeto da classe Pessoa
    Console.WriteLine(a.GetIdade());
    Console.WriteLine(a.estadoCivil);

    a.SetIdade(10);
    a.Mostrar();
    a.estadoCivil = EstadoCivil.Solteira;
    //Console.WriteLine(a.DiasVividos());
    a.MostrarDiasVividos();
    Console.WriteLine(a.estadoCivil);
    Pessoa b = new Pessoa(15);
    b.SetIdade(-20);
    //b.idade = -20;
    b.Mostrar();
    //Console.WriteLine(b.DiasVividos());
    b.MostrarDiasVividos();
    Console.WriteLine(Pessoa.DiasPorAno());

    int y = -2000000000; // 2000000000
    EstadoCivil x = EstadoCivil.Solteira;
    Console.WriteLine(x);
  }
}

// Tipo de variável
enum EstadoCivil { Solteira, Casada, Divorciada, Viuva }

// Tipo de variável
class Pessoa {
  // Membros de instância
  private int idade;    // campo (field) ou atributo
  public EstadoCivil estadoCivil; 
  public Pessoa(int valor) {
    idade = valor;
  }
    /*
    0 - Solteira
    1 - Casada
    2 - Divorciada
    3 - Viuva
    */
  public void SetIdade(int valor) {
    if (valor > 0) idade = valor;
  }
  public int GetIdade() {
    return idade;
  }
  public void Mostrar() {   // método
    Console.WriteLine(idade);
  }
  public void MostrarDiasVividos() {
    Console.WriteLine(DiasVividos());
  }
  private int DiasVividos() {
    return idade * 365;
  }
  // Membros da classe
  public static int DiasPorAno() {
    return 365;
  }
}
/*
class Console {
  public static WriteLine(string s) {
    // ??????
    // s é um parâmetro
  }
}

/*
// Equivalente do programa em Python
print("Olá Mundo")

// Equivalente em C++
import <iostream>

int main() {
  cout << "Olá Mundo";    
}
*/
