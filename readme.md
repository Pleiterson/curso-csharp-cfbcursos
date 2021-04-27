<!-- Badges session -->
<p align="center">  
  <!-- languages -->
  <img src="https://img.shields.io/github/languages/count/pleiterson/curso-csharp-cfbcursos?style=social" alt="Linguagens utilizadas">
  <!-- repo size -->
  <img src="https://img.shields.io/github/repo-size/Pleiterson/curso-csharp-cfbcursos?style=social" alt="Tamanho do repositório">
  <!-- last commit -->
  <img src="https://img.shields.io/github/last-commit/Pleiterson/curso-csharp-cfbcursos?style=social" alt="Último commit">
  <!-- licence MIT -->
  <img src="https://img.shields.io/github/license/Pleiterson/curso-csharp-cfbcursos?style=social" alt="Licença MIT">
</p>

<!--Banner session-->
<p align="center">
  <img src="./assets/banner.png" alt="CFBCursos" title="CFBCursos">
</p>

<!--About session-->
<h1 align="center">Curso de Programação em C#<br>CFBCursos - YouTube</h1>

Curso de programação completo em C#, venha aprender criar programas para Windows em uma das linguagens mais usadas comercialmente. Se você que ser um programador de verdade e que tenha colocação no mercado de trabalho você precisa aprender C#.

C# é uma linguagem de programação, multiparadigma, desenvolvida pela Microsoft como parte da plataforma .NET. A sua sintaxe orientada a objetos foi baseada no C++ mas inclui muitas influências de outras linguagens de programação como Java.

O curso de C# será dividido em duas grandes partes, a primeira parte iremos aprender toda lógica de programação usando a linguagem C# no Visual Studio Code, na segunda parte iremos partir para a parte gráfica, usando o Visual Studio Community para criar programar no padrão Windows, com formulários, botões, elementos interativos, relatórios e banco de dados.

