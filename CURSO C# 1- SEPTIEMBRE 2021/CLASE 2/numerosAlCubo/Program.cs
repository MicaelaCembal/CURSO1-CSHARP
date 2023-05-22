using System;

namespace numerosAlCubo
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, resultado; 
            Console.WriteLine("Ingrese un numero: ");
            numero=int.Parse(Console.ReadLine()); 
            resultado=(numero*numero*numero); 
             Console.WriteLine("El numero " + numero + " elevado al cubo es " + resultado);
        }
    }
}
