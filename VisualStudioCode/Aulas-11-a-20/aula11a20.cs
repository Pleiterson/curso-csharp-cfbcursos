using System;

class Aula11a20 {
  static void Main(){
    aula11();
    aula12();
    aula13();
    aula14();
    aula15();
    aula16();
    aula17();
    aula18();
    aula19();
    aula20();
  }

  static void aula11() {
    Console.WriteLine("\nExplicações aula 11");

    // typecast é quando necessitamos converter um tipo para outro, quando não é de forma explícita
    int n1 = 10;
    float n2 = n1; // n2 recebe n1 que é um tipo inteiro
    
    float n3 = 10.5f;
    // int n4 = n3; // comentado apenas para não dar erro na compilação
    int n4 = (int)n3; // operação typecast, convertendo a variável n3 que é float para int (inteiro)

    long n5 = n1; // n5 recebe n1 que é um tipo inteiro
    // short n6 = n1; // comentado apenas para não dar erro na compilação
    short n6 = (short)n1;

    Console.WriteLine("Conversão de forma implícita (segura) de int para float: " + n2); // imprimindo n2, vai executar normalmente, pois vai ocorrer uma conversão de forma implícita (segura)
    // Console.WriteLine(n4); // imprimindo n4, não vai executar, pois está ocorrendo conversão de forma explícita, será necessário converter manualmente
    Console.WriteLine("Conversão de forma explícita (não segura) de float para int: " + n4); // imprimindo n4, não vai executar, pois está ocorrendo conversão de forma explícita, será necessário converter manualmente
    Console.WriteLine("Conversão de forma implícita (segura) de int para long: " + n5); // imprimindo n5, vai executar normalmente, pois vai ocorrer uma conversão de forma implícita (segura)
    Console.WriteLine("Conversão de forma explícita (não segura) de short para int: " + n6); // imprimindo n6, não vai executar, pois está ocorrendo conversão de forma explícita, será necessário converter manualmente
  }

  static void aula12() {
    Console.WriteLine("\nExplicações aula 12");

    // IF = SE
    // SE (expressão lógica) {}
    // SE (10 < 5) {false}
    // SE (10 > 5) {true}
    // pode ser usado < > <= >= != ==

    // int nota = 80;
    // int nota = 50;
    // int nota = 0;
    int res,n1,n2,n3,n4;
    string resultado = "Reprovado";

    res=n1=n2=n3=n4 = 0;
    // Console.WriteLine("Digite o valor de sua nota: ");
    // nota = int.Parse(Console.ReadLine());
    
    Console.Write("Digite o valor de sua nota 1: ");
    n1 = int.Parse(Console.ReadLine());
    Console.Write("Digite o valor de sua nota 2: ");
    n2 = int.Parse(Console.ReadLine());
    Console.Write("Digite o valor de sua nota 3: ");
    n3 = int.Parse(Console.ReadLine());
    Console.Write("Digite o valor de sua nota 4: ");
    n4 = int.Parse(Console.ReadLine());

    res = n1 + n2 + n3 + n4;
    
    // if (nota >= 60) {
    //     resultado = "Aprovado";
    // }
    
    if (res >= 60) {
        resultado = "Aprovado";
    }

    // Console.WriteLine("Resultado final: {0}! Sua nota foi: {1}", resultado,nota);
    Console.WriteLine("Resultado final: {0}! Sua nota foi: {1}", resultado,res);
  }

  static void aula13(){
    Console.WriteLine("\nExplicações aula 13");

    // else dá novas possibilidades de teste para o if
    // é um complento do if

    int res,n1,n2,n3,n4;
    string resultado;

    res=n1=n2=n3=n4 = 0;
    
    Console.Write("Digite o valor de sua nota 1: ");
    n1 = int.Parse(Console.ReadLine());
    Console.Write("Digite o valor de sua nota 2: ");
    n2 = int.Parse(Console.ReadLine());
    Console.Write("Digite o valor de sua nota 3: ");
    n3 = int.Parse(Console.ReadLine());
    Console.Write("Digite o valor de sua nota 4: ");
    n4 = int.Parse(Console.ReadLine());

    res = n1 + n2 + n3 + n4;
    
    if (res < 40) { // é reprovado se a nota for menor que 40
        resultado = "Reprovado";
    } else if (res < 60) { // fica de recuperação se a nota estiver entre 40 a 59
        resultado = "Recuperação";
    } else { // é aprovado se a nota for maior ou igual a 60
        resultado = "Aprovado";
    }

    Console.WriteLine("Resultado final: {0}! Sua nota foi: {1}", resultado,res);
  }

