  class Carrinho
  {
    private Produto[] prods = new Produto[50];
    private int auxiliar = 0;
    public void inserir(Produto p)/*Inserir: insere um novo produto no carrinho (máximo 50);*/
    {
      string a; 
           
      if(auxiliar <= prods.Length)
      {
        //a = Console.ReadLine();
        prods[auxiliar] = p;
        auxiliar++;
      }
    }
    public Produto[] Listar()/*Listar: retorna um vetor os produtos inseridos até o momento;*/
    {
      Produto[] vetor = new Produto[auxiliar];
      Array.Copy(prods, vetor, auxiliar);
      return vetor;
    }
    public double somar()/*Somar: retorna o total financeiro da compra obtido a partir da quantidade comprada e do preço dos produtos
inseridos no carrinho.*/
    {
      double soma = 0;
      double x;
      for(int i = 0; i < auxiliar; i++)
      {
        x = prods[i].Getquantidade() * prods[i].Getpreço();
        soma = soma + x;
      }
        return soma;
    }
  }  




