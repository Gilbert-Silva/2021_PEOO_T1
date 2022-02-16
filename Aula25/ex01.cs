using System;
using System.Collections.Generic;

class Program {
  public static void Main() {
    //int x;
    //Console.WriteLine(x);
    // Array - Tam inicial informado
    // Elementos são acessados com um índice
    Console.WriteLine("Vetor");
    int[] vi = new int[5];
    foreach(int i in vi) Console.WriteLine(i);
    vi[0] = 5;
    vi[1] = 10;
    vi[2] = 3;
    vi[3] = 9;
    foreach(int i in vi) Console.WriteLine(i);
    Console.WriteLine(vi[0]);
    Console.WriteLine(vi[1]);
    Console.WriteLine(vi[2]);
    Console.WriteLine(vi[3]);
    Console.WriteLine(vi[4]);
    for(int k = 0; k < 5; k++)
      Console.WriteLine(vi[k]);

    Console.WriteLine("Lista");
    // List - Vetor dinâmico: tamanho é alterado qdo os elementos 
    // Elementos são acessados com um índice
    List<int> li = new List<int>();
    //List<string> ls = new List<string>();
    //int[] wi = new int[10];
    //string[] ws = new string[10];
    foreach(int i in li) Console.WriteLine(i);
    li.Add(8);
    li.Add(18);
    li.Add(6);
    li.Add(3);
    li.Add(2);
    foreach(int i in li) Console.WriteLine(i);
    Console.WriteLine("Inserindo um vetor");
    li.AddRange(vi);
    foreach(int i in li) Console.WriteLine(i);
    Console.WriteLine("Inserindo uma lista");
    li.AddRange(li);
    foreach(int i in li) Console.WriteLine(i);
   
    Aluno[] va = new Aluno[5];
    foreach(Aluno a in va) Console.WriteLine(a);

    string[] vs = new string[5];
    foreach(string s in vs) Console.WriteLine(s);
  }
}

class Aluno {
}