  static void aula14(){
    Console.WriteLine("\nExplicações aula 14");

    int res,n1,n2,n3,n4;
    string resultado;

    res=n1=n2=n3=n4 = 0;
    
    Console.Write("Digite o valor de sua nota 1: ");
    n1 = int.Parse(Console.ReadLine());
    Console.Write("Digite o valor de sua nota 2: ");
    n2 = int.Parse(Console.ReadLine());
    Console.Write("Digite o valor de sua nota 3: ");
    n3 = int.Parse(Console.ReadLine());
    Console.Write("Digite o valor de sua nota 4: ");
    n4 = int.Parse(Console.ReadLine());

    res = n1 + n2 + n3 + n4;
    
    if (res >= 60) {
      if (res >= 90) {
        resultado = "Aprovado com Louvor!";
      } else {
        resultado = "Aprovado";
      }
    } else {
      if (res >= 40) {
        resultado = "Recuperação";
      } else {
        resultado = "Reprovado";
      }
    }

    Console.WriteLine("Resultado final: {0}! Sua nota foi: {1}", resultado,res);
  }

  static void aula15(){
    Console.WriteLine("\nExplicações aula 15");

    int tempo = 0;
    int kilometragem = 0;
    char escolha;

    Console.WriteLine("Belo Horizonte/MG a Vitória/ES");
    Console.Write("[a] Avião\n[c] Carro\n[o] Ônibus\nEscolha o transporte: ");

    escolha = char.Parse(Console.ReadLine());
    switch (escolha) {
      case 'a':case 'A':
        tempo = 1;
        kilometragem = 382;
        Console.WriteLine("Você optou por viajar de Avião. Veja os detalhes:");
      break;
      case 'c':case 'C':
        tempo = 9;
        kilometragem = 521;
        Console.WriteLine("Você optou por viajar de Carro. Veja os detalhes:");
      break;
      case 'o':case 'O':
        tempo = 10;
        kilometragem = 649;
        Console.WriteLine("Você optou por viajar de Ônibus. Veja os detalhes:");
      break;
      default:
        tempo = -1;
      break;
    }

    if (tempo < 0) {
      Console.WriteLine("Transporte escolhido não é uma das opções ofertadas!");
    } else {
      Console.WriteLine("O tempo de viagem é de {0} hora(s) com uma distância de {1} Km.", tempo, kilometragem);
    }
  }

  static void aula16(){
    Console.WriteLine("\nExplicações aula 16");

    int tempo = 0;
    int kilometragem = 0;
    char escolha;

    inicio: // label para retornar nesta linha de código ao dar o comando goto no final da execução
    Console.Clear(); // limpando a tela

    Console.WriteLine("Belo Horizonte/MG a Vitória/ES");
    Console.Write("[a] Avião\n[c] Carro\n[o] Ônibus\nEscolha o transporte: ");

    escolha = char.Parse(Console.ReadLine());
    switch (escolha) {
      case 'a':case 'A':
        tempo = 1;
        kilometragem = 382;
        Console.WriteLine("Você optou por viajar de Avião. Veja os detalhes:");
      break;
      case 'c':case 'C':
        tempo = 9;
        kilometragem = 521;
        Console.WriteLine("Você optou por viajar de Carro. Veja os detalhes:");
      break;
      case 'o':case 'O':
        tempo = 10;
        kilometragem = 649;
        Console.WriteLine("Você optou por viajar de Ônibus. Veja os detalhes:");
      break;
      default:
        tempo = -1;
      break;
    }

    if (tempo < 0) {
      Console.WriteLine("Transporte escolhido não é uma das opções ofertadas!");
    } else {
      Console.WriteLine("O tempo de viagem é de {0} hora(s) com uma distância de {1} Km.", tempo, kilometragem);
    }

    Console.Write("\nDeseja realizar uma nova busca para sua viagem? [s/n]: ");
    escolha = char.Parse(Console.ReadLine());

    if (escolha == 's' || escolha == 'S') {
      goto inicio; // o goto deve sempre apontar para um label que foi criado na linha 9, "inicio"
    } else {
      Console.Clear();
      Console.WriteLine("Obrigado!");
    }
  }

  static void aula17(){
    Console.WriteLine("\nExplicações aula 17");

    // array (vetores) é uma coleção de elementos do mesmo tipo

    int[] n = new int[5]; // declarado um array de tamanho 5
    int[] num1 = new int[3]{55,77,99}; // declarando um array de tamanho 3, e inicializando os valores dele
    int[] num2 = {55,77,99,66,88}; // declarando um array de tamanho 5, e inicializando os valores dele
    string[] veiculos = new string[3]; // declarado um array de tamanho 3

    n[0] = 11; // atribuindo o valor 11 na posição 0 do array n
    n[1] = 22; // atribuindo o valor 22 na posição 1 do array n
    n[2] = 33; // atribuindo o valor 33 na posição 2 do array n
    n[3] = 44; // atribuindo o valor 44 na posição 3 do array n
    n[4] = 55; // atribuindo o valor 55 na posição 4 do array n

    veiculos[0] = "Carro"; // atribuindo o valor Carro na posição 0 do array veiculos
    veiculos[1] = "Avião"; // atribuindo o valor Avião na posição 1 do array veiculos
    veiculos[2] = "Navio"; // atribuindo o valor Navio na posição 2 do array veiculos

    Console.WriteLine("Valor da posição 0 do array n é: " + n[0]); // imprimindo o valor da posição 0 do array n, saída 11
    Console.WriteLine("Valor da posição 2 do array num1 é: " + num1[2]); // imprimindo o valor da posição 2 do array num1, saída 99
    Console.WriteLine("Valor da posição 3 do array num2 é: " + num2[3]); // imprimindo o valor da posição 3 do array num2, saída 66
    Console.WriteLine("Valor da posição 1 do array veiculos é: " + veiculos[1]); // imprimindo o valor da posição 1 do array veiculos, saída Avião
  }

