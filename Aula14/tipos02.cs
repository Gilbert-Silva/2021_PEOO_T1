using System;
using System.Globalization;
using System.Threading;

class Program {
  public static void Main() {
    Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
    //int x = 1;
    //double y = 1.5;
    DateTime z = DateTime.Now; 
    Console.WriteLine(z);
    DateTime d = DateTime.Parse("08/10/2021");
    Console.WriteLine(d.Day);
    Console.WriteLine(d.Month);
    Console.WriteLine(d.Year);
    //d.Day = 30;
    Console.WriteLine(d);
    string s = "Gustavo";
    Console.WriteLine(s.Length);
    TimeSpan x = TimeSpan.Parse("1.10:00:00");
    Console.WriteLine(x);
    Console.WriteLine(d + 3 * x);



    

  }
}
