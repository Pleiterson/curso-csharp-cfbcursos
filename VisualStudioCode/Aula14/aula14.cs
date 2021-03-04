using System;

class Aula14 {
    static void Main(){
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
        
        if (res >= 60) {
            if (res >= 90) {
                resultado = "Aprovado com Louvor!";
            } else {
                resultado = "Aprovado";
            }
        } else {
            if (res >= 40) {
                resultado = "Recuperação";
            } else {
                resultado = "Reprovado";
            }
        }

        Console.WriteLine("Resultado final: {0}! Sua nota foi: {1}", resultado,res);
    }
}