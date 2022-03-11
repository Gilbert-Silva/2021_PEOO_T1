using System;
using System.Collections.Generic;

class Program {
  public static void Main() {
    Pessoa x = new Professor {Nome = "José Álvaro", Diretoria = "Diatinf" };
    Console.WriteLine(x.Nome);
    //Console.WriteLine(x.Diretoria);
    //x.Diretoria = "Diatinf";

    Professor y = x as Professor;
    Console.WriteLine(y.Diretoria);
  

    /*
    


    
    Aluno a1 = new Aluno { Nome = "Akira", Curso = "InfoWeb" };
    Aluno a2 = new Aluno { Nome = "Antoniella", Curso = "InfoWeb" };
    Aluno a3 = new Aluno { Nome = "Elizia", Curso = "InfoWeb" };
    //Console.WriteLine(a1);
    //Console.WriteLine(a2);
    //Console.WriteLine(a3);

    Professor p1 = new Professor { Nome = "Gilbert", Diretoria = "Diatinf" };
    Professor p2 = new Professor { Nome = "Danielle", Diretoria = "Diatinf" };
    //Console.WriteLine(p1);
    //Console.WriteLine(p2);
    
    Escola escola = new Escola();
    escola.AddAluno(a1);
    escola.AddAluno(a2);
    escola.AddAluno(a3);
    escola.AddProfessor(p1);
    escola.AddProfessor(p2);

    foreach(Pessoa p in escola.ListarPessoas())
      Console.WriteLine(p);

    Console.WriteLine();
    
    foreach(Aluno a in escola.ListarAlunos())
      Console.WriteLine(a);

    /*
    Aluno x = new Professor();
    Aluno x = new Pessoa();
    Aluno x = new Aluno();
    x.Curso = "Infoweb"

    Pessoa y = new Aluno();
    x.Curso = "Infoweb"
    */
  }
}

class Escola {
  private List<Pessoa> pessoas = new List<Pessoa>();
  public void AddAluno(Aluno a) {
    pessoas.Add(a);
  }
  public void AddProfessor(Professor p) {
    pessoas.Add(p);
  }
  public List<Pessoa> ListarPessoas() {
    return pessoas;
  }
  public List<Aluno> ListarAlunos() {
    List<Aluno> r = new List<Aluno>();
    foreach(Pessoa p in pessoas)
      if (p is Aluno) r.Add(p as Aluno);
    return r;
  }
  public List<Professor> ListarProfessores() {
    return null;
  }
}

class Pessoa : object {
  public string Nome { get; set; }  
  public override string ToString() {
    return $"{Nome}";
  }
}

class Aluno : Pessoa {
  public string Curso { get; set; }
  public override string ToString() {
    return $"{base.ToString()} - {Curso}";
  }
}

class Professor : Pessoa {
  public string Diretoria { get; set; }
  public override string ToString() {
    return $"{base.ToString()} - {Diretoria}";
  }
}
