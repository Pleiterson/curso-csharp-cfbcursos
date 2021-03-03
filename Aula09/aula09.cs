using System;

class Aula09 {
    static void Main(){
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
}