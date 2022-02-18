using System;
using System.Collections.Generic;

class Program {
  public static void Main() {
    Aluno a1 = new Aluno {Nome="Gustavo"};
    Aluno a2 = new Aluno {Nome="Antoniella"};

    Turma t = new Turma();
    t.Inserir(a1);
    t.Inserir(a1);
    t.Inserir(a2);
    t.Inserir(a2);
    foreach(Aluno a in t.Listar())
      Console.WriteLine(a.Nome);

  }
}

class Turma {
  private List<Aluno> alunos = new List<Aluno>();
  public void Inserir(Aluno a) {
    if (alunos.IndexOf(a) == -1)
      alunos.Add(a);
  }
  public List<Aluno> Listar() {
    return alunos;
  }
}

class Aluno {
  public string Nome {get;set;}
}