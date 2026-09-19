using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aumentos_salariales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcion = "s";

            while (opcion == "s")
            {
                Console.WriteLine("\n--- Registro de empleado ---");

                Console.Write("Digite la cedula: ");
                string cedula = Console.ReadLine();

                Console.Write("Digite el nombre: ");
                string nombre = Console.ReadLine();

                Console.WriteLine("\nTipos de trabajador:");
                Console.WriteLine("1 - Operario");
                Console.WriteLine("2 - Tecnico");
                Console.WriteLine("3 - Profesional");
                Console.Write("Seleccione una opcion: ");
                int tipo = int.Parse(Console.ReadLine());

                Console.Write("Digite las horas trabajadas: ");
                float horas = float.Parse(Console.ReadLine());

                Console.Write("Digite el monto por hora: ");
                float pagoHora = float.Parse(Console.ReadLine());

                float salario = horas * pagoHora;
                float aumento;
                string tipoEmpleado;

                if (tipo == 1)
                {
                    aumento = salario * 0.15f;
                    tipoEmpleado = "Operario";
                }
                else if (tipo == 2)
                {
                    aumento = salario * 0.10f;
                    tipoEmpleado = "Tecnico";
                }
                else
                {
                    aumento = salario * 0.05f;
                    tipoEmpleado = "Profesional";
                }

                float bruto = salario + aumento;
                float ccss = bruto * 0.0917f;
                float neto = bruto - ccss;

                Console.WriteLine("\n--- Datos del empleado ---");
                Console.WriteLine("Cedula: " + cedula);
                Console.WriteLine("Nombre: " + nombre);
                Console.WriteLine("Tipo de empleado: " + tipoEmpleado);
                Console.WriteLine("Salario por hora: CRC " + pagoHora);
                Console.WriteLine("Cantidad de horas: " + horas);
                Console.WriteLine("Salario ordinario: CRC " + salario);
                Console.WriteLine("Aumento: CRC " + aumento);
                Console.WriteLine("Salario bruto: CRC " + bruto);
                Console.WriteLine("Deduccion CCSS: CRC " + ccss);
                Console.WriteLine("Salario neto: CRC " + neto);

                Console.Write("\n¿Quiere ingresar otro empleado? (s/n): ");
                opcion = Console.ReadLine().ToLower();
            }

            Console.WriteLine("\nFin del programa.");
        }
    }
}