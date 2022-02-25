using System;

class Program {
  public static void Main() {
    try {
      int a = int.Parse(Console.ReadLine());
      int b = int.Parse(Console.ReadLine());
      int c = a / b;
      Console.WriteLine(c);
    }
    catch(FormatException erro) {
      Console.WriteLine("Não foi informado um valor inteiro: "
        + erro.Message);
    }
    catch(OverflowException erro) {
      Console.WriteLine("Valor informado é muito grande/pequeno: "
        + erro.Message);
    }
    //catch (Exception) {}
    catch {
      Console.WriteLine("Deu outro tipo de erro");
    }
  }
}