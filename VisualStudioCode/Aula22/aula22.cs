using System;

class Aula22 {
    static void Main(){
        int[] num = new int[5]{11,22,33,44,55};

        Console.WriteLine("Imprimindo os dados do loop for");
        // imprimindo os valores do vetor com um for
        for (int i = 0; i < num.Length; i++) {
            Console.Write(num[i] + " ");
        }

        Console.WriteLine("\nImprimindo os dados do loop foreach");
        // o tipo da variável deve ser a mesma que vai ser utilizada no foreach, não serve para ler elementos, apenas imprimir elementos
        foreach (int n in num) {
            Console.Write(n + " ");
        }
    }
}