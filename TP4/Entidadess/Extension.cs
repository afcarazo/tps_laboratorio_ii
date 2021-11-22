using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Extension
    {
        /// <summary>
        /// Genera una lista de los montos de los seguros actuales
        /// </summary>
        /// <param name="aseguradora">aseguradora de donde obtendra los valores de los seguros</param>
        /// <param name="total">total acumulado</param>
        /// <returns>devuelve un string con la lista del los montos actuales y el total acumulado</returns>
        public static string MontoTotalExt(this Aseguradora aseguradora, out double total)
        {
            double acumulador = 0;
            StringBuilder sb = new StringBuilder();
            foreach (Asegurado item in aseguradora.Asegurados)
            {
                sb.AppendLine(item.Seguro.MontoTotal.ToString());
                acumulador += item.Seguro.MontoTotal;
            }
            total = acumulador;
            return sb.ToString();
        }
    }
}
