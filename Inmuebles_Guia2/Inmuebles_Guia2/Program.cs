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


            Accion accion = new Accion();

            Plazo plazo = new Plazo();
            Console.WriteLine("Bienvinido al sistema");
            int x = 0;

            while (x == 0)
            {
                Console.WriteLine("-------------------Menu---------------------");
                Console.WriteLine("1- Elaborar una Compra");
                Console.WriteLine("2- Elaborar una Venta");
                Console.WriteLine("3- Elaborar una Alquilacion");
                Console.WriteLine("4-Salir");

                int opc = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Datos de Empleado");
                Console.WriteLine("Nombre: ");
                string Nombre = Console.ReadLine();
                Console.WriteLine("Apellido: ");
                string Apellido = Console.ReadLine();
                Console.WriteLine("Edad: ");
                int Edad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Datos capturados");
                Empleado empleado = new Empleado(Nombre, Apellido, Edad);

                Console.WriteLine("--------------------------");
                Console.WriteLine("Datos de cliente");
                Console.WriteLine("Nombre: ");
                Nombre = Console.ReadLine();
                Console.WriteLine("Apellido: ");
                Apellido = Console.ReadLine();
                Console.WriteLine("Direccion: ");
                string Direccion = Console.ReadLine();
                Console.WriteLine("Telefono: ");
                int Telefono = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Datos capturados");
                Cliente cliente = new Cliente(Nombre, Apellido, Direccion, Telefono);

                Console.WriteLine("--------------------------");
                Console.WriteLine("Datos de Inmueble");
                Console.WriteLine("Codigo: ");
                string Codigo = Console.ReadLine();
                Console.WriteLine("Descripcion: ");
                string Descripcion = Console.ReadLine();
                Console.WriteLine("Tipo: ");
                string Tipo = Console.ReadLine();
                Inmueble inmueble = new Inmueble(Codigo, Descripcion, Tipo);
                Console.WriteLine("--------------------------");
                plazo.DatosPlazo();
                Console.WriteLine("--------------------------");
                switch (opc)
                {
                    case 1:


                        Console.Clear();
                        Console.WriteLine("---------------------Factura del Inmobiliario---------------------");
                        Console.WriteLine("Nombre del Empleado: " + empleado.Nombre + " " + empleado.Apellido);
                        Console.WriteLine("Nombre del Cliente: " + cliente.Nombre + " " + cliente.Apellido);
                        Console.WriteLine("Direccion: " + cliente.Direccion + " Telefono: " + cliente.Telefono);
                        accion.Compra();
                        Console.WriteLine("Codigo: " + inmueble.Codigo + " Descripcion: " + inmueble.Descripcion);
                        Console.WriteLine(" Tipo: " + inmueble.tipoInmuebele + " Plazo: " + plazo.meses);
                        break;

                    case 2:
                        Console.Clear();

                        Console.WriteLine("---------------------Factura del Inmobiliario---------------------");
                        Console.WriteLine("Nombre del Empleado: " + empleado.Nombre + " " + empleado.Apellido);
                        Console.WriteLine("Nombre del Cliente: " + cliente.Nombre + " " + cliente.Apellido);
                        Console.WriteLine("Direccion: " + cliente.Direccion + " Telefono: " + cliente.Telefono);
                        accion.Vender();
                        Console.WriteLine("Codigo: " + inmueble.Codigo + " Descripcion: " + inmueble.Descripcion);
                        Console.WriteLine(" Tipo: " + inmueble.tipoInmuebele + " Plazo: " + plazo.meses);
                        break;


                    case 3:
                        Console.Clear();

                        Console.WriteLine("---------------------Factura del Inmobiliario---------------------");
                        Console.WriteLine("Nombre del Empleado: " + empleado.Nombre + " " + empleado.Apellido);
                        Console.WriteLine("Nombre del Cliente: " + cliente.Nombre + " " + cliente.Apellido);
                        Console.WriteLine("Direccion: " + cliente.Direccion + " Telefono: " + cliente.Telefono);
                        accion.Alquiler();
                        Console.WriteLine("Codigo: " + inmueble.Codigo + " Descripcion: " + inmueble.Descripcion);
                        Console.WriteLine(" Tipo: " + inmueble.tipoInmuebele + " Plazo: " + plazo.meses);
                        break;

                    case 4:
                        Console.WriteLine("Desea Salir?");
                        x = 1;
                        break;

                }
            }
        }



    }

    abstract class Persona
    {
        //Atributos
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
        //Atributos
        public int Edad;

        //Constructor 
        public Empleado(string nombre, string apellido, int edad)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
        }

    }

    class Cliente : Persona
    {
        //Atributos     
        public string Direccion;
        public int Telefono;

        //Constructor
        public Cliente(string nombre, string apellido, string direccion, int telefono)
        {
            Nombre = nombre;
            Apellido = apellido;
            Direccion = direccion;
            Telefono = telefono;
        }
    }

    class Tipo
    {
        //Atributo
        public string tipoInmuebele;
    }

    class Inmueble : Tipo
    {
        //Atributo
        public string Codigo;
        public string Descripcion;


        //Construtor
        public Inmueble(string codigo, string descripcion, string tipo)
        {
            Codigo = codigo;
            Descripcion = descripcion;
            tipoInmuebele = tipo;

        }
    }

    class Accion
    {
        //Metodo
        public void Vender()
        {
            Console.WriteLine("Operacion a Realizar: Venta");
        }
        public void Compra()
        {
            Console.WriteLine("Operacion a Realizar: Compra");
        }
        public void Alquiler()
        {
            Console.WriteLine("Operacion a Realizar: Alquiler");
        }
    }

    class Plazo
    {
        //Atributo
        public int meses;

        //Metodo
        public void DatosPlazo()
        {
            Console.WriteLine("Datos de Plazo");
            Console.WriteLine("Meses: ");
            meses = Convert.ToInt32(Console.ReadLine());
        }
    }
}
