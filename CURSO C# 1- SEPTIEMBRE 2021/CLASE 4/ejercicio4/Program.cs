using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, numero3; 
           /*Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si la suma de los dos primeros
            es mayor al producto del segundo con el tercero.*/
            Console.WriteLine("Ingrese un numero"); 
            numero1=int.Parse(Console.ReadLine()); 
            Console.WriteLine("Ingrese otro"); 
            numero2=int.Parse(Console.ReadLine()); 
            Console.WriteLine("Ingrese otro"); 
            numero3=int.Parse(Console.ReadLine()); 
            if ((numero1+numero2)> (numero2*numero3))
            {
                Console.WriteLine("La suma de los dos primero ES mayor al producto del segundo con el tercero"); 
            }
            else
            {
                 Console.WriteLine("La suma de los dos primeros NO ES mayor al producto del segundo con el tercero"); 
            }
        }
    }
}
