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
            //Voler al inicio en caso que el usuario desee realizar varias operaciones
            inicio:
            try
            {
                double salarioAnual = 0;
                double salarioMensual = 0;
                double retencion = 0;
                int caso = 0;
                double rentaAnual = 0;
                string desicion;


                Console.Write("Ingrese su salario mensual: ");
                salarioMensual = double.Parse(Console.ReadLine());
                salarioAnual = salarioMensual * 12;
                
                //Evaluar el caso segun el salario anual
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

                //evaluar que el caso no sea 0
                if (caso != 0)
                {
                    //Dependiendo del caso realizar la operacion correspondiente
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
                    Console.WriteLine("La retención Mensual será de: " + retencion);
                    Console.WriteLine("Desea procesar otro salario? (s = Si n = No");
                    desicion = Console.ReadLine();
                    //Voler al inicio en caso que el usuario desee realizar varias operaciones
                    if (desicion == "S")
                    {
                        goto inicio;
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                }


            }
            //Manejo de errores
            catch (Exception ex)
            {

                Console.WriteLine("Ha ocurrido un error inesperado: " + ex + " Verifique si el valor insertado es valido");
                //Voler al inicio para que el usuario ingrese el valor adecuado
                goto inicio;
            }
        }
    }
}