- [Playlist do Curso](https://www.youtube.com/playlist?list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi)
<br>Programação com Visual Studio Code: 1 ao 59
<br>Programação com Visual Studio Community: 60 ao 130

<h3>Configurando o compilador C# (csc.exe)</h3>

- Verificar se o compilador jpa está configurado. Abra o terminal, e na pasta "C:" digite csc. Caso aprensente erro, você deve incluir a pasta do arquivo csc.exe no path do sistema (em variáveis de ambiente).
```
C:\Windows\Microsoft.NET\Framework64\v4.0.30319
```
Caso não tenha o arquivo na pasta acima, você deve instalar o .NET Core SDK e o .NET Framework Runtime. [Baixe aqui](https://dotnet.microsoft.com/download).
- No terminal do VSCode, vamos digitar "csc" para verificar se o sistema está reconhecendo o compilador do framework instalado. Caso apresente erro, mesmo incluindo nas variáveis ambiente, execute este comando para reconhecer o compilador.
- Para executar os arquivos digite o comando na pasta onde o arquivo se encontra
```
PATH %path$;C:\Windows\Microsoft.NET\Framework64\v4.0.30319

// depois digite comando abaixo para confirmação
csc
```
- Para executar os arquivos digite o comando na pasta onde o arquivo se encontra. Ele vai gerar um arquivo executável, e então é só digitar o nome do arquivo que vai rodar o código escrito
```
csc aula01.cs

aula01
```

<!-- Aulas -->
<h3>💻 Programação com Visual Studio Code:</h3>

- **Aula 01:** vamos baixar todo conteúdo necessário, instalar as ferramentas e configurar tudo para que possamos aprende a programar em C#;
- **Aula 02:** vamos criar nosso primeiro programa no padrão C# .net (dotnet). Vamos aprender de forma bastante resumida como obter os parâmetros de execução do programa. Projeto criado com o comando abaixo;
```
dotnet new console // para criar um projeto

dotnet run // para executar o projeto
```
- **Aula 03:** vamos aprender sobre variáveis, os tipos de dados, como criar uma variável, atribuir um valor e ler o valor armazenado na variável;
- **Aula 04:** vamos aprender sobre escopo de variáveis, basicamente onde as variáveis declaradas são visíveis dentro do nosso programa. Falaremos de variáveis globais e variáveis locais;
- **Aula 05:** vamos aprender sobre operadores e operações. Operações matemáticas, relacionais / lógicas / comparação, atribuições, etc;
- **Aula 06:** vamos aprender como formatar/personalizar as saídas de texto no console, usando caracteres de escape e outros marcadores;
- **Aula 07:** vamos aprender como usar constantes. O que são constantes, como declarar constantes e atribuir o valor inicial a constante;
- **Aula 08:** vamos aprender como ler valores diretamente do teclado e armazenar em variáveis;
- **Aula 09:** vamos aprender sobre os operadores bitwise, são operações simples de deslocamento de bits que em resumo dobram o valor da variável ou diminuem pela metade;
- **Aula 10:** vamos aprender sobre enumeradores, basicamente podemos definir um tipo com valores personalizados, podemos definir os valores que poderão ser atribuídos aos elementos do tipo enum que criarmos;
- **Aula 11:** vamos aprender sobre conversões de tipos, veremos que existem as conversões implícitas, também conhecidas como conversões seguras e automáticas e as conversões explícitas onde devemos indicar o comando para conversão;
- **Aula 12:** vamos aprender sobre o comando condicional IF. Basicamente o comando IF realiza um teste condicional e dependendo do resultado deste teste, se for verdadeiro ou falso, se for verdadeiro a condicional IF executa seu bloco de comandos se for false, simplesmente não executa seu bloco de comandos e prossegue com o programa após o bloco do IF;
- **Aula 13:** vamos aprender sobre o complemento do comando IF que é a instrução ELSE. Basicamente ELSE é o caso contrário do IF, ou seja, caso o teste do IF seja verdadeiro seu bloco de comandos é executado, mas caso seja falso o bloco de comandos a ser executado é do ELSE;
- **Aula 14:** vamos aprender sobre aninhamento do comando IF, que é a situação onde podemos aplicar uma estrutura IF ou IF-ELSE dentro de outra estrutura IF;
- **Aula 15:** vamos aprender sobre a estrutura switch case, tem uma funcionalidade semelhante ao IF. Seu funcionamento é simples, basicamente escolhe qual bloco de comandos será executado mediante o reusltado de um teste lógico;
- **Aula 16:** vamos aprender sobre o comando goto que faz um desvio no fluxo de execução do programa para um label indicado;
- **Aula 17:** vamos aprender sobre os arrays ou vetores, que são estruturas unidimensionais que armazenam vários dados do mesmo tipo;
- **Aula 18:** vamos aprender sobre as matrizes que nada mais são que arrays com mais de uma dimensão, ou mais de um índice de controle, como se fosse representado por uma tabela com linhas e colunas, ex.: excel;
- **Aula 19:** vamos começar a aprender sobre as estruturas de iteração (repetição), nesta aula iremos aprender sobre o loop FOR. Um comando de loop executa um bloco de comandos um número determinado ou indeterminado de vezes, no caso do loop FOR nós sabemos quantas vezes os comandos serão repetidos;
- **Aula 20:** vamos continuar a aprender sobre as estruturas de iteração, nesta aula iremos aprender sobre o loop WHILE, diferente do loop FOR o loop WHILE é indicado quando não sabemos ao certo quantas vezes iremos executar o bloco de comandos;
- **Aula 21:** vamos continuar a aprender sobre as estruturas de iteração, nesta aula iremos aprender sobre o loop DO WHILE, diferente do loop WHILE o loop DO WHILE garante pelo menos uma execução do bloco de comandos, isso porque primeiro ele executa o bloco de comandos e só depois ele verifica a condição de execução;
- **Aula 22:** vamos continuar a aprender sobre as estruturas de iteração, nesta aula iremos aprender sobre o loop FOREACH, indicado para quando for necessário ler os elementos de uma coleção como um array/vetor por exemplo;
- **Aula 23:** vamos aprender métodos já implementados para manipulação dos elementos de um array (vetor ou matriz), são vários métodos para ordenar, copiar, inverter, inserir elementos, irei dividir este assunto em duas aulas;
- **Aula 24:** vamos aprender os detalhes mais importantes a respeitos dos métodos, como métodos com e sem retorno e argumentos de entrada;

<h3>💻 Programação com Visual Studio Community:</h3>

<!--License session-->
<h3>📝 Licença</h3>

- Este projeto está sob a licença [MIT](./LICENSE).<br>

<!--Bottom session-->
<br><h4 align=center>Made with by <a target="_blank" href="https://pleiterson.vercel.app" >Pleiterson Amorim</a></h4>