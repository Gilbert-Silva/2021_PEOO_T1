using System;

class Program {
  public static void Main() {
    Aluno a1 = new Aluno();
    a1.SetNome("Erick");
    a1.SetMatricula("567986");
    a1.SetIdade(18);

    // Console.WriteLine("Informe sua idade");
    // int x = int.Parse(Console.ReadLine());
    // a1.SetIdade(x);

    // int x = 0;
    // int.TryParse(Console.ReadLine(), out x); 
    // x -> var ou atributo
    // a1.SetIdade(x); // ref ou out

    Console.WriteLine(a1.GetNome());
    Console.WriteLine(a1.GetMatricula());
    Console.WriteLine(a1.GetIdade());

    Aluno a2 = new Aluno();
    a2.SetNome("Akira");
    a2.SetMatricula("867986");
    a2.SetIdade(17);
    Console.WriteLine(a2.GetNome());
    Console.WriteLine(a2.GetMatricula());
    Console.WriteLine(a2.GetIdade());

    Aluno2 b1 = new Aluno2();
    b1.Nome = "Antoniella";
    b1.Matricula = "0987098";
    b1.Idade = 18; // SET
    // int.TryParse(Console.ReadLine(), out b1.Idade); 
    // x -> var ou atributo: ref ou out
    Console.WriteLine(b1.Nome);
    Console.WriteLine(b1.Matricula);
    Console.WriteLine(b1.Idade); // GET

    // Aluno2 b2 = new Aluno2("Hélio", "2542345", 17);
    Aluno2 b2 = new Aluno2 {
      Nome = "Hélio",           // SET
      Matricula = "2542345", 
      Idade = 17
    };
    Console.WriteLine(b2.Nome); // GET
    Console.WriteLine(b2.Matricula);
    Console.WriteLine(b2.Idade);

    Aluno3 c1 = new Aluno3 {
      Nome = "Laiz",           // SET
      Matricula = "6347634", 
      Idade = 17
    };
    Console.WriteLine(c1.Nome); // GET
    Console.WriteLine(c1.Matricula);
    Console.WriteLine(c1.Idade);

    Aluno3 c2 = new Aluno3 {
      Nome = "Leonardo",           // SET
      Matricula = "6734567", 
      Idade = 18
    };
    Console.WriteLine(c2.Nome); // GET
    Console.WriteLine(c2.Matricula);
    Console.WriteLine(c2.Idade);

  }
}

class Aluno { // Atributo e Método
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
  /*
  public int GetIdade() {
    return idade;
  }
  */
  public int GetIdade() => idade;
}

class Aluno2 { // Atributo e Propriedade (substituem os métodos)
  private string nome;
  private string matricula;
  private int idade;
  public string Nome {
    set { this.nome = value; }
    // get { return nome; }
    get => nome;
  }
  public string Matricula {
    set { this.matricula = value; }
    get { return matricula; }
  }
  public int Idade {
    set => this.idade = value >= 0 ? value : 0;  
    get => idade;
  }
  /*
  public int Idade {
    set { 
          if (value > 0) 
            this.idade = value;
          else
            this.idade = 0;
        }
    //set { this.idade = value >= 0 ? value : 0; } 
        // ?  Op. condicional ternário
        // => Operador lambda
    // get { return idade; }
  }
  */
}

// Propriedade auto implementada - Validação em outro local 
class Aluno3 { 
  public string Nome { get; set; }
  public string Matricula { get; set; }
  public int Idade { get; set; }
}

