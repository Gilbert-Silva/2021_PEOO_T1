using System;

class Program {
  public static void Main(string[] args) {
    //int x = 5;
    // v é um vetor com 10 elementos
    // cada elemento é um inteiro
    /*
    Console.WriteLine(args.Length);
    if (args.Length >= 1)
      Console.WriteLine(args[0]);
    if (args.Length >= 2)
      Console.WriteLine(args[1]);
    */  
    int[] v = new int[10];
    //int v[0], v[1], v[2].... v[9];
    /*
    Console.WriteLine($"Length = {v.Length}");
    v[0] = 10;
    for (int k = 0; k <= 9; k++)
      Console.WriteLine($"v[{k}] = {v[k]}");
    */
    int[,] w = new int[3,4];
    w[2,1] = 5;
    for (int l = 0; l < 3; l++)
    {
      for (int c = 0; c < 4; c++)
        Console.Write($"{w[l,c]}    ");
      Console.WriteLine();  
    }
    /*
    Console.Write($"{w[0,0]}    ");
    Console.Write($"{w[0,1]}    ");
    Console.Write($"{w[0,2]}    ");
    Console.Write($"{w[0,3]}    ");
    Console.WriteLine();
    Console.Write($"{w[1,0]}    ");
    Console.Write($"{w[1,1]}    ");
    Console.Write($"{w[1,2]}    ");
    Console.Write($"{w[1,3]}    ");
    Console.WriteLine();
    Console.Write($"{w[2,0]}    ");
    Console.Write($"{w[2,1]}    ");
    Console.Write($"{w[2,2]}    ");
    Console.Write($"{w[2,3]}    ");
    */

/*      

  
    Console.WriteLine(v[0]);
    Console.WriteLine(v[1]);
    Console.WriteLine(v[2]);
    Console.WriteLine(v[3]);
    Console.WriteLine(v[4]);
    Console.WriteLine(v[5]);
    Console.WriteLine(v[6]);
    Console.WriteLine(v[7]);
    Console.WriteLine(v[8]);
    Console.WriteLine(v[9]);
*/


  }
}