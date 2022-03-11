using System;  //package - namespace
using System.Collections;
using System.Collections.Generic;

class Program {
  public static void Main() {
    // string s = null;
    string s = "Informática";
    Console.WriteLine(s.IndexOf('f'));
    List<int> v = new List<int>();
    v.Add(1);
    v.Add(2);
    v.Add(3);

    IEnumerator it = v.GetEnumerator();
    it.MoveNext();
    // v.Add(4);
    Console.WriteLine(it.Current);
    it.MoveNext();
    Console.WriteLine(it.Current);
    it.MoveNext();
    Console.WriteLine(it.Current);
/*
    //int[] w = { 1, 2, 3 };
    //Console.WriteLine(w[10]);
    try {
      int x = int.Parse(Console.ReadLine());
      Console.WriteLine(1/x);
    }
    catch {
      //int z = 0;
      //Console.WriteLine(x);
    }
    //Console.WriteLine(z);
*/
    int y = 0;
    bool ok = false;
    do {
      //bool ok = false;
      try {
        y = int.Parse(Console.ReadLine());
        ok = true;
      }
      //catch { }
      catch (Exception erro) {
        Console.WriteLine(erro.Message);
      }
    } while (!ok);
    
    Console.WriteLine(s);
    
    
  }
}