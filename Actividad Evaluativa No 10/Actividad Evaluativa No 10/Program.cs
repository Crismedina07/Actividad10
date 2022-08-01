using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_Evaluativa_No_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salarioAnual = 0;
            double salarioMensual = 0;
            double retencion = 0;
            int caso = 0;


            Console.Write("Ingrese su salario mensual: ");
            salarioMensual = double.Parse(Console.ReadLine());
            salarioAnual = salarioMensual * 12;
            double rentaAnual = 0;

            if (salarioAnual <= 416200.00)
            {
                caso = 1;
            }
            else if (salarioAnual >= 416200.01 && salarioAnual <= 624329.00)
            {
                caso = 2;
            }
            else if (salarioAnual >= 624329.01 && salarioAnual <= 867123.00)
            {
                caso = 3;
            }
            else if (salarioAnual >= 867123.01)
            {
                caso = 4;
            }
            else
            {
                caso = 0;
            }

            if (caso !=0)
            {
                switch (caso)
                {
                    case 1:
                        rentaAnual = 0;
                        break;
                    case 2:
                        rentaAnual = (salarioAnual - 416220.01) * 0.15;
                        break;
                    case 3:
                        rentaAnual = (salarioAnual - 624329.01) * 0.20 + 31216.00;
                        break;
                    case 4:
                        rentaAnual = (salarioAnual - 867123.01) * 0.25 + 79776.00;
                        break;
                }
                retencion = rentaAnual / 12;
                Console.Write("La retención Mensual será de: " + retencion);
                Console.ReadKey();
            }


        }
    }
}
