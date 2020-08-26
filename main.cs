using System;

class MainClass {

  public static void Main (string[] args) {
    Ex02();
  }

  // Exercicio 1
  public static void Ex01(){

    Console.Write("Informe primeiro numero: ");
    float n1 = float.Parse( Console.ReadLine() );

    Console.Write("Informe segundo numero: ");
    float n2 = float.Parse( Console.ReadLine() );

    Console.WriteLine("[ + ] -> Soma");
    Console.WriteLine("[ - ] -> Subtração");
    Console.WriteLine("[ * ] -> Multiplicação");
    Console.WriteLine("[ / ] -> Divisão");
    Console.Write("Informe a operação: ");
    char carcter = char.Parse( Console.ReadLine() );
  
    switch( carcter ){

      case '+':
        Console.WriteLine( "A Soma e: {0}", n1 + n2 );
      break;

      case '-':
        Console.WriteLine( "A Subtração e: {0}", n1 - n2 );
      break;

      case '*':
        Console.WriteLine( "A Multiplicação e: {0}", n1 * n2 );
      break;

      case '/':
        Console.WriteLine( "A Divisão e: {0}", n1 / n2 );
      break;

      default:
        Console.WriteLine( "Caracter invalido !" );
      break;
      
    }

  }

  //Exercicio 2
  public static void Ex02(){

    Console.WriteLine("---------------------------------");
    Console.WriteLine("100  Cachorro quente   R$ 1,70 ");
    Console.WriteLine("101   Bauru Simples    R$ 2,30 ");
    Console.WriteLine("102   Bauru com ovo    R$ 2,60 ");
    Console.WriteLine("103   Hamburguer       R$ 2,40 ");
    Console.WriteLine("104   Cheeseburguer    R$ 2,50 ");
    Console.WriteLine("105   Refrigerante     R$ 1,00 ");
    Console.WriteLine("----------------------------------\n");

    Console.Write("Informe o Codigo do Produto: ");
    int codigo = int.Parse( Console.ReadLine() );

    Console.Write("Informe a quantidade: ");
    int qtd = int.Parse( Console.ReadLine() );

    if( codigo == 100 ){
      Console.WriteLine( "Valor Total: {0}", 1.70 * qtd );
    }else if( codigo == 101){
      Console.WriteLine( "Valor Total: {0}", 2.30 * qtd );
    }else if( codigo == 102){
      Console.WriteLine( "Valor Total: {0}", 2.60 * qtd );
    }else if( codigo == 103){
      Console.WriteLine( "Valor Total: {0}", 2.40 * qtd );
    }else if( codigo == 104){
      Console.WriteLine( "Valor Total: {0}", 2.50 * qtd );
    }else if( codigo == 105){
      Console.WriteLine( "Valor Total: {0}", 1.00 * qtd );
    }else{
      Console.WriteLine( "Codigo Invalido !" );
    }

  }


  //Exercicio 3
  public static void Ex03(){



  }

}