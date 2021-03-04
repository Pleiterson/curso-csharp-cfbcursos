using System;

class Aula12 {
    static void Main(){
        // IF = SE
        // SE (expressão lógica) {}
        // SE (10 < 5) {false}
        // SE (10 > 5) {true}
        // pode ser usado < > <= >= != ==

        // int nota = 80;
        // int nota = 50;
        // int nota = 0;
        int res,n1,n2,n3,n4;
        string resultado = "Reprovado";

        res=n1=n2=n3=n4 = 0;
        // Console.WriteLine("Digite o valor de sua nota: ");
        // nota = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite o valor de sua nota 1: ");
        n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor de sua nota 2: ");
        n2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor de sua nota 3: ");
        n3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor de sua nota 4: ");
        n4 = int.Parse(Console.ReadLine());

        res = n1 + n2 + n3 + n4;
        
        // if (nota >= 60) {
        //     resultado = "Aprovado";
        // }
        
        if (res >= 60) {
            resultado = "Aprovado";
        }

        // Console.WriteLine("Resultado final: {0}! Sua nota foi: {1}", resultado,nota);
        Console.WriteLine("Resultado final: {0}! Sua nota foi: {1}", resultado,res);
    }
}