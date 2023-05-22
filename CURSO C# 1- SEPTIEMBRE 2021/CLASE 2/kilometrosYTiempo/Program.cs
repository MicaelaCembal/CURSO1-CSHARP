using System;

namespace kilometrosYTiempo
{
    class Program
    {
        static void Main(string[] args)
        {
          /* Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades y la velocidad promedio de un vehículo. 
          Calcular y emitir por pantalla el tiempo aproximado que demandará llegar de un punto a otro teniendo en cuenta los datos ingresados.*/

            float kilometros, velocidad, resultado; 
           Console.WriteLine("Ingrese kilometros: ");
           kilometros=float.Parse(Console.ReadLine()); 
           Console.WriteLine("Ingrese velocidad: ");
           velocidad=float.Parse(Console.ReadLine()); 
           resultado=kilometros/velocidad; 
           Console.WriteLine("El tiempo estimado es: " + resultado + " horas"); 
        }
    }
}
