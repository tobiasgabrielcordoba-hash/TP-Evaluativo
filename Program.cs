using Empleados.Classes;

namespace TP_Evaluativo
{
    internal class Program
    {
        static List<Empleado> listaEmpleados = new List<Empleado>();
        static void Main(string[] args)
        {
            bool notexit = true;
            while (notexit)
            {

                Console.WriteLine();
                Console.WriteLine("--- ELIJA ALGUNA DE LAS SIGUIENTES OPCIONES ---");
                Console.WriteLine("1: Agregar empleados");
                Console.WriteLine("2: Mostrar sueldos adicionales");
                Console.WriteLine("3: Reiniciar la tabla de empleados");
                Console.WriteLine("4: Salir");

                int op = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (op)
                {

                    case 1:

                        Ingresar();
                        Console.WriteLine("Empleado agregado con éxito, para seguir con la lista de opciones, presione cualquier tecla");
                        Console.ReadLine();

                        break;

                    case 2:

                        Calcular();
                        Console.WriteLine("Para seguir con la lista de opciones, presione cualquier tecla");
                        Console.ReadLine();

                        break;

                    case 3:

                        Reiniciar();
                        Console.WriteLine("Lista de empleados reiniciada, para seguir con la lista de opciones, presione cualquier tecla");
                        Console.ReadLine();

                        break;

                    case 4:

                        notexit = false;

                        break;

                    default:

                        Console.WriteLine("Esa no es una opción dentro de la lista, presione cualquier tecla para volver a elegir");
                        Console.ReadKey();

                        break;

                }

                Console.Clear();

            }

        }
        static void Ingresar()
        {
            string nombre;
            int dni;
            int op;
            bool tipo;
            double sueldo_base;
            int factor;

            Console.WriteLine("Ingrese el nombre del empleado:");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el DNI del empleado:");
            dni = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.WriteLine("Ingrese el tipo de empleado");
                Console.WriteLine("1: Vendedor");
                Console.WriteLine("2: Directivo");
                op = Convert.ToInt32(Console.ReadLine());

                if (op == 1)
                {
                    tipo = true;
                }
                else
                {
                    tipo = false;
                }

            } while (op != 1 && op != 2);

            Console.WriteLine("Ingrese el sueldo base del empleado:");
            sueldo_base = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el factor de sueldo agregado:");
            factor = Convert.ToInt32(Console.ReadLine());

            if (tipo)
            {

                listaEmpleados.Add(new Vendedor(nombre, dni, sueldo_base, factor));

            }
            else
            {

                listaEmpleados.Add(new Directivo(nombre, dni, sueldo_base, factor));

            }
        }
        static void Calcular()
        {

            Console.WriteLine("Nombre | DNI | Tipo | Sueldo base | Factor | Sueldo total");

            foreach (var empleado in listaEmpleados)
            {

                Console.WriteLine($"{empleado.Nombre} | {empleado.DNI} | {empleado.tipo} | {empleado.Sueldo_base} | {empleado.Factor} | {empleado.sumarSueldoAdicional()}");

            }

        }
        static void Reiniciar()
        {

            listaEmpleados.Clear();

        }
    }
}
