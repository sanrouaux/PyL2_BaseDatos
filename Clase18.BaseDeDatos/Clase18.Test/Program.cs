using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase18.BaseDeDatos;

namespace Clase18.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            AccesoDatos data = new AccesoDatos();

            //List<Persona> lista = new List<Persona>();

            //lista = data.TraerTodos();

            //foreach(Persona p in lista)
            //{
            //    Console.WriteLine(p.ToString());
            //}

            Persona p = new Persona(10, "Santiago", "Gonzalez", 40);
            if(data.AgregarPersona(p) == true)
            {
                Console.WriteLine("Se agregó una persona");
            }
            else
            {
                Console.WriteLine("No se pudo agregar la persona");
            }

            Console.ReadKey();
        }
    }
}
