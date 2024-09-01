using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}