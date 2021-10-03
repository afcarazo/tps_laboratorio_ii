using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciclomotor : Vehiculo
    {
        /// <summary>
        /// Constructor publico que inicializa marca,chasis,color del Ciclomotor.
        /// </summary>
        /// <param name="marca">marca que se asignara en el ciclomotor</param>
        /// <param name="chasis">chasis que se asignara en el ciclomotor</param>
        /// <param name="color">color que se asignara en el ciclomotor</param>
        public Ciclomotor(EMarca marca, string chasis, ConsoleColor color):base(chasis,marca,color)
        {
        }
        /// <summary>
        /// Ciclomotor son 'Chico'
        /// </summary>
        protected override ETamanio Tamanio 
        {
            get{ return ETamanio.Chico; }
        }
       /// <summary>
       /// Muestra la informacion del ciclomotor
       /// </summary>
       /// <returns>retorna un string con la informacion del Ciclomotor</returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CICLOMOTOR");
            sb.AppendLine(base.Mostrar());
            sb.Append("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
