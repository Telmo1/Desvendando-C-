using OperadoresAritimetricos.Models;

Console.WriteLine("Hello, World!");

Calculadora calc = new Calculadora(); // Instanciamos uma nova class a ser gerada

//Utilizamos a variavel cal e chamos as funções com o (.) PONTO

calc.Somar(10, 30);
calc.Subitrair(10, 50);
calc.Multiplicar(15, 45);
calc.Dividir(2, 2);
calc.Potencia(3, 3);
calc.Seno(30);
calc.Conseno(30);
calc.Tangente(30);

// Aprendendo a Incrementar e Decrementar utlizando ++ e --

int numeroI = 10; 
int numeroD = 20;

Console.WriteLine(numeroI);
Console.WriteLine(numeroD);

Console.WriteLine("Incrementando o 10");
Console.WriteLine("Decrementando o 20");
// numero = numeroI + 1;
// numero = numeroD - 1;

numeroD--;
numeroI++;

Console.WriteLine(numeroI);
Console.WriteLine(numeroD);


// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();

// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//     Console.WriteLine("É vogal");
//     break;

//     default:
//     Console.WriteLine("Não é vogal");
//     break;
// }
