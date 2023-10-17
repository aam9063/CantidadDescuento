/*
Se pide una cantidad y su precio. Hay que hallar el total aplicando un tanto por ciento de descuento según la cantidad comprada. CANTIDAD DESCUENTO 0 10 0% 11 30 5% 31 50 10%
+50
*/

using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Ingrese la cantidad de productos:");
        int cantidad = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el precio unitario del producto:");
        decimal precioUnitario = Convert.ToDecimal(Console.ReadLine());

        decimal total = CalcularTotalConDescuento(cantidad, precioUnitario);
        Console.WriteLine($"Total a pagar: {total:C}");
    }

    static decimal CalcularTotalConDescuento(int cantidad, decimal precioUnitario)
    {
        decimal descuento = 0;

        if (cantidad >= 11 && cantidad <= 30)
        {
            descuento = 5;
        }
        else if (cantidad >= 31 && cantidad <= 50)
        {
            descuento = 10;
        }
        else if (cantidad > 50)
        {
            descuento = 15;
        }

        decimal totalSinDescuento = cantidad * precioUnitario;
        decimal descuentoAplicado = totalSinDescuento * descuento / 100;
        decimal totalConDescuento = totalSinDescuento - descuentoAplicado;

        return totalConDescuento;
    }
}
