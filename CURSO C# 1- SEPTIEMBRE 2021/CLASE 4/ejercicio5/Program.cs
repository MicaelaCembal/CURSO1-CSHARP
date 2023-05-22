using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, numero3, numero4; 
            /*Hacer un programa para ingresar 4 números. 
            Luego analizar e informar por pantalla si los mismos se encuentran ordenados de forma decreciente.*/
            Console.WriteLine("Ingrese un numero"); 
            numero1=int.Parse(Console.ReadLine()); 
            Console.WriteLine("Ingrese otro"); 
            numero2=int.Parse(Console.ReadLine()); 
            Console.WriteLine("Ingrese otro"); 
            numero3=int.Parse(Console.ReadLine());  
            Console.WriteLine("Ingrese otro"); 
            numero4=int.Parse(Console.ReadLine()); 
            if((numero1>numero2)&&(numero2>numero3)&&(numero3>numero4))
            {
                Console.WriteLine("Los numeros se encuentran ordenados de forma decreciente"); 
            }
            else
            {
                Console.WriteLine("Los numeros NO se encuentran ordenados de forma decreciente"); 
            }
        }
    }
}
