using System;

// Tarea: Realizar un programa que imprima los años bisiestos que hay entre 1990-2022.

namespace Años_Bisiestos
{
    public class AñoBisiesto//Se crea una clase pública llamada AñoBisiesto
    {

        static void Main(string[] args)//Se inicializa el programa
        {
           Console.ForegroundColor = ConsoleColor.White;//Se le asigna el color blanco a las letras de consola 

            int i;//Se crea una variable de tipo int
            int[] Años = { 1990, 1991, 1992, 1993, 1994, 1995, 1996, 1997, 1998, 1999, 2000, 2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019, 2020, 2021, 2022 };
            //Se crea una variable de tipo int con un array de 32 elementos

            Console.WriteLine("Los años bisiestos entre 1990 y 2022 son:\n");//Se indica el headline que imprimirá en consola

            for (i = Años[0]; i <= Años[32]; i++)//Se crea un ciclo for donde se indica la inicialización, el OL y la actualización
            {
                if (i % 4 == 0 && i % 100 != 0 || i % 400 == 0)//Se crea una condición de para determinar si un año es bisiesto
                {
                    Console.WriteLine("- Año {0} - Es un año bisiesto\n", i);//Se indica lo que se va a imprimir en cosola si es verdadero
                }

                else//Se crea una contracondición
                {
                    Console.WriteLine("- Año {0} - No es un año bisiesto\n", i);//Se indica lo que se va a imprimir en consola si es falso
                }

                Console.ReadLine();//Se emplea el metodo readline para esperar a que se pulse una tecla para hacer una actualización
                
            }

        }

    }

}


        