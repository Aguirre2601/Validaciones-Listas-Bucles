
using System;

namespace Validaciones_Listas_Bucles
{
    public class Edad
    {
        public static void Validar(int f)
        {
            while (!Varios.flag)
            {
                Console.Write("Ingrese la Edad, luego presione ENTER \n");
                Varios.flag = int.TryParse(Console.ReadLine(), out Varios.nro);
                if (!Varios.flag)
                {
                    Console.WriteLine("\t\t\tERROR\nEl digito ingresado no es un NUMERO, recuerde tildar SOLO NUMEROS\n");
                }
                else
                {
                    if (Varios.nro < 10)
                    {
                        Varios.var_menor10 = Convert.ToString(Varios.nro);
                        Varios.Matriz[f, 0] = ("0" + Varios.var_menor10);
                        Varios.flag = true;
                    }
                    else { Varios.Matriz[f, 0] = Convert.ToString(Varios.nro); Varios.flag = true; }
                }
            }
        }
    }
}