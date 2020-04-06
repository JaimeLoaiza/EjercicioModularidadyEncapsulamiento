using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicoModularidadyEncapsulamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleados empleado = new Empleados();
            empleado.Edad = 8;
            empleado.Nombre = "Salomon Loaiza Gutierrez";
            empleado.SueldoDiario = 193600.00m;
            decimal total;
            total = empleado.CalcularSalario(30);
            Console.WriteLine("El Salario mensual del Empleado " + empleado.Nombre);
            Console.WriteLine("es: " + total.ToString("C"));
            Console.ReadKey();
        }
    }
}
