using System;

namespace condicionalesIF4
{
    class Program
    {
        static void Main(string[] args)
        {
           //Hacer un programa para ingresar cuatro números distintos y luego mostrar por pantalla el menor de ellos.
           int numero1, numero2, numero3, numero4; 
           int min=9999; 
            Console.WriteLine("Ingrese un número: "); 
            numero1=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro: "); 
            numero2=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro: "); 
            numero3=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro: "); 
            numero4=int.Parse(Console.ReadLine());
            if (numero1<min)
            {
                min=numero1; 
            }
            if (numero2<min)
            {
                min=numero2; 
            }
            if (numero3<min)
            {
                min=numero3; 
            }
            if (numero4<min)
            {
                min=numero4; 
            }
            Console.WriteLine("El numero menor de los ingresados es " + min); 
        }
    }
}
