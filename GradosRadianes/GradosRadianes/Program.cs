using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradosRadianes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Qué tipo de conversión deseas realizar?");
            Console.WriteLine("1. Grados a Radianes");
            Console.WriteLine("2. Radianes a Grados");

            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    ConvertirGradosARadianes();
                    break;
                case 2:
                    ConvertirRadianesAGrados();
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }

        static void ConvertirGradosARadianes()
        {
            Console.Write("Introduce el valor en grados: ");
            double grados = Convert.ToDouble(Console.ReadLine());
            double radianes = grados * (Math.PI / 180);
            Console.WriteLine($"{grados} grados equivalen a {radianes} radianes.");
        }

        static void ConvertirRadianesAGrados()
        {
            Console.Write("Introduce el valor en radianes: ");
            double radianes = Convert.ToDouble(Console.ReadLine());
            double grados = radianes * (180 / Math.PI);
            Console.WriteLine($"{radianes} radianes equivalen a {grados} grados.");
        }
    }
}
