// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
 
// Somente declarando uma variavel do tipo inteira e sem valor
// int num1 ;

// console.WriteLine(num1) ;

// Declarando uma variavel do tipo inteiro e atribuindo valor 5
// int num2 = 5 ;00

// Declarando variavel String
// string nomeAluno = "Paulo"

// Variavel do tipo logico (true ou false)
// bool resultado = true ;

// Variavel do tipo double valor com varias casas decimais
// double coordenada = 1.803645628;

// Variavel do tipo decimal - utilizada para valores
// decimal valor = 1.80M; 

int idade = 16;
string meuNome = "Cauan";  
Console.WriteLine($"Meu nome é {meuNome} e tenho {idade} anos");
Console.WriteLine("");
Console.WriteLine(" Em qual cidade você nasceu?");
// Readlinevserve apenas para que eu receba uma informação do usuario
//e armazeno em um variavel
string nomeCidade = Console.Readline();
Console.WriteLine($"Você nasceu em {nomeCidade}");