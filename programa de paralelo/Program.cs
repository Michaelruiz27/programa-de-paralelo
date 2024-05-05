using System;

namespace programa_de_paralelo
{

    public class Program
    {
        public static void Main(string[] args)
        {
            List<Empleados> listaEmpleados = new List<Empleados>();

            // Agregamos empleados a la lista
            listaEmpleados.Add(new Empleados("Juan", 101, 30000));
            listaEmpleados.Add(new Empleados("María", 102, 35000));
            listaEmpleados.Add(new Empleados("Pedro", 103, 32000, false)); // El empleado Pedro está inactivo

            // Mostramos los detalles de todos los empleados
            foreach (var empleado in listaEmpleados)
            {
                empleado.MostrarDetalles();
            }

            // Se cambia el estado del empleado
            int numeroEmpleadoCambiarEstado = 103;

            // Se busca al empleado con el número asignado
            Empleados empleadoCambiarEstado = BuscarEmpleado(listaEmpleados, numeroEmpleadoCambiarEstado);

            // Se revisa si el empleado se encontró con ese número asignado
            if (empleadoCambiarEstado != null)
            {
                // Se cambia el estado a activo
                empleadoCambiarEstado.CambiarEstado(1);

                // Se muestran los detalles del empleado actualizados
                Console.WriteLine("Detalles del empleado actualizado:");
                empleadoCambiarEstado.MostrarDetalles();
            }
            else
            {
                // Si no encuentra al empleado se notifica al usuario
                Console.WriteLine($"Empleado con número {numeroEmpleadoCambiarEstado} no encontrado.");
            }
        }

        static Empleados BuscarEmpleado(List<Empleados> empleados, int numeroEmpleado)
        {
            // Se recorre la lista de empleados
            foreach (var empleado in empleados)
            {
                // Se compara el número del empleado con el buscado
                if (empleado.ObtenerNumeroEmpleado() == numeroEmpleado)
                {
                    // Si se encuentra, retornamos el empleado
                    return empleado;
                }
            }

            // Si no se encuentra, retornamos null indicando que no se encontro el empleado
            return null;

        }
    }
}

