﻿using System;

namespace condicionalesIF
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Hacer un programa para ingresar un número y luego se emita por pantalla un cartel aclaratorio 
            si “Es mayor a 10” o “No es mayor a 10”.*/
            int numero; 
            Console.WriteLine("Ingrese un número: "); 
            numero=int.Parse(Console.ReadLine());
            if (numero>10)
            {
            Console.WriteLine("El número " + numero + " es mayor a 10"); 
            }
            else
            {
                 Console.WriteLine("El número " + numero + " no es mayor a 10"); 
            }
        }
    }
}
