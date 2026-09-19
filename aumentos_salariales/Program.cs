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
            // Solución Aumentos salariales
            // Estudiante: Eduardo López

            // Variable para controlar si se desea ingresar otro empleado
            string opcion = "si";

            // Repite el programa mientras el usuario diga que si
            while (opcion == "si")
            {
                // Se piden los datos del empleado
                Console.WriteLine("\n--- Registro de empleado ---");

                // Se solicita la cedula
                Console.Write("Digite la cedula: ");
                string cedula = Console.ReadLine();

                // Se solicita el nombre
                Console.Write("Digite el nombre: ");
                string nombre = Console.ReadLine();

                // Se muestran los tipos de empleado
                Console.WriteLine("\nTipos de trabajador:");
                Console.WriteLine("1 - Operario");
                Console.WriteLine("2 - Tecnico");
                Console.WriteLine("3 - Profesional");

                // Se solicita el tipo de empleado
                Console.Write("Seleccione una opcion: ");
                int tipo = int.Parse(Console.ReadLine());

                // Se solicitan las horas trabajadas
                Console.Write("Digite las horas trabajadas: ");
                float horas = float.Parse(Console.ReadLine());

                // Se solicita el precio por hora
                Console.Write("Digite el monto por hora: ");
                float pagoHora = float.Parse(Console.ReadLine());

                // Se calcula el salario ordinario
                float salario = horas * pagoHora;

                // Variables para guardar los calculos
                float aumento;
                string tipoEmpleado;

                // Se calcula el aumento segun el tipo de empleado
                if (tipo == 1)
                {
                    // El operario recibe un aumento del 15%
                    aumento = salario * 0.15f;
                    tipoEmpleado = "Operario";
                }
                else if (tipo == 2)
                {
                    // El tecnico recibe un aumento del 10%
                    aumento = salario * 0.10f;
                    tipoEmpleado = "Tecnico";
                }
                else
                {
                    // El profesional recibe un aumento del 5%
                    aumento = salario * 0.05f;
                    tipoEmpleado = "Profesional";
                }

                // Se calcula el salario bruto
                float bruto = salario + aumento;

                // Se calcula la deduccion del 9.17% de la CCSS
                float ccss = bruto * 0.0917f;

                // Se calcula el salario neto
                float neto = bruto - ccss;

                // Se muestran los resultados
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

                // Se pregunta si desea ingresar otro empleado
                Console.Write("\n¿Desea ingresar otro empleado? (si/no): ");
                opcion = Console.ReadLine().ToLower();
            }

            // Mensaje cuando termina el programa
            Console.WriteLine("\nFin del programa.");
        }
    }
}