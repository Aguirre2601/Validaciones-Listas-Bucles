
using System;

namespace Validaciones_Listas_Bucles
{
    public class Apellido
    {
        public static void Validar(int f)
        {
            while (!Varios.flag1)
            {
                Console.Write("Ingrese el Appelido, luego presione ENTER \n");
                Varios.conti = Convert.ToString(Console.ReadLine());
                if (Varios.conti.Contains("0") || Varios.conti.Contains("1") || Varios.conti.Contains("2") || Varios.conti.Contains("3") || Varios.conti.Contains("4") || Varios.conti.Contains("5") || Varios.conti.Contains("6") || Varios.conti.Contains("7") || Varios.conti.Contains("8") || Varios.conti.Contains("9"))
                {
                    Console.WriteLine("\t\t\tERROR\nLOS DIGITOS INGRESADOS NO SON CORRECTOS, recuerde tildar SOLO LETRAS\n");
                    Varios.flag1 = false;
                }
                else { Varios.Matriz[f, 1] = Varios.conti; Varios.flag1 = true; }
            }
        }
    }
}