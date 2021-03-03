using System;

class Aula10 {
    // enum: cria um tipo de variável próprio com valores pré-definidos
    
    enum DiasSemana{Domingo,Segunda,Terça,Quarta,Quinta,Sexta,Sábado};

    static void Main(){
        DiasSemana ds1 = DiasSemana.Domingo; // retorna o valor definido de DiasSemana
        DiasSemana ds2 = (DiasSemana)3; // retorna o valor referente ao índice do DiasSemana
        int ds3 = (int)DiasSemana.Sexta; // vai converter o DiasSemana para inteiro e pega o índice do valor definido, no caso Sexta que será 5

        Console.WriteLine(ds1);
        Console.WriteLine(ds2);
        Console.WriteLine(ds3);
    }
}