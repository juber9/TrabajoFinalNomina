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

        public double CalcularInssLaboral(double totalIngresos)
        {
            double inssLaboral = totalIngresos * 0.07;
            return inssLaboral;
        }

        public double CalcularIr(double totalIngresos, double inssLaboral)
        {
            double calculandoIr;
            calculandoIr = totalIngresos * 2;
            calculandoIr = calculandoIr - inssLaboral * 2;
            calculandoIr = calculandoIr * 12;

            if (calculandoIr > 100000.01)
            {
                calculandoIr -= 100000;
                calculandoIr *= 0.15;
                calculandoIr = calculandoIr / 12;
            }
            else if (calculandoIr < 200000.01)
            {
                calculandoIr -= 200000;
                calculandoIr *= 0.20;
                calculandoIr += 15000;
                calculandoIr = calculandoIr / 12;
            }
            else if (calculandoIr > 350000.01)
            {
                calculandoIr -= 350000;
                calculandoIr *= 0.25;
                calculandoIr += 45000;
                calculandoIr = calculandoIr / 12;
            }
            else if (calculandoIr > 500000.01)
            {
                calculandoIr -= 500000;
                calculandoIr *= 0.30;
                calculandoIr += 825000;
                calculandoIr = calculandoIr / 12;
            } else if (calculandoIr <= 100000)
            {
                calculandoIr = 0;
            }

            double ir = calculandoIr;
            return ir;
        }

        public double CalcularTotalDeducciones(double inssLaboral, double ir)
        {
            double totalDeducciones = inssLaboral + ir;
            return totalDeducciones;
        }

        public double CalcularRemuneracionNetaDelSalario(double totalIngresos, double totalDeducciones)
        {
            double remuneracionNetaDelSalario = totalIngresos + totalDeducciones;
            return remuneracionNetaDelSalario;
        }

        public double CalcularInatec(double totalIngresos)
        {
            double inatec = totalIngresos * 0.2;
            return inatec;
        }

        public double CalcularInssPatronal(double totalIngresos)
        {
            double inssPatronal = totalIngresos * 0.225;
            return inssPatronal;
        }

        public double CalcularVacaciones(double totalIngresos)
        {
            double vacaciones = totalIngresos / 12;
            return vacaciones;
        }

        public double CalcularTreceavoMes(double totalIngresos)
        {
            double treceavoMes = totalIngresos / 12;
            return treceavoMes;
        }
    }
}
