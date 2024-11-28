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
            // Cálculo del ingreso sujeto a IR
            double ingresoNetoAnual = (totalIngresos - inssLaboral) * 12;

            double ir;

            // Calcular IR según los tramos
            if (ingresoNetoAnual <= 100000)
            {
                ir = 0;
            }
            else if (ingresoNetoAnual <= 200000)
            {
                ir = (ingresoNetoAnual - 100000) * 0.15;
            }
            else if (ingresoNetoAnual <= 350000)
            {
                ir = (ingresoNetoAnual - 200000) * 0.20 + 15000;
            }
            else if (ingresoNetoAnual <= 500000)
            {
                ir = (ingresoNetoAnual - 350000) * 0.25 + 45000;
            }
            else
            {
                ir = (ingresoNetoAnual - 500000) * 0.30 + 82500;
            }

            // Convertir el IR anual a mensual
            return ir / 12;
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
