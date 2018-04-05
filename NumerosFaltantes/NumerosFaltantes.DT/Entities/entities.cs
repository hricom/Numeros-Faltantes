//####################################################################
// APLICACIÓN:    NumerosFaltantes
// AUTOR:         Humberto Rico Machado
// DESCRIPCIÓN:   Arquitectura inicial aplicación  
// FECHA:         04/03/2018
//####################################################################
namespace NumerosFaltantes.DT.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Vectores
    {
        /// <summary>
        /// Tamaño de lista 1
        /// </summary>
        public int n { get; set; }
        /// <summary>
        /// Tamaño de lista 2
        /// </summary>
        public int m { get; set; }
        /// <summary>
        /// Lista 1
        /// </summary>
        public int[] arr { get; set; }
        /// <summary>
        /// Lista 2 
        /// </summary>
        public int[] brr { get; set; }
        /// <summary>
        /// Lista resultado
        /// </summary>
        public int[] result { get; set; }
        /// <summary>
        /// Contenedor de los numeros faltantes
        /// </summary>
        public string numeroFaltante { get; set; }
    }
}
