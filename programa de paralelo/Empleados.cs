using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace programa_de_paralelo
{
    internal class Empleados
    {
        // Definimos las propiedades públicas
        private string Nombre;// Almacena el nombre completo del empleado.
        private int NumeroEmpleado;//Almacena el Numero del empleado
        private decimal Salario;//Almacena el salario el empleado 
        private bool Activo;//Indica si el empleado está activo (trabajando) o inactivo (no esta trabajando).

        //Crea una nueva instancia de la clase Empleado con los valores especificados.
        public Empleados(string nombre, int numeroEmpleado, decimal salario, bool activo = true)
        {
            this.Nombre = nombre;
            this.NumeroEmpleado = numeroEmpleado;
            this.Salario = salario;
            this.Activo = activo;
        }

        // Muestra en la consola los detalles del empleado, incluyendo su nombre, numero de empleado, salario y el estado del empleado(si esta activo o inactivo).
        public void MostrarDetalles()
        {
            string estado = (Activo) ? "Activo" : "Inactivo"; 
            Console.WriteLine($"Nombre: {Nombre}, Número de Empleado: {NumeroEmpleado}, Salario: {Salario:C}, Estado: {estado}");
        }

        public int ObtenerNumeroEmpleado() 
        {
            return this.NumeroEmpleado;// Devuelve el valor actual de la propiedad NumeroEmpleado
        }

        
        public void CambiarEstado(int nuevoEstado)
        {
            if (nuevoEstado == 1)// Evalua el parámetro nuevoEstado.
            {
                Activo = true;// Si nuevoEstado es 1, establece la propiedad Activo en true
                Console.WriteLine("Empleado activado"); // Informa al usuario  que el empleado ha sido activado
            }
            else if (nuevoEstado == 0) 
            {
                Activo = false;// Si nuevoEstado es 0, establece la propiedad Activo en false.
                Console.WriteLine("Empleado desactivado");
            }
            else 
            {
                Console.WriteLine("Estado no valido ");// Si nuevoEstado no es ni 0 ni 1, imprime un mensaje diciendo que el estado no es valido
            }
        }




    }
}
