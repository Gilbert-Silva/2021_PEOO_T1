using System;

class Program {
  public static void Main() {
    // string linha = Console.ReadLine(); // Número de botas
    string linha;
    while (!string.IsNullOrEmpty(linha = Console.ReadLine()))
    {
      int[] ldir = new int[61]; // 0 - 60
      int[] lesq = new int[61];
      int n = int.Parse(linha);
      for (int i = 0; i < n; i++) {
        string s = Console.ReadLine();
        string[] v = s.Split(' ');
        int num = int.Parse(v[0]);
        string lado = v[1];
        if (lado == "E") lesq[num] =  lesq[num] + 1;
        if (lado == "D") ldir[num] =  ldir[num] + 1;
      }
      int total = 0;
      for (int k = 30; k <= 60; k++) {
        total = total + Math.Min(lesq[k], ldir[k]);
        //Console.WriteLine($"Tam={k} Esq={lesq[k]} Dir={ldir[k]} Total={total}");
      }
      Console.WriteLine(total);
    }
  }
}
