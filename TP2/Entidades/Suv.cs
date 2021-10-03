using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Suv : Vehiculo
    {
        /// <summary>
        /// Constructor publico que inicializa los atributos marca, chasis, color de SUV
        /// </summary>
        /// <param name="marca">marca que asignara al suv</param>
        /// <param name="chasis">chasis que asignara al suv</param>
        /// <param name="color">color que asignara al suv</param>
        public Suv(EMarca marca, string chasis, ConsoleColor color)
            : base(chasis, marca, color)
        {
        }
        /// <summary>
        /// SUV son 'Grande'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get { return ETamanio.Grande; }
        }

        /// <summary>
        /// Metodo que muestra la informacion de Suv
        /// </summary>
        /// <returns>retorna string con informacion de Suv</returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SUV");
            sb.AppendLine(base.Mostrar());
            sb.Append("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
