using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero,max, i; 
            max=0;
         /*Hacer un programa que solicite el ingreso de 10 números y que muestre el mayor de ellos por pantalla. 
         Solo se debe emitir UN valor por pantalla.*/
          for(i=1; i <10; i++)
            {
               Console.WriteLine("Ingrese un numero: " +i);
               numero=int.Parse(Console.ReadLine()); 
               if (numero>max)
               {
                   max=numero; 
               }
           }
           Console.WriteLine("El numero maximo de los ingresados es " +max);
        }
    }
}
