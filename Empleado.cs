using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace ExamenII
{
        public class Empleado
        {
            public string Nombre { get; set; }
            public string Apellidos { get; set; }
            public double SueldoBruto { get; set; }
            public char Categoria { get; set; }
            public double MontoAumento { get; set; }
            public double SueldoNeto { get; set; }
        }

}
