using System;
using System.Collections.Generic;

class Program {
  public static void Main() {
    int[] v = { 8, 4, 3, 6, 1 };
    List<int> l = new List<int> { 8, 4, 3, 6, 1 };

    Array.Sort(v); // Sort é métido estático (classe)
    foreach(int i in v) Console.WriteLine(i);
    Console.WriteLine();

    l.Sort(); // Sort é um método de instância
    foreach(int i in l) Console.WriteLine(i);

    Console.WriteLine();

    List<Aluno> la = new List<Aluno>();
    Aluno obj  = new Aluno { Id = 1, Nome = "Vinícius"};
    la.Add(obj);
    //la.Add(new Aluno { Nome = "Vinícius"});
    la.Add(new Aluno { Id = 2, Nome = "Pedro"});
    la.Add(new Aluno { Id = 3, Nome = "Luisa"});

    la.Remove(obj);
    //la.Remove(new Aluno { Nome = "Vinícius"});

    Aluno r = null;
    foreach(Aluno a in la)
      if (a.Nome == "Pedro") r = a;
    la.Remove(r);

    r = null;
    foreach(Aluno a in la)
      if (a.Id == 3) r = a;
    la.Remove(r);

    
    la.Sort(); // Sort é um método de instância
    foreach(Aluno a in la) Console.WriteLine(a.Nome);
  }
}

// Entity Framework - Banco de Dados Relacional

class Sistema {
  private static List<Aluno> alunos = new List<Aluno>();
  private static List<Turma> turmas = new List<Turma>();
}

class AlunoDAL {
  private static List<Aluno> alunos = new List<Aluno>();
}

class TurmaDAL {
  private static List<Turma> turmas = new List<Turma>();
}

class Aluno : IComparable<Aluno> {
  private static List<Aluno> alunos = new List<Aluno>();
  public int Id { get; set; }
  public string Nome { get; set; }
  public int IdTurma { get; set; }
  public Turma turma { get; set; }  // Uma Turma
  public int CompareTo(Aluno obj) {
    return Nome.CompareTo(obj.Nome);
  }
}

class Turma {
  private static List<Turma> turmas = new List<Turma>();
  public int Id { get; set; }
  public string Disciplina {get; set;}
  public List<Aluno> alunos { get; set; } // Vários alunos
}