  static void aula18(){
    Console.WriteLine("\nExplicações aula 18");

    int[,] n = new int[3,5]; // declarado uma matriz de tamanho 3x5 (linhas x colunas)
    int[,] num = new int[2,2]{{10,20},{30,40}}; // declarado uma matriz de tamanho 2x2 e atribuindo os valores a ele

    /* matriz de 3 x 5 (linhas x colunas)
    10  20  30  40  50
    60  70  80  90  15
    25  35  45  55  65
    */

    // atribuindo os dados da matriz
    n[0,0] = 10;    n[1,0] = 60;    n[2,0] = 25;
    n[0,1] = 20;    n[1,1] = 70;    n[2,1] = 35;
    n[0,2] = 30;    n[1,2] = 80;    n[2,2] = 45;
    n[0,3] = 40;    n[1,3] = 90;    n[2,3] = 55;
    n[0,4] = 50;    n[1,4] = 15;    n[2,4] = 65;

    Console.WriteLine("Valor da posição 1,3 da matriz n é: " + n[1,3]); // imprimindo o valor da posição 1,3 da matriz n, saída 90
    Console.WriteLine("Valor da posição 2,1 da matriz n é: " + n[2,1]); // imprimindo o valor da posição 2,1 da matriz n, saída 35
    Console.WriteLine("Valor da posição 1,1 da matriz num é: " + num[1,1]); // imprimindo o valor da posição 1,1 da matriz num, saída 40
  }

  static void aula19(){
    Console.WriteLine("\nExplicações aula 19");

    // o loop FOR (para) é mais indicado quando se sabe a quantidade de vezes que irá repetir um comando
    // for (expressão 1; expressão 2; expressão 3) {}
    // expressão 1: inicializador ou contador, variável ou expressão que vai contar o início da contagem, executa somente a 1ª vez que entra no for
    // expressão 2: expressão com a quantidade de vezes que a estrutura será repetida, uma expressão lógica com valor verdadeiro para iniciar as repetições
    // expressão 3: incremento ou decremento do contador que vai limitar as repetições do for

    int[] num2 = new int[10];

    for (int num1 = 0; num1 < 10; num1++) {
      // a variável num1 só poderá ser acessada dentro do escopo do for
      Console.WriteLine("Execução de número " + num1);
    }

    for (int i = 0; i < num2.Length; i++) {
      // Lenght retorna o tamanho do vetor, assim não há o risco de ocorrer erro na execução ou compilação do programa quando passar do tamanho do vetor
      // a variável i só poderá ser acessada dentro do escopo do for
      num2[i] = 0;

      Console.WriteLine("Valor da posição {0} do vetor num2 é: {1}", i,num2[i]);
    }

    Console.WriteLine("Saiu do loop do for. Executou 10 vezes o for!");
  }

  static void aula20(){
    Console.WriteLine("\nExplicações aula 20");

    // diferente do loop FOR o loop WHILE (enquanto) é indicado quando não sabemos ao certo quantas vezes iremos executar o bloco de comandos
    // while (expressão 1) {}
    // expressão 1: uma expressão lógica com valor verdadeiro para iniciar as repetições, a inicialização do contador ocorre do lado de fora do loop, e o contador do lado de dentro
    
    int[] num2 = new int[10];

    int i = 0;
    while (i < 10) {
      Console.WriteLine("Execução de número " + i);
      i++; // incremento ou decremento para contar a quantidade de vezes que o while vai rodar, para não ficar em loop infinito, se não i seria sempre zero
    }

    int j = 0;
    while (j < num2.Length) {
      // Lenght retorna o tamanho do vetor, assim não há o risco de ocorrer erro na execução ou compilação do programa quando passar do tamanho do vetor
      num2[j] = 0;
      Console.WriteLine("Valor da posição {0} do vetor num2 é: {1}", j,num2[j]);
      j++;
    }

    int k = num2.Length - 1;
    while (k >= 0) {
      num2[k] = 0;
      Console.WriteLine("Decrementando. Valor da posição {0} do vetor num2 é: {1}", k,num2[k]);
      k--;
    }

    Console.WriteLine("Saiu do loop do while. Executou 10 vezes o while!");
  }
}