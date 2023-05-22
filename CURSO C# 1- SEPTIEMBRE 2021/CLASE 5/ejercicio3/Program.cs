using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
           /*Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas personas mayores a 18 años.*/
           int edades, i, promedio=0, tope=20, acuEdades=0; 
           for(i=0; i<tope; i++)
           {
               Console.WriteLine("Ingrese edad: "); 
               edades=int.Parse(Console.ReadLine()); 
               if (edades>=18)
               {
                   acuEdades=acuEdades+edades; 
               }  
            }
            promedio=acuEdades/tope; 
            Console.WriteLine("El promedio de las edades mayores a 18 es: " + promedio); 
        }
    }
}
