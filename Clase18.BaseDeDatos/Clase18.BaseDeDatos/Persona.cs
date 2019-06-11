﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase18.BaseDeDatos
{
    public class Persona
    {
        public int id;
        public string nombre;
        public string apellido;
        public int edad;

        public Persona(int id, string nombre, string apellido, int edad)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }

        public override string ToString()
        {
            return this.id.ToString() + " - " + this.nombre + " - " + this.apellido + " - " + this.edad.ToString();
        }
    }
}
