//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            /*var train = new Train("Chu chu");
            train.StartEngines();
            Console.WriteLine("Hello World!");
            int i = 0;*/
            //Creo 100 instancias de trenes para ver que sucede
            
            /*while(i <100)
            {
                Train trains = new Train("trencin");
                i+=1;
                Console.WriteLine(Train.count);
            }
            */
            /*Creé 10.000.000 instancias de trenes para ver que sucede
            
            while(i <10000000)
            {
                Train trains = new Train("trencin");
                i+=1;
                Console.WriteLine(Train.count);
            }  /*
            //Por lo que veo visual no imprime mas de 31623 entonces luego de este numero va sumando bloques de 31623 hasta llegar a uno que sume en total el gran numero requerido
            //aunque tambien vi una secuencia en la terminal al imprimir el codigo que no entiendo porque sucede despues de 31624
            /*31624
            30247
            27987*/
            // esa secuencia de numeros que decrecen sucede 12 veces entre 31624 hasta el numero 15
            Train t1 = new Train("Last Train To London");
            Train t2 = new Train("Last Train To London");
            Train t3 = new Train("Runaway Train");
            Console.WriteLine(t1==t2);
            Console.WriteLine (t2 == t3);
            //Las dos son falsas y no entiendo porque

        }
    }
}