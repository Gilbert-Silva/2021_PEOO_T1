using System;
using System.Collections.Generic;

class Program {
  public static void Main() {
    X<int> obj1 = new X<int>();
    obj1.SetAtributo(10);
    Console.WriteLine(obj1.GetAtributo());

    X<string> obj2 = new X<string>();
    obj2.SetAtributo("texto");
    Console.WriteLine(obj2.GetAtributo());

    List<int> lista1 = new List<int>(); // lista1 = []
    lista1.Add(350);                     // lista1.append(10)
    lista1.Add(5);                     // lista1.append(20)
    lista1.Add(100); 
    lista1.Add(20); 
    Console.WriteLine(lista1);          // print(lista1)
    lista1.Sort();
    foreach(int i in lista1)
      Console.WriteLine(i);

    List<string> lista2 = new List<string>();
    lista2.Add("C#"); 
    lista2.Add("Java"); 
    lista2.Add("Python"); 
    lista2.Add("C++"); 
    lista2.Add("350"); 
    lista2.Add("5"); 
    lista2.Add("100"); 
    lista2.Add("20"); 
    lista2.Sort(); // Lexicográfica
    foreach(string s in lista2)
      Console.WriteLine(s);

    List<Aluno> lista3 = new List<Aluno>();
    Aluno a1 = new Aluno("Raquel", "123");
    Aluno a2 = new Aluno("Luis", "456");
    Aluno a3 = new Aluno("Luisa", "789");
    lista3.Add(a1);  
    lista3.Add(a2);  
    lista3.Add(a3);
    //lista3.Sort();   // Método de instância
    // Código executado dentro do Sort
    // Único método necessário é o CompareTo
    if (lista3[0].CompareTo(lista3[1]) > 0) {
      Aluno aux = lista3[0];
      lista3[0] = lista3[1];
      lista3[1] = aux;
    }
    if (lista3[0].CompareTo(lista3[2]) > 0) {
      Aluno aux = lista3[0];
      lista3[0] = lista3[2];
      lista3[2] = aux;
    }
    if (lista3[1].CompareTo(lista3[2]) > 0) {
      Aluno aux = lista3[1];
      lista3[1] = lista3[2];
      lista3[2] = aux;
    }
    // Código executado dentro do Sort
    
    Console.WriteLine("Listagem de Alunos");

    foreach(Aluno obj in lista3)
      Console.WriteLine(obj);

    Console.WriteLine("------------------");

    //Aluno[] vetor = new Aluno[10];
    //Array.Sort(vetor); // Método de classe - static

    Professor p1 = new Professor("Gilbert", "InfoWeb", DateTime.Parse("2000-01-01"));
    Professor p2 = new Professor("Danielle", "InfoWeb", DateTime.Parse("2000-05-01"));
    Professor p3 = new Professor("Minora", "InfoWeb", DateTime.Parse("2000-01-05"));
    Console.WriteLine(p1.GetNome());
    Console.WriteLine(p2.GetNome());
    Console.WriteLine(p3.GetNome());

    List<IPessoa> lista4 = new List<IPessoa>();
    lista4.Add(a1);
    lista4.Add(a2);
    lista4.Add(a3);
    lista4.Add(p1);
    lista4.Add(p2);
    lista4.Add(p3);
    foreach(IPessoa obj in lista4)
      Console.WriteLine(obj.GetNome());

    object ref1      = new Aluno("Gustavo", "123");
    IPessoa ref2     = new Aluno("Gustavo", "456");
    IComparable ref3 = new Aluno("Gustavo", "789");
    Aluno ref4       = new Aluno("Gustavo", "012");
 
    Console.WriteLine(ref1.ToString());
    //Console.WriteLine(ref1.GetNome());
    Console.WriteLine(ref2.GetNome());
    //Console.WriteLine(ref2.GetMatricula());
    Console.WriteLine(ref3.CompareTo(a1));
    Console.WriteLine(ref4.GetMatricula());

    IPessoa pes1 = new Aluno("Lindemberg", "123");
    IPessoa pes2 = new Professor("Gilbert", "456", DateTime.Parse("2000-01-01"));

    Console.WriteLine(pes1.GetNome());
    Console.WriteLine(pes2.GetNome());

    ListaAniversariantes la = new ListaAniversariantes();
    IAniversariante[] vetor = { p1, p2, p3 };
    la.MostrarLista(vetor, 1);
  }
}

