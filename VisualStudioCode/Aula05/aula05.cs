using System;

class Aula05 {
    static void Main(){
        // operadores matemáticos: + - * /
        int res1 = (10+5)*2; // realizando uma operação matemática e atribuindo o valor a variável "res1"

        // operadores relacionais: > < >= <= != 
        bool res2 = 10 < 5; // realizando uma operação booleana (verdadeiro/falso) e atribuindo o valor a variável "res2"
        bool res3 = 10 > 5; // realizando uma operação booleana (verdadeiro/falso) e atribuindo o valor a variável "res3"

        // operações de incremento ou decremento
        int num1 = 10;
        int num2 = 10;
        int num3 = 10;
        
        // todos as 3 operações abaixo são iguais
        num1 = num1 + 1; // pode ser incluído qualquer valor para esta operação e também para + - * /
        num2 += 1; // pode ser incluído qualquer valor para esta operação e também para + - * /
        num3++; // funciona apenas para acrescentar 1, não pode ser usado para números maiores que 1

        // operadores lógicos: & and, e (and, retorna true, se todas as condições for true) -- | or, ou (or, retorna false, se todas as condições for false)
        bool res4 = (5>3) | (10<5); // retornará true, pois tem uma verdade com OU. (5>3) true, e (10<5) false
        bool res5 = (5>7) | (10<5); // retornará false, pois têm duas verdades com OU. (5>7) false, e (10<5) false
        bool res6 = (5>7) & (10<5); // retornará false, pois têm duas verdades com AND. (5>7) false, e (10<5) false
        bool res7 = (5>3) & (10<5); // retornará false, pois tem uma verdade com AND. (5>3) true, e (10<5) false
        bool res8 = (5>3) & (10>5); // retornará true, pois tem uma verdade com AND. (5>3) true, e (10>5) true

        Console.WriteLine("O resultado da variável 1 é: " + res1);
        Console.WriteLine("O resultado da variável 2 é: " + res2);
        Console.WriteLine("O resultado da variável 3 é: " + res3);
        Console.WriteLine("O resultado da operação (num=num+1) é: " + num1);
        Console.WriteLine("O resultado da operação (num+=1) é: " + num2);
        Console.WriteLine("O resultado da operação (num++) é: " + num3);
        Console.WriteLine("O resultado da variável 4 é: " + res4);
        Console.WriteLine("O resultado da variável 5 é: " + res5);
        Console.WriteLine("O resultado da variável 6 é: " + res6);
        Console.WriteLine("O resultado da variável 7 é: " + res7);
        Console.WriteLine("O resultado da variável 8 é: " + res8);
    }
}