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
