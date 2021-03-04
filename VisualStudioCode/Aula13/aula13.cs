using System;

class Aula13 {
    static void Main(){
        // else dá novas possibilidades de teste para o if
        // é um complento do if

        int res,n1,n2,n3,n4;
        string resultado;

        res=n1=n2=n3=n4 = 0;
        
        Console.WriteLine("Digite o valor de sua nota 1: ");
        n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor de sua nota 2: ");
        n2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor de sua nota 3: ");
        n3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor de sua nota 4: ");
        n4 = int.Parse(Console.ReadLine());

        res = n1 + n2 + n3 + n4;
        
        if (res < 40) { // é reprovado se a nota for menor que 40
            resultado = "Reprovado";
        } else if (res < 60) { // fica de recuperação se a nota estiver entre 40 a 59
            resultado = "Recuperação";
        } else { // é aprovado se a nota for maior ou igual a 60
            resultado = "Aprovado";
        }

        Console.WriteLine("Resultado final: {0}! Sua nota foi: {1}", resultado,res);
    }
}