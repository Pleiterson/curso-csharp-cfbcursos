using System;

class Aula04 {
    // int num = 10; // variável GLOBAL, nenhuma outra variável dentro dos métodos podem ter o mesmo nome, não vai conseguir acessar, pq a variável não é estática conforme o método
    static int num = 10; // variável GLOBAL, nenhuma outra variável dentro dos métodos podem ter o mesmo nome

    // método Main()
    static void Main(){
        // int num = 2; // variável LOCAL, que só poderá ser acessada dentro do método Main()
        int num2 = 1; // variável LOCAL, que só poderá ser acessada dentro do método Main()

        Console.WriteLine("A variável LOCAL é: " + num2 + "..."); // acessando a variável LOCAL "num" dentro do próprio método
        Console.WriteLine("A variável GLOBAL é: " + num + "..."); // acessando a variável GLOBAL "num3" dentro da classe "Aula04"
    }

    // método teste(), não faz parte do método Main()
    void teste() {
        // int num = 3; // variável LOCAL
        int num3 = 0; // variável LOCAL
        
        // Console.WriteLine(num); // tentando imprimir a variável num declarada no método Main()
        Console.WriteLine("A variável LOCAL é: " + num + "..."); // acessando a variável LOCAL "num" dentro do próprio método
        Console.WriteLine("A variável LOCAL é: " + num3 + "..."); // acessando a variável LOCAL "num" dentro do próprio método
    }
}