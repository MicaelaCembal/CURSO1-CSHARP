using System;

namespace condicionalesIF2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Hacer un programa para ingresar un número y luego se emita un cartel por pantalla “Positivo” si el número es mayor a cero,
             “Negativo” si el número es menor a cero o “Cero” si el número es igual a cero.
            */
            int numero; 
            Console.WriteLine("Ingrese un número: "); 
            numero=int.Parse(Console.ReadLine());
            if (numero>0)
            {
            Console.WriteLine("El número " + numero + " es positivo"); 
            }
            if (numero==0)
            {
            Console.WriteLine("El número " + numero + " es igual a cero"); 
            }
            if (numero<0)
            {
             Console.WriteLine("El número " + numero + " es negativo"); 
            }
        }
    }
}
