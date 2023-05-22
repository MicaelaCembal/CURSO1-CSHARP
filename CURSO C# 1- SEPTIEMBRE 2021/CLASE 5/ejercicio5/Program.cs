using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
           /*Hacer un programa que solicite 20 números y luego emitir por pantalla 
           el máximo de los números pares y el mínimo de los números impares.*/
           int numeros, tope=4, max=0, min=999999, i; 
           for(i=0; i<tope; i++)
           {
               Console.WriteLine("Ingrese numero: "); 
               numeros=int.Parse(Console.ReadLine()); 
               if(numeros%2==0)
               {
                   if(numeros>max)
                   {
                    max=numeros; 
                   }
               }
               else
               {
                   if(numeros<min)
                   {
                    min=numeros; 
                   }
               }
           }
            Console.WriteLine("El numero par mayor es: " + max); 
            Console.WriteLine("El numero impar menor es: " + min); 
        }
    }
}
