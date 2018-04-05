//####################################################################
// APLICACIÓN:    NumerosFaltantes
// AUTOR:         Humberto Rico Machado
// DESCRIPCIÓN:   Arquitectura inicial aplicación  
// FECHA:         04/03/2018
//####################################################################
namespace NumerosFaltantes.Console
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;  
    using NumerosFaltantes.Core.DomainServices;
    using NumerosFaltantes.DT.Entities;

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese N");
            // Objeto del tipo entidad vectores
            Vectores _vectores = new Vectores();

            //_vectores.n = 10;  //Datos para prueba
            _vectores.n = Convert.ToInt32(Console.ReadLine()); // Esta variable es para dimensionar el array, pero en esta práctica no se usa.

            Console.WriteLine("Ingrese ARR");
            //string[] arr_temp = { "203", "205", "206", "207", "208", "203", "204", "205", "206", "204" }; // Datos para prueba
            string[] arr_temp = Console.ReadLine().Split(' ');
            _vectores.arr = Array.ConvertAll(arr_temp, Int32.Parse);
            Console.WriteLine("Ingrese M");
            //_vectores.m = 13; //Datos para prueba
            _vectores.m = Convert.ToInt32(Console.ReadLine()); // Esta variable es para dimensionar el array, pero en esta práctica no se usa.

            Console.WriteLine("Ingrese BRR");
            //string[] brr_temp = { "203", "204", "204", "205", "206", "207", "205", "208", "203", "206", "205", "206", "204" };// Datos para prueba
            string[] brr_temp = Console.ReadLine().Split(' ');
            _vectores.brr = Array.ConvertAll(brr_temp, Int32.Parse);

            _vectores.result = (from t in new DomainServices().missingNumbers(_vectores.arr, _vectores.brr)
                                orderby t
                                select t).ToArray();
            Console.WriteLine("Respuesta" + ":" + String.Join(" ", _vectores.result));
            Console.ReadLine();
        }
    }
}
