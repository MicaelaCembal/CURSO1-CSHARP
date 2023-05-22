using System;

namespace condicionalesIF5
{
    class Program
    {
        static void Main(string[] args)
        {
           //Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuáles son mayores a 100.
            int numero1, numero2, numero3, numero4; 
            Console.WriteLine("Ingrese un número: "); 
            numero1=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro: "); 
            numero2=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro: "); 
            numero3=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro: "); 
            numero4=int.Parse(Console.ReadLine());
            if (numero1>100)
            {
                Console.WriteLine("El numero " + numero1 + " es mayor a 100");
            }
            if (numero2>100)
            {
                Console.WriteLine("El numero " + numero2 + " es mayor a 100");
            }
            if (numero3>100)
            {
                 Console.WriteLine("El numero " + numero3 + " es mayor a 100");
            }
            if (numero4>100)
            {
                 Console.WriteLine("El numero " + numero4 + " es mayor a 100");
            }
        }
    }
}
