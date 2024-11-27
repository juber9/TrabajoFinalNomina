using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinalNomina
{
    public class CalculosNomina
    {
        public string Nombre {  get; set; }
        private string NumeroInss {  get; set; }
        public string Departamento { get; set; }
        private double Salario { get; set; }
        public double HorasExtras { get; set; }
        public int Antiguedad { get; set; }

        public CalculosNomina(string nombre, string numeroInss, string departamento, double salario, double horasExtras, int antiguedad)
        {
            Nombre = nombre;
            NumeroInss = numeroInss;
            Departamento = departamento;
            Salario = salario;
            HorasExtras = horasExtras;
            Antiguedad = antiguedad;
        }

        public double CalcularHorasExtras(double horasExtras)
        {
            var calculoHorasExtras = Salario / 30 / 8 * horasExtras * 2;
            return calculoHorasExtras;
        }

        public double CalcularAntiguedad(int antiguedad)
        {
            double calculoAntiguedad = 0;
            if (antiguedad == 10)
            {
                calculoAntiguedad = Salario * 0.11;
            } 
            else if (antiguedad == 20)
            {
                calculoAntiguedad = Salario * 0.4;
            }
            else if (antiguedad == 25)
            {
                calculoAntiguedad = Salario * 0.45;
            }
            return calculoAntiguedad;
        }

        public double CalcularTotalIngresos(double Salario, double calculoHorasExtra, double calculoAntiguedad)
        {
            double totalDeIngresos = Salario + calculoHorasExtra + calculoAntiguedad;
            return totalDeIngresos;
        }
    }
}
