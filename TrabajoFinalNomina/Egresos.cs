using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TrabajoFinalNomina
{
    public class Egresos : CalculosNomina
    {
        public Egresos(string nombre, string numeroInss, string departamento, double salario, double horasExtras, int antiguedad) : base(nombre, numeroInss, departamento, salario, horasExtras, antiguedad)
        {
        }

        public double CalcularInssLaboral(double totalDeIngresos)
        {
            double inssLaboral = totalDeIngresos * 0.7;
            return inssLaboral;
        }

        public double CalcularIr(double totalDeIngresos, double inssLaboral)
        {
            double calculandoIr = 0;
            calculandoIr = totalDeIngresos * 2; 
            double inssLaboral2 = inssLaboral * 2;
            calculandoIr = calculandoIr - inssLaboral2;

            return calculandoIr;
        }
    }
}
