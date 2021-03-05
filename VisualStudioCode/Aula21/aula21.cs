using System;

class Aula21 {
    static void Main(){
        // o loop DO WHILE garante pelo menos uma execução do bloco de comandos, isso porque primeiro
        // ele executa o bloco de comandos e só depois ele verifica a condição de execução

        // este loop não será executado, pois o valor de num vai retornar false no teste para entrar no while
        int num = 5;
        while (num < 5) { // retorna false, pois num é igual a condição desejada, e não menor
            Console.WriteLine("CFB Cursos");
        }

        // será executado apenas uma vez, pois no do while, a execução ocorre primeiro e depois realiza o teste da condição
        do {
            Console.WriteLine("CFB Cursos");
        } while (num < 5);

        string senha = "123";
        string senhaUser;
        int tentativa = 0;

        do {
            tentativa++;
            Console.Clear();
            Console.WriteLine("Tentativa nº: {0}", tentativa);
            Console.Write("Digite a senha: ");

            senhaUser = Console.ReadLine();
        } while (senha != senhaUser); // será executado enquanto a senhaUser for diferente de senha

        Console.Clear();
        Console.WriteLine("Senha Correta! Você acertou a senha na tentativa {0}.", tentativa);
    }
}