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
    /// <summary>
    /// Contrato que expone la firma de los métodos al DomainServices.
    /// </summary>
    public interface IDomainServices
    {
        /// <summary>   
        /// Metodo que permite obtener los numeros faltantes
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="brr"></param>
        /// <returns></returns>
        int[] missingNumbers(int[] arr, int[] brr);
    }
}
