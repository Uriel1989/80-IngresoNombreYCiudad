using System;

/*Pedir por consola un nombre de persona y el nombre de una ciudad (no hace falta que sean reales o comprobarlos)
 * mostrar por pantalla, 
 * el siguiente mensaje “Hola ” <nombre> ” bienvenido a ” <ciudad>
 */

namespace _80_IngresoNombreYCiudad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un nombre de persona y luego uno de ciudad:");

            string n = Convert.ToString(Console.ReadLine());

            string c = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Hola " + n + " " + "bienvenido a " + c);
        }
    }
}
