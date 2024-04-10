    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenII
{
    internal class Empleado
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public double SueldoBruto { get; set; }
        public char Categoria { get; set; }
        public double MontoAumento { get; set; }
        public double SueldoNeto { get; set; }

        public Empleado(string nombre, string apellidos, double sueldoBruto, char categoria)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            SueldoBruto = sueldoBruto;
            Categoria = categoria;
        }
    }
}