/*
  class List<T> {
    public void Add(T obj) {

    }
  }
*/

interface IAniversariante {
  string GetNome();
  DateTime GetNascimento();
}

class ListaAniversariantes {
  public void MostrarLista(IAniversariante[] vetor, int mes) {
    foreach(IAniversariante obj in vetor) {
      if (obj.GetNascimento().Month == mes) 
        Console.WriteLine($"{obj.GetNome()} - {obj.GetNascimento():dd/MM}");
    }
  }
}

class ListaAniversariantesProfessor {
  public void MostrarLista(Professor[] vetor, int mes) {
    foreach(IAniversariante obj in vetor) {
      if (obj.GetNascimento().Month == mes) 
        Console.WriteLine($"{obj.GetNome()} - {obj.GetNascimento():dd/MM}");
    }
  }
}
/*
class ListaAniversariantesAluno {
  public void MostrarLista(Aluno[] vetor, int mes) {
    foreach(IAniversariante obj in vetor) {
      if (obj.GetNascimento().Month == mes) 
        Console.WriteLine($"{obj.GetNome()} - {obj.GetNascimento():dd/MM}");
    }
  }
}
*/

class X<T> {
  private T atributo;
  public void SetAtributo(T valor) {
    atributo = valor;
  }
  public T GetAtributo() {
    T variavel;
    variavel = atributo;
    return variavel;
  }
}

/*
interface IComparable {
  int CompareTo(object obj);
}
interface IComparable<T> {
  int CompareTo(T obj);
}
*/

interface IPessoa {
  string GetNome();
}

class Professor : IPessoa, IAniversariante {
  private string nome, curso;
  private DateTime nascimento;
  public Professor(string n, string c, DateTime nasc) {
    nome = n;
    curso = c;
    nascimento = nasc;
  }
  public string GetNome() {
    return nome;
  }
  public DateTime GetNascimento() {
    return nascimento;
  }
  public override string ToString() {
    return $"{nome} - {curso}";
  }
}

class Aluno : IPessoa, IComparable, IComparable<Aluno> {
  private string nome, matricula;
  public Aluno(string n, string m) {
    nome = n;
    matricula = m;
  }
  public string GetNome() {
    return nome;
  }
  public string GetMatricula() {
    return matricula;
  }
  public override string ToString() {
    return $"{nome} - {matricula}";
  }
  public int CompareTo(object obj) {
    // Console.WriteLine(obj.nome);
    Aluno x = (Aluno) obj;  // Typecast
    int r = this.nome.CompareTo(x.nome); 
    //if (this.nome.CompareTo(x.nome) == -1) return -1;
    //if (this.nome.CompareTo(x.nome) == 1) return 1;
    //return 0;
    Console.WriteLine(this.nome + " - " + x.nome + ": " + r);
    return this.nome.CompareTo(x.nome);
    //return this.matricula.CompareTo(x.matricula);
  }
  public int CompareTo(Aluno obj) {
    //int r = this.nome.CompareTo(obj.nome); 
    //if (this.nome.CompareTo(x.nome) == -1) return -1;
    //if (this.nome.CompareTo(x.nome) == 1) return 1;
    //return 0;
    // Console.WriteLine(this.nome + " - " + obj.nome + ": " + r);
    return this.nome.CompareTo(obj.nome);
    //return this.matricula.CompareTo(x.matricula);
  }
}



