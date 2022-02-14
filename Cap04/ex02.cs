using System;
using System.Collections;

class Program {
  public static void Main() {
    Colecao<int> li = new Colecao<int>();
    li.Add(40);
    li.Add(10);
    li.Add(20);
    li.Add(30);
    foreach(int i in li.ToArray())
      Console.WriteLine(i);
    //li.Remove(10);  
    li.Sort();
    foreach(int i in li.ToArray())
      Console.WriteLine(i);

    Colecao<string> ls = new Colecao<string>();
    ls.Add("C#");
    ls.Add("Java");
    ls.Add("C++");
    ls.Add("Python");
    foreach(string s in ls.ToArray())
      Console.WriteLine(s);
    // ls.Remove("Python");
    ls.Sort();
    foreach(string s in ls.ToArray())
      Console.WriteLine(s);
    foreach(string s in ls)
      Console.WriteLine(s);
    Console.WriteLine(ls.Count);  
  }
}

class Colecao<T> : IEnumerable where T : IComparable {
  private T[] vetor = new T[50];
  private int k;
  public int Count { get { return k; } }
  public void Add(T obj) {
    if (k < 50) vetor[k] = obj;
    k++;
  }
  public void Remove(T obj) {
    int index = -1;
    for (int i = 0; i < k; i++) {
      if (vetor[i].Equals(obj)) index = i; // == não está
      // implementado para todos os tipos
    }
    if (index != -1) {
      for (int i = index; i < k - 1; i++)
        vetor[i] = vetor[i + 1];
      k--;  
    }
  }
  public T[] ToArray() {
    T[] aux = new T[k];
    Array.Copy(vetor, aux, k);
    return aux;
  }
  public void Sort() {
    T[] aux = new T[k];
    Array.Copy(vetor, aux, k);
    Array.Sort(aux);
    for(int i = 0; i < k; i++)
      vetor[i] = aux[i];
  }
  public IEnumerator GetEnumerator() {
    T[] aux = new T[k];
    Array.Copy(vetor, aux, k);
    return aux.GetEnumerator();    
  }
}

