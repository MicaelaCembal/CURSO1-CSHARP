using System;

namespace TRABAJO_FINAL_CURSO__MICA_CEMBAL
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero. A partir de dichos datos informar:
                a. El mayor de los números pares.
                b. La cantidad de números impares.
                c. El menor de los números primos.*/
            int numero, max = -1, min=-1, contImpares = 0;
            numero = ingresarNumero("Ingrese un numero: ");
            while (numero != 0)
            {
                if (numero % 2 == 0)
                {
                    if ((max == -1) || (numero > max))
                    {
                        max = numero;
                    }
                }
                else
                {
                    contImpares++;
                }
                if (esPrimo(numero))
                {
                    if ((min == -1) || (numero < min))
                    {
                        min = numero;
                    }
                }
                numero = ingresarNumero("Ingrese un numero: ");
            }
            Console.WriteLine("El mayor de los números pares es: " + max);
            Console.WriteLine("La cantidad de números impares es: " + contImpares);
            Console.WriteLine("El menor de los números primos es: " + min);
        }
        static int ingresarNumero(string msj)
        {
            int num;
            Console.WriteLine(msj);
            num = int.Parse(Console.ReadLine());
            return num;
        }
        static bool esPrimo(int n)
        {
            int contador = 0;
            for (int j = 1; j <= n; j++)
            {
                if (n % j == 0)
                {
                    contador++;
                }
            }
            if (contador == 2)
            {
                return true;
            }
            else
            {
                return false; 
            }
        }
    }
}
