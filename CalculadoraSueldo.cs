using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenII
{
    public class CalculadoraSueldo
    {
        public void CalcularAumentoYSueldoNeto(Empleado empleado)
        {
            double porcentajeAumento = 0;

            if (empleado.SueldoBruto <= 1000)
                porcentajeAumento = 0.1;
            else if (empleado.SueldoBruto <= 2000)
                porcentajeAumento = 0.2;
            else if (empleado.SueldoBruto <= 4000)
                porcentajeAumento = 0.3;
            else
                porcentajeAumento = 0.4;

            empleado.MontoAumento = porcentajeAumento * empleado.SueldoBruto;
            empleado.SueldoNeto = empleado.SueldoBruto + empleado.MontoAumento;
        }
    }
}
