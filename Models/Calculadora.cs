using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace OperadoresAritimetricos.Models
{
    public class Calculadora
    {
         public void Somar (int x, int y) // Definimos o nome da função Somar e passamos duas classes inteiras para a função receber números inteiros
        {
            Console.WriteLine($"{x} + {y} = {x + y}"); //O console writeLine exibi na tela o resultado, primeiro mostra os números que serão feitos o calculo e depois o resultado
        }
         public void Subitrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }
         public void Multiplicar (int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }
         public void Dividir (int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }

        public void Potencia (int x, int y)  // Criando função que realiza potenciação 
        {
            double pot = Math.Pow(x ,y); // Math é uma biblioteca de operações embutida no C# utilzamos a math para realizar operações mais complexas. 
            //duble é uma class que representa  números grandes e com virgula se necessario.
            Console.WriteLine($"{x}^{y} = {pot}"); 
        }

        public void Seno (double angulo)                    //Agora criei funções que retornam valores trigonometricos (Seno, Coseno e Tangente) utilizando Math
            {
                double radiano = angulo * Math.PI / 180;    // Denominamos variavel duble, passamos o angulo, multiplicamos por PI (3,14) e dividimos por 180, para encontrar o radiano
                double seno = Math.Sin(radiano); // Aqui temos a variavel seno que recebe o valor do radiano e calcula seu Seno
                Console.WriteLine($"Seno de {angulo} = {Math.Round(seno, 4)}"); // Aqui exibimos o valor do calculo, math.round possibilita exibir a quantidade de casas decimais preferidas.
            }

            public void Conseno (double angulo)
            {
                double radiano = angulo * Math.PI / 180;
                double coseno = Math.Cos(radiano);
                Console.WriteLine($"Coseno de {angulo} = {Math.Round (coseno, 4)}");
            }

            public void Tangente (double angulo)
            {
                double radiano = angulo * Math.PI / 180;
                double tangente = Math.Tan(radiano);
                Console.WriteLine($"Tangente de {angulo} = {Math.Round(tangente, 4)}"); // O mesmo principio foi utilizado para criar as tres funções apenas mudei a função Math (Sin, Cos e Tan)
            }

            
                
    }
}