using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, resultado; 
            Console.WriteLine("Ingrese un número: ");
            numero1=int.Parse(Console.ReadLine()); 
            Console.WriteLine("Ingrese otro: ");
            numero2=int.Parse(Console.ReadLine()); 
            resultado=numero1+numero2; 
            Console.WriteLine("La suma es: " + resultado);
        }
    }
}
