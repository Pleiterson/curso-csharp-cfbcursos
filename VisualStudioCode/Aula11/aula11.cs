using System;

class Aula11 {
    // typecast é quando necessitamos converter um tipo para outro, quando não é de forma explícita

    static void Main(){
        int n1 = 10;
        float n2 = n1; // n2 recebe n1 que é um tipo inteiro
        
        float n3 = 10.5f;
        // int n4 = n3; // comentado apenas para não dar erro na compilação
        int n4 = (int)n3; // operação typecast, convertendo a variável n3 que é float para int (inteiro)

        long n5 = n1; // n5 recebe n1 que é um tipo inteiro
        // short n6 = n1; // comentado apenas para não dar erro na compilação
        short n6 = (short)n1;

        Console.WriteLine("Conversão de forma implícita (segura) de int para float: " + n2); // imprimindo n2, vai executar normalmente, pois vai ocorrer uma conversão de forma implícita (segura)
        // Console.WriteLine(n4); // imprimindo n4, não vai executar, pois está ocorrendo conversão de forma explícita, será necessário converter manualmente
        Console.WriteLine("Conversão de forma explícita (não segura) de float para int: " + n4); // imprimindo n4, não vai executar, pois está ocorrendo conversão de forma explícita, será necessário converter manualmente
        Console.WriteLine("Conversão de forma implícita (segura) de int para long: " + n5); // imprimindo n5, vai executar normalmente, pois vai ocorrer uma conversão de forma implícita (segura)
        Console.WriteLine("Conversão de forma explícita (não segura) de short para int: " + n6); // imprimindo n6, não vai executar, pois está ocorrendo conversão de forma explícita, será necessário converter manualmente
    }
}