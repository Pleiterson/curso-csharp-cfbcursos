using System;

class Aula17 {
    static void Main(){
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
}