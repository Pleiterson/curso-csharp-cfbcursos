using System;

class Aula23 {
    static void Main(){
        int[] vetor1 = new int[5];
        int[] vetor2 = new int[5];
        int[] vetor3 = new int[5];
        int[,] matriz = new int[2,5]{{11,22,00,44,55 },{66,77,88,99,00}};

        Random random = new Random(); // gera números aleatórios
        for (int i = 0; i < vetor1.Length; i++) {
            vetor1[i] = random.Next(10); // preenchendo o vetor1 com valores aleatórios de 0 a 9
        }

        Console.WriteLine("Elementos do vetor1:");
        foreach (int n in vetor1) {
            Console.Write(n + " "); // imprimindo os valores do vetor1
        }
        Console.WriteLine("\n--------------------------------------------");

        //public static int BynarySearch(array, valor);
        Console.WriteLine("BinarySearch"); // BinarySearch retorna a posição do elemento procurado, retorno < 0 indica que o elemento não está no array
        int procurado = 3;
        int posicao = Array.BinarySearch(vetor1, procurado); // chama a classe Array, passa o vetor que deseja pesquisar assim como o elemento desejado
        Console.WriteLine("Valor {0} está na posição {1}6", procurado,posicao); // imprimindo o valor encontrado, se não for encontrado, retorno -1
        Console.WriteLine("--------------------------------------------");

        //pubic static void Copy(array_origem, array_destino, qtde_elementos); // passa array de origem e destino e a quantidade de elementos a ser copiado
        Console.WriteLine("Copy:"); // Copy copia os elementos de um array para outro
        // chama a classe Array, passa o vetor de origem, o vetor de destino e a quantidade de elementos com Length, ou seja, todo o vetor1 para vetor2
        Array.Copy(vetor1, vetor2, vetor1.Length);

        foreach (int n in vetor2) {
            Console.Write(n + " "); // imprimindo os valores do vetor2
        }
        Console.WriteLine("\n--------------------------------------------");

        //public void CopyTo(array_destino, a_partir_desta_posicao); é chamado a partir do vetor de origem, passando o vetor de destino e a partir de qual posição a ser copiada
        Console.WriteLine("CopyTo:"); // CopyTo copia os elementos de um array para outro
        vetor1.CopyTo(vetor3, 0); // chama o Array de origem e  passa o vetor de destino e o índice que iniciará a cópia

        foreach (int n in vetor3) {
            Console.Write(n + " "); // imprimindo os valores do vetor3
        }
        Console.WriteLine("\n--------------------------------------------");

        //public long GetLongLenght(dimensão);
        Console.WriteLine("GetLongLenght:"); // retorna a quantidade de elementos em um array/matriz
        long qtdeElementosVetor = vetor1.GetLength(0);
        Console.WriteLine("Quantidade de elementos {0}.", qtdeElementosVetor);
        Console.WriteLine("--------------------------------------------");

        //public long GetLowerBound(dimensão);
        Console.WriteLine("GetLowerBound:"); // retornará o menor índice do array/matriz
        int MenorIndiceVetor = vetor1.GetLowerBound(0);
        int MenorIndiceMatriz_D0 = matriz.GetLowerBound(0);
        int MenorIndiceMatriz_D1 = matriz.GetLowerBound(1);
        Console.WriteLine("Menor índice do vetor1: {0}", MenorIndiceVetor);
        Console.WriteLine("Menor índice da matriz na dimensão 0: {0}", MenorIndiceMatriz_D0);
        Console.WriteLine("Menor índice da matriz na dimensão 1: {0}", MenorIndiceMatriz_D1);
        Console.WriteLine("--------------------------------------------");

        //public long GetUpperBound(dimensão);
        Console.WriteLine("GetUpperBound:"); // retorna o maior índice de um vetor/matriz
        int MaiorIndiceVetor = vetor1.GetUpperBound(0);
        int MaiorIndiceMatriz_D0 = matriz.GetUpperBound(0);
        int MaiorIndiceMatriz_D1 = matriz.GetUpperBound(1);
        Console.WriteLine("Maior índice do vetor1: {0}", MaiorIndiceVetor);
        Console.WriteLine("Maior índice da matriz na dimensão 0: {0}", MaiorIndiceMatriz_D0);
        Console.WriteLine("Maior índice da matriz na dimensão 1: {0}", MaiorIndiceMatriz_D1);
        Console.WriteLine("--------------------------------------------");

        //public object GetValue(long índice);
        Console.WriteLine("GetValue:"); // retorna o valor a partir de um índice
        int valor0 = Convert.ToInt32(vetor1.GetValue(3));
        int valor1 = Convert.ToInt32(matriz.GetValue(1,3));
        Console.WriteLine("Valor da posição 3 do vetor1: {0}", valor0);
        Console.WriteLine("Valor da posição (1,3) da matriz: {0}", valor1);
        Console.WriteLine("--------------------------------------------");

        //public static int IndexOf(array, valor);
        Console.WriteLine("IndexOf:"); // retorna o primeiro índice de um valor indicado
        int indice1 = Array.IndexOf(vetor1, 3);
        Console.WriteLine("Indice do primeiro valor 3: {0}", indice1);
        Console.WriteLine("--------------------------------------------");

        //public static int LastIndexOf(array, valor);
        Console.WriteLine("LastIndexOf:"); // retorna o último índice de um valor indicado
        int indice2 = Array.LastIndexOf(vetor1, 3);
        Console.WriteLine("Indice do último valor 3: {0}", indice2);
        Console.WriteLine("--------------------------------------------");

        //public static void Reverse(array);
        Console.WriteLine("Reverse Array:"); // inverte a ordem dos elementos em um array {1,2,3} invertendo {3,2,1}
        Array.Reverse(vetor1);

        foreach (int n in vetor1) {
            Console.Write(n + " ");
        }
        Console.WriteLine("\n--------------------------------------------");

        //public void SetValue(object valor, long pos);
        Console.WriteLine("SetValue:"); // setar... define o valor de uma posição do vetor
        vetor2.SetValue(99, 0); // é chamado a partir do vetor, e precisa passar o valor do vetor e a posição do vetor

        for (int i = 0; i < vetor2.Length; i++) {
            vetor2.SetValue(0, i);
        }
        Console.Write("Vetor 2: ");

        foreach (int n in vetor2) {
            Console.Write(n + " ");
        }
        Console.WriteLine("\n--------------------------------------------");

        //public static void Sort(array);
        Array.Sort(vetor1); // ordena em ordem crescente os elementos de um array, em ordem decrescente, usa-se um Sort() e depois um Reverse()
        Array.Sort(vetor2);
        Array.Sort(vetor3);

        Console.Write("Vetor1: ");
        foreach (int n in vetor1) {
            Console.Write(n + " ");
        }

        Console.Write("\nVetor2: ");
        foreach (int n in vetor2) {
            Console.Write(n + " ");
        }

        Console.Write("\nVetor3: ");
        foreach (int n in vetor3) {
            Console.Write(n + " ");
        }
    }
}