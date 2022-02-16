using System;
using System.Collections;
using System.Collections.Generic;

class Program {
  public static void Main() {
    // Vetor dinâmico não genérico - object
    ArrayList v = new ArrayList();
    v.Add("C#");
    v.Add(16);
    v.Add("Fevereiro");
    v.Add(2022);
    foreach(object obj in v)
      Console.WriteLine(obj);

    // Vetor dinâmico genérico - preciso informar o tipo dos elementos
    List<int> w = new List<int>(); // Parâmetro de tipo
    w.Add(2022);
    w.Add(16);
    w.Add(2);
    w.Add(2022);
    foreach(int obj in w)
      Console.WriteLine(obj);
  }
}

