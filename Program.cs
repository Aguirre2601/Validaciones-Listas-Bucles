using System;
using System.Collections.Generic;

namespace Validaciones_Listas_Bucles
{
    class Program
    {
        public static void Main(string[] args)
        {

            Varios.LISTA = new List<string>();
            Varios.Matriz = new string[5, 3];
            for (int f = 0; f < 5; f++)
            {
                Varios.flag = false;
                Varios.flag1 = false;
                Varios.flag2 = false;
                Nombre.Validar(f);
                Apellido.Validar(f);
                Edad.Validar(f);
                Varios.LISTA.Add(Varios.Matriz[f, 0] + ";" + Varios.Matriz[f, 1] + "," + Varios.Matriz[f, 2]);
            }
            Console.Write("\n\n");
            Varios.LISTA.Sort();
            for (int f = 0; f < 5; f++)
            {
                Console.WriteLine(Varios.LISTA[f].Split(';')[1] + " " + Varios.LISTA[f].Split(';')[0]);
            }
            Console.WriteLine("Presione cualquier tecla para SALIR");
            Console.ReadKey();
        }
    }
}