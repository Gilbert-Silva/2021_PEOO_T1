using System;

class Program {
  public static void Main() {
    Console.WriteLine("Digite seu nome");
    string nome = Console.ReadLine();
    /*
    int i;
    do {
      i = nome.IndexOf("  ");
      //Console.WriteLine(i);
      if (i != -1) nome = nome.Remove(i, 1);
    } while (i != -1);  
    */
    //Console.WriteLine(nome);
    nome = Formatar(nome);

    Console.WriteLine("Digite a cidade onde nasceu");
    string cidade = Console.ReadLine();
    /*
    do {
      i = cidade.IndexOf("  ");
      //Console.WriteLine(i);
      if (i != -1) cidade = cidade.Remove(i, 1);
    } while (i != -1);  
    */
    cidade = Formatar(cidade);

    Console.WriteLine($"Nome: {nome} - Cidade: {cidade}");
  }

  public static string Formatar(string s) {
    int i;
    do {
      i = s.IndexOf("  ");
      //Console.WriteLine(i);
      if (i != -1) s = s.Remove(i, 1);
    } while (i != -1);  
    return s;   
  }

}