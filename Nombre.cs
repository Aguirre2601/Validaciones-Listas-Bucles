
using System;

namespace Validaciones_Listas_Bucles
{
    public class Nombre
    {
        public static void Validar(int f)
        {
            while (!Varios.flag2)
            {
                Console.Write("\nIngrese el Nombre, luego presione ENTER \n");
                Varios.conti = Convert.ToString(Console.ReadLine());
                if (Varios.conti.Contains("0") || Varios.conti.Contains("1") || Varios.conti.Contains("2") || Varios.conti.Contains("3") || Varios.conti.Contains("4") || Varios.conti.Contains("5") || Varios.conti.Contains("6") || Varios.conti.Contains("7") || Varios.conti.Contains("8") || Varios.conti.Contains("9"))
                {
                    Console.WriteLine("\t\t\tERROR\nLOS DIGITOS INGRESADOS NO SON CORRECTOS, recuerde tildar SOLO LETRAS\n");
                    Varios.flag2 = false;
                }
                else
                {
                    if ((Varios.conti.Length) < 4)
                    {
                        Console.WriteLine("\t\t\tERROR\nLOS DIGITOS INGRESADOS NO SON CORRECTOS\n");
                        Console.WriteLine("POR FAVOR INGRESE UN NOMBRE CON MAS DE 4 LETRAS");
                        Varios.flag2 = false;
                    }
                    else
                    { Varios.Matriz[f, 2] = Varios.conti; Varios.flag2 = true; }
                }
            }
        }
    }
}