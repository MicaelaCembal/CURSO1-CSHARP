using System;

namespace casaComputacion
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 más una comisión del 5% sobre el total facturado }
            por cada empleado. Hacer un programa para ingresar el total facturado por un empleado y
             que luego calcule y emita por pantalla el sueldo total a cobrar por el mismo.*/
             float totalFacturado, comision, sueldoTotal; 
             int sueldoBase=15000; 
             Console.WriteLine("Ingrese total facturado: ");
            totalFacturado=float.Parse(Console.ReadLine()); 
            comision=((totalFacturado*5)/100); 
            sueldoTotal=comision+sueldoBase; 
             Console.WriteLine("El sueldo total es: " + sueldoTotal);
        }
    }
}
