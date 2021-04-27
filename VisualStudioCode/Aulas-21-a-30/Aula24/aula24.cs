using System;

class Aula24 {
  static void Main(){ // se o Main() é static, os demais métodos dentro da mesma classe de ser static
    int v1, v2, ret;

    cfb(); // chamado o método cfb()
    // cfb();

    // for (int i = 0; i <10; i++) {
    //   cfb();
    // }

    soma(10,5);

    v1 = Convert.ToInt32(Console.ReadLine());
    v2 = Convert.ToInt32(Console.ReadLine());
    soma(v1, v2);

    ret = soma2(v1, v2); // retorno do método soma2() é incluído na variável ret
    Console.WriteLine("A soma de {0} e {1} é: {2}", v1, v2, ret);
    Console.WriteLine("A soma de {0} e {1} é: {2}", v1, v2, soma2(v1, v2));
  }

  // métodos são um bloco de instruções que são chamados no programa principal Main()
  static void cfb() {
    Console.WriteLine("Método cfb()");
    Console.WriteLine("Curso de C#");
  }

  static void soma(int n1, int n2) {
    int res = n1 + n2;

    Console.WriteLine("Método soma()");
    Console.WriteLine("A soma de {0} e {1} é: {2}", n1, n2, res);
  }

  static int soma2(int n1, int n2) { // deve ser dado o retorno do mesmo tipo int, string, double, etc.
    int res = n1 + n2;

    Console.WriteLine("Método soma2()");

    return res; // como vai retornar um valor, deve ser incluído em uma variável
  }
}