using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmuebles_Guia2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado();
            Cliente cliente = new Cliente();
            Inmueble inmueble = new Inmueble();
            Plazo plazo = new Plazo();

            Console.WriteLine("Bienvinido al sistema");
            int x = 0;
            
            while(x == 0)
            {
                Console.WriteLine("-------------------Menu---------------------");
                Console.WriteLine("1- Elaborar comprar");
                Console.WriteLine("2-Salir");
                
                int opc = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (opc)
                {
                        case 1:
                        empleado.DatosEmpleado();
                        Console.WriteLine("--------------------------");
                        cliente.DatosCliente();
                        Console.WriteLine("--------------------------");
                        inmueble.DatosInmueble();
                        Console.WriteLine("--------------------------");
                        plazo.DatosPlazo();
                        Console.WriteLine("--------------------------");

                        Console.Clear();
                      
                        Console.WriteLine("---------------------Factura del Inmobiliario---------------------");
                        Console.WriteLine("Nombre del Empleado: " + empleado.Nombre + " " + empleado.Apellido);
                        Console.WriteLine("Nombre del Cliente: " + cliente.Nombre + " " + cliente.Apellido);
                        Console.WriteLine("Direccion: " + cliente.direccion + " Telefono: " + cliente.telefono);
                        Console.WriteLine("Codigo: " + inmueble.codigo + " Descripcion: " + inmueble.descripcion);
                        Console.WriteLine(" Tipo: " + inmueble.tipo + " Plazo: " + plazo.meses);
                        break;

                        case 2:
                             Console.WriteLine("Desea Salir?");
                             x = 1;
                        break;
                }              
            }

          
            

        }

       

    }
     abstract class Persona
    {
        private string nombre;
        private string apellido;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
    }

    class Empleado : Persona
    {

        public int edad;
       

        public void DatosEmpleado()
        {
            Console.WriteLine("Datos de Empleado");
            Console.WriteLine("Nombre: ");
            Nombre= Console.ReadLine();
            Console.WriteLine("Apellido: ");
            Apellido= Console.ReadLine();
            Console.WriteLine("Edad: ");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Datos capturados");

        }
    }

    class Cliente : Persona
    {    
        public int telefono;     
        public string direccion;
        public void DatosCliente()
        {
            Console.WriteLine("Datos de cliente");
            Console.WriteLine("Nombre: ");
            Nombre = Console.ReadLine();
            Console.WriteLine("Apellido: ");
            Apellido = Console.ReadLine();
            Console.WriteLine("Direccion: ");
            direccion = Console.ReadLine();
            Console.WriteLine("Telefono: ");
            telefono= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Datos capturados");
        }
    }

    class Tipo
    {
        public string tipo;
    }

    class Inmueble : Tipo
    {
        public string codigo;
        public string descripcion;

        public void DatosInmueble()
        {
            Console.WriteLine("Datos de Inmueble");
            Console.WriteLine("Codigo: ");
            codigo= Console.ReadLine();
            Console.WriteLine("Descripcion: ");
            descripcion= Console.ReadLine();
            Console.WriteLine("Tipo: ");
            tipo= Console.ReadLine();
        }
    }

    class Plazo
    {

        public int meses;

        public void DatosPlazo()
        {
            Console.WriteLine("Datos de Plazo");
            Console.WriteLine("Meses: ");
            meses = Convert.ToInt32(Console.ReadLine());
        }
    }
}
