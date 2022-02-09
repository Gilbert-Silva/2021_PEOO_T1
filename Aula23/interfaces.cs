using System;

class Program {
  public static void Main() {
    
    Aluno a1 = new Aluno();
    a1.SetNome("Erick");
    a1.SetMatricula("567986");
    a1.SetIdade(18);
    
    Aluno a2 = new Aluno();
    a2.SetNome("Akira");
    a2.SetMatricula("867986");
    a2.SetIdade(17);

    Aluno[] va = { a1, a2 };
    Array.Sort(va);
    foreach(Aluno a in va) {
      Console.Write(a.GetNome() + " - ");
      Console.Write(a.GetMatricula() + " - ");
      Console.WriteLine(a.GetIdade());    
    }

    int[] vi = { 10, 4, 5, 2, 8, 1 };
    Array.Sort(vi);
    foreach(int i in vi)
      Console.WriteLine(i);

    Console.WriteLine(1.CompareTo(2));
    Console.WriteLine(2.CompareTo(2));
    Console.WriteLine(2.CompareTo(1));

    Console.WriteLine(a1.CompareTo(a2));
    Console.WriteLine(a2.CompareTo(a2));
    Console.WriteLine(a2.CompareTo(a1));

  }
}

interface IComparable {
  int CompareTo(object obj);
}


class Aluno : IComparable { // Atributo e Método
  private string nome;
  private string matricula;
  private int idade;
  public void SetNome(string value) {
    this.nome = value;
  }  
  public void SetMatricula(string value) {
    this.matricula = value;
  }  
  public void SetIdade(int value) {
    if (value > 0) this.idade = value;
  }  
  public string GetNome() {
    return nome;
  }
  public string GetMatricula() {
    return matricula;
  }
  public int GetIdade() {
    return idade;
  }
  public int CompareTo(object obj) {
    // Type cast
    Aluno a = (Aluno) obj;
    if (this.idade < a.idade) return -1;
    if (this.idade > a.idade) return 1;
    return 0;
  }
}