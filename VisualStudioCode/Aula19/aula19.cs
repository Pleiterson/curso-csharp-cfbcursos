using System;

class Aula19 {
    static void Main(){
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
}