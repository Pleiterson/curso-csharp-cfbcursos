using System;

class Aula03a10 {
  static void Main(){
    aula03();
    aula05();
    aula06();
    aula07();
    aula08();
    aula09();
    aula10();
  }

  static void aula03() {
    Console.WriteLine("\nExplicações aula 03");

    byte n1 = 10; // byte, varia de 0 e 255
    int num = 0; // inteiro
    char letra = 'c'; // char
    float valor = 5.3f; // ponto flutuante
    string nome = "Pleiterson"; // string, possui vários caracteres (char), deve ser informado com aspas duplas

    var aux = "Curso C#"; // variável padrão, a variável vai se comportar conforme o valor inserido
    var aux1 = nome;

    Console.WriteLine(aux1); // imprimindo na tela uma variável
    Console.WriteLine("A variável é: " + aux1 + "..."); // + concatena uma variável com um texto

    // declarando mais de uma variável
    int num1, num2, res; // pode iniciar com valores
    
    num1 = 10;
    num2 = 2;
    res = num1 * num2; // operação de multiplicação com o resultado sendo armazendo na variável "res"
    Console.WriteLine("A multiplicação de " + num1 + " com " + num2 + " é igual a: " + res);

    // podemos realizar a operação na ora de imprimir uma mensagem, assim economiza declaração de variáveis
    Console.WriteLine("A soma de " + num1 + " com " + num2 + " é igual a: " + (num1 + num2));
  }

  static void aula05() {
    Console.WriteLine("\nExplicações aula 05");

    // operadores matemáticos: + - * /
    int res1 = (10+5)*2; // realizando uma operação matemática e atribuindo o valor a variável "res1"

    // operadores relacionais: > < >= <= != 
    bool res2 = 10 < 5; // realizando uma operação booleana (verdadeiro/falso) e atribuindo o valor a variável "res2"
    bool res3 = 10 > 5; // realizando uma operação booleana (verdadeiro/falso) e atribuindo o valor a variável "res3"

    // operações de incremento ou decremento
    int al5num1 = 10;
    int al5num2 = 10;
    int al5num3 = 10;
    
    // todos as 3 operações abaixo são iguais
    al5num1 = al5num1 + 1; // pode ser incluído qualquer valor para esta operação e também para + - * /
    al5num2 += 1; // pode ser incluído qualquer valor para esta operação e também para + - * /
    al5num3++; // funciona apenas para acrescentar 1, não pode ser usado para números maiores que 1

    // operadores lógicos: & and, e (and, retorna true, se todas as condições for true) -- | or, ou (or, retorna false, se todas as condições for false)
    bool res4 = (5>3) | (10<5); // retornará true, pois tem uma verdade com OU. (5>3) true, e (10<5) false
    bool res5 = (5>7) | (10<5); // retornará false, pois têm duas verdades com OU. (5>7) false, e (10<5) false
    bool res6 = (5>7) & (10<5); // retornará false, pois têm duas verdades com AND. (5>7) false, e (10<5) false
    bool res7 = (5>3) & (10<5); // retornará false, pois tem uma verdade com AND. (5>3) true, e (10<5) false
    bool res8 = (5>3) & (10>5); // retornará true, pois tem uma verdade com AND. (5>3) true, e (10>5) true

    Console.WriteLine("O resultado da variável 1 é: " + res1);
    Console.WriteLine("O resultado da variável 2 é: " + res2);
    Console.WriteLine("O resultado da variável 3 é: " + res3);
    Console.WriteLine("O resultado da operação (num=num+1) é: " + al5num1);
    Console.WriteLine("O resultado da operação (num+=1) é: " + al5num2);
    Console.WriteLine("O resultado da operação (num++) é: " + al5num3);
    Console.WriteLine("O resultado da variável 4 é: " + res4);
    Console.WriteLine("O resultado da variável 5 é: " + res5);
    Console.WriteLine("O resultado da variável 6 é: " + res6);
    Console.WriteLine("O resultado da variável 7 é: " + res7);
    Console.WriteLine("O resultado da variável 8 é: " + res8);
  }

