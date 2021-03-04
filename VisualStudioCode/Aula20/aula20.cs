using System;

class Aula20 {
    static void Main(){
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