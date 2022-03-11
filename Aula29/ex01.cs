using System;
using System.Collections;
using System.Collections.Generic;

class Program {
  public static void Main() {
    ArrayList a = new ArrayList();
    a.Add(1);
    a.Add("Texto");
    a.Add(new Produto {id = 1});
    a.Add(new Jogo {id = 2, midia="dvd"});
    a.Add(new HQ {id = 3, paginas = 50});
    foreach(object obj in a)
      Console.WriteLine(obj);

    List<Produto> b = new List<Produto>();
    //b.Add(1);
    //b.Add("Texto");
    b.Add(new Produto {id = 1});
    b.Add(new Jogo {id = 2, midia="dvd"});
    b.Add(new HQ {id = 3, paginas = 50});
    foreach(object obj in b)
      Console.WriteLine(obj);
  }
}

class Produto {
  public int id {get; set;}
}
class Jogo : Produto {
  public string midia { get; set; }
}
class HQ : Produto {
  public int paginas { get; set; }
}
