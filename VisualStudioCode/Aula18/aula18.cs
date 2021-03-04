using System;

class Aula18 {
    static void Main(){
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
}