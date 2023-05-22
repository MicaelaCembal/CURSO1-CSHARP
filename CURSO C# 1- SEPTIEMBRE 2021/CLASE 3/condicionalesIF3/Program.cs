using System;

namespace condicionalesIF3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Una casa de video juegos otorga un descuento dependiendo del importe de la compra realizada según los siguientes valores:
            Si el importe es menor a ARS 1000, no hay descuento.
            Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10%.
            Si el importe es ARS 5000 o más, aplica un descuento del 18%.
            Hacer un programa para ingresar un importe de venta y luego muestre por pantalla el importe final con el descuento que corresponda.*/
            double importe, descuento1, descuento2; 
            double descuento_1=0.90;
            double descuento_2=0.82;
            Console.WriteLine("Ingrese un importe: "); 
            importe=double.Parse(Console.ReadLine());
            if ((importe>1000) && (importe<5000))
            {
                descuento1=(importe*descuento_1); 
                Console.WriteLine("El importe " + importe + " con el descuento queda en " + descuento1); 
            }
            if (importe>=5000) 
            {
                descuento2=(importe*descuento_2); 
                Console.WriteLine("El importe " + importe + " con el descuento queda en " + descuento2); 
            }
             if (importe<1000) 
            {
                Console.WriteLine("No hay descuento"); 
            }
        }
    }
}