  static void aula06() {
    Console.WriteLine("\nExplicações aula 06");

    int n1, n2, n3;
    double valorCompra = 5.50;
    double valorVenda;
    double lucro = 0.1;
    string produto = "Pastel";

    n1 = 10; n2 = 20; n3 = 30;
    valorVenda = valorCompra + (valorCompra * lucro);

    // Write não possui quebra de linha ao imprimir na tela
    // WriteLine possui quebra de linha ao imprimir na tela
    Console.WriteLine(n1 + ", " + n2 + ", " + n3); // impressão tradicional
    Console.WriteLine("n1={0}, n2={1}, n3={2}", n1,n2,n3); // impressão por índice, vetores
    Console.WriteLine("---\nn1={0}\nn2={1}\nn3={2}\n---", n1,n2,n3); // \n é a quebra de lina
    Console.WriteLine("n1=\t{0}\nn2=\t{1}\nn3=\t{2}\n---", n1,n2,n3); // \t é a uma tabulação (espaço/tab) 
    Console.WriteLine("Produto..............:{0,15}", produto); // 15 é o tamanho do espaço entre o texto e o valor da variável
    Console.WriteLine("Valor Compra.........:{0,15:c}", valorCompra); // c é o formato de valor monetário
    Console.WriteLine("Lucro................:{0,15:p}", lucro); // p é o formato de valor porcentagem
    Console.WriteLine("Valor Venda..........:{0,15:c}", valorVenda); // p é o formato de valor porcentagem
  }

  static void aula07() {
    Console.WriteLine("\nExplicações aula 07");

    // as regras para as declarações de constantes são as mesmas para as declarações de variáveis. O valor
    // de uma constante não pode ser alterado ao longo da execução do programa, ao contrário de uma variável
    // a declaração de uma constante utiliza-se as palavra reservada "const"

    const string canal = "CFBCursos";
    const double pi = 3.1415;

    Console.WriteLine("Canal {0} \nPi: {1}", canal, pi);
  }

  static void aula08() {
    Console.WriteLine("\nExplicações aula 08");

    // o Read e ReadLine realizam a leitura de informações do teclado
    // Read faz a leitura na mesma linha, e o ReadLine com quebra de linha.
    // Toda leitura do teclado é do tipo string, então devemos transformá-lo
    // para o tipo a ser manipulado no programa.

    int v1, v2, soma;
    string nome;

    Console.Write("Digite seu nome: ");
    nome = Console.ReadLine();
    Console.WriteLine("Nome digitado: {0}", nome);

    Console.Write("\nDigite o primeiro valor: ");
    // v1=Console.ReadLine(); // retornará com o erro "Não é possível converter implicitamente o tipo 'string' em 'int'"
    v1=int.Parse(Console.ReadLine()); // converterá a string do teclado para int
    Console.Write("Digite o segundo valor: ");
    v2=Convert.ToInt32(Console.ReadLine()); // converterá a string do teclado para int
    soma = v1 + v2;
    Console.WriteLine("A soma de {0} + {1} é igual a {2}", v1,v2,soma);
  }

  static void aula09() {
    Console.WriteLine("\nExplicações aula 09");

    // bitwise utiliza valores binários
    // deslocamento para a esquerda << DOBRA o valor da variável. Desloca os 5 útimos bits para a esquerda, e o restante completa com zero
    // deslocamento para a direita >> DIMINUI PELA METADE o valor da variável. Desloca os 5 últimos bits para a direita e elimina o restante

    int num1 = 10;
    int num2 = 10;
    int num3 = 2;
    int num4 = 2;

    num1 = num1 << 1; // desloca 1 número (dígito) para a esquerda. Valor que será impresso é 20 com num=10
    num2 = num2 >> 1; // desloca 1 número (dígito) para a direita. Valor que será impresso é 5 com num=10
    num3 = num3 << 2; // desloca 2 números (dígitos) para a esquerda. Valor que será impresso é 8 com num=2
    num4 = num4 >> 2; // desloca 2 números (dígitos) para a direita. Valor que será impresso é 0 com num=2

    Console.WriteLine("Deslocando um dígito para a << ESQUERDA o valor será: " + num1);
    Console.WriteLine("Deslocando um dígito para a DIREITA >> o valor será: " + num2);
    Console.WriteLine("Deslocando um dígito para a << ESQUERDA o valor será: " + num3);
    Console.WriteLine("Deslocando um dígito para a DIREITA >> o valor será: " + num4);
  }

  // enum: cria um tipo de variável próprio com valores pré-definidos
  enum DiasSemana{Domingo,Segunda,Terça,Quarta,Quinta,Sexta,Sábado};
  static void aula10() {
    Console.WriteLine("\nExplicações aula 10");

    DiasSemana ds1 = DiasSemana.Domingo; // retorna o valor definido de DiasSemana
    DiasSemana ds2 = (DiasSemana)3; // retorna o valor referente ao índice do DiasSemana
    int ds3 = (int)DiasSemana.Sexta; // vai converter o DiasSemana para inteiro e pega o índice do valor definido, no caso Sexta que será 5

    Console.WriteLine(ds1);
    Console.WriteLine(ds2);
    Console.WriteLine(ds3);
  }
}