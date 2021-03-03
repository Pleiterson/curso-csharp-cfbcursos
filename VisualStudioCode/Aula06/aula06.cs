using System;

class Aula06 {
    static void Main(){
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
}