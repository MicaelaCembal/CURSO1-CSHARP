using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, resta, suma, multiplicación; 
            /*
            1. Hacer un programa que solicite el ingreso de dos números y luego calcular:
            La resta si el primero es mayor que el segundo.
            La suma si son iguales.
            El producto si el primero es menor.
            Se deberá emitir un cartel por pantalla con el resultado correspondiente.
            */
            Console.WriteLine("Ingrese un numero"); 
            numero1=int.Parse(Console.ReadLine()); 
            Console.WriteLine("Ingrese un numero"); 
            numero2=int.Parse(Console.ReadLine()); 

            if(numero1>numero2)
            {
                resta=numero1-numero2;
                Console.WriteLine("La resta es: " + resta);
            }
            if(numero1<numero2)
            {
                multiplicación=numero1*numero2;
                Console.WriteLine("La multiplicación es: " + multiplicación);
            }
            if(numero1==numero2)
            {
                suma=numero1+numero2;
                Console.WriteLine("La suma es: " + suma);
            }

        }
    }
}
