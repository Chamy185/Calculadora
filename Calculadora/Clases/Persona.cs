using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora.Clases
{
    internal class Persona
    {
        //Atributos
        private string nombre="";
        private string apellido="";
        private DateTime fecha;
        private int edad;


        //Getters
        public string Nombre { get=> nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }

        //Edad calculada
        public int Edad { get => edad = DateTime.Now.Year - fecha.Year ;
                          set => edad = value;}

    }
}
