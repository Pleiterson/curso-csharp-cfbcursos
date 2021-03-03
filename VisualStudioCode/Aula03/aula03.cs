using System;

class Aula03 {
    static void Main(){
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
        Console.WriteLine("A soma de " + num1 + " com " + num2 + " é igual a: " + (num1+num2));
    }
}