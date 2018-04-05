//####################################################################
// APLICACIÓN:    NumerosFaltantes
// AUTOR:         Humberto Rico Machado
// DESCRIPCIÓN:   Arquitectura inicial aplicación  
// FECHA:         04/03/2018
//####################################################################
namespace NumerosFaltantes.Core.DomainServices
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using NumerosFaltantes.DT.Entities;

    public class DomainServices : IDomainServices
    {
        #region Metodos Publicos
        /// <summary>
        /// Metodo que permite obtener los numeros faltantes
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="brr"></param>
        /// <returns></returns>
        public int[] missingNumbers(int[] arr, int[] brr)
        {
            // Objeto del tipo entidad vectores
            Vectores _vectores = new Vectores();
            _vectores.numeroFaltante = string.Empty;
            arr.ToList().ForEach(x =>
            {
                if (!_vectores.numeroFaltante.Contains(x.ToString()))
                {
                    if ((arr.Where(y => y == x).Count()) != (brr.Where(t => t == x).Count()))
                    {
                        _vectores.numeroFaltante = string.IsNullOrEmpty(_vectores.numeroFaltante) ? x.ToString() : _vectores.numeroFaltante + " " + x.ToString();
                    }
                }
            });
            string[] rpt_Temp = _vectores.numeroFaltante.Split(' ');
            return Array.ConvertAll(rpt_Temp, Int32.Parse);
        }
        #endregion

    }
}
