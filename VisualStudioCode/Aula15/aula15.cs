using System;

class Aula15 {
    static void Main(){
        int tempo = 0;
        int kilometragem = 0;
        char escolha;

        Console.WriteLine("Belo Horizonte/MG a Vitória/ES");
        Console.WriteLine("[a] Avião\n[c] Carro\n[o] Ônibus\nEscolha o transporte: ");
        escolha=char.Parse(Console.ReadLine());

        switch (escolha) {
            case 'a':case 'A':
                tempo = 1;
                kilometragem = 382;
                Console.WriteLine("Você optou por viajar de Avião. Veja os detalhes:");
            break;
            case 'c':case 'C':
                tempo = 9;
                kilometragem = 521;
                Console.WriteLine("Você optou por viajar de Carro. Veja os detalhes:");
            break;
            case 'o':case 'O':
                tempo = 10;
                kilometragem = 649;
                Console.WriteLine("Você optou por viajar de Ônibus. Veja os detalhes:");
            break;
            default:
                tempo = -1;
            break;
        }

        if (tempo < 0) {
            Console.WriteLine("Transporte escolhido não é uma das opções ofertadas!");
        } else {
            Console.WriteLine("O tempo de viagem é de {0} hora(s) com uma distância de {1} Km.", tempo, kilometragem);
        }
    }
}