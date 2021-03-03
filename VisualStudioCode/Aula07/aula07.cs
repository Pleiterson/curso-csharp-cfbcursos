using System;

class Aula07 {
    static void Main(){
        // as regras para as declarações de constantes são as mesmas para as declarações de variáveis. O valor
        // de uma constante não pode ser alterado ao longo da execução do programa, ao contrário de uma variável
        // a declaração de uma constante utiliza-se as palavra reservada "const"

        const string canal = "CFBCursos";
        const double pi = 3.1415;

        Console.WriteLine("Canal {0} \nPi: {1}", canal, pi);
    }
}