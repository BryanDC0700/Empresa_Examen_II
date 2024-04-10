using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenII
{
    using System.Collections.Generic;

    public class EmpleadoDAO
    {
        private List<Empleado> empleados = new List<Empleado>();

        public void AgregarEmpleado(Empleado empleado)
        {
            empleados.Add(empleado);
        }

        public List<Empleado> ObtenerEmpleados()
        {
            return empleados;
        }
    }
}
