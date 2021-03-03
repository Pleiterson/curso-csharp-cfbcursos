using System;

class Aula08 {
    static void Main(){
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
}