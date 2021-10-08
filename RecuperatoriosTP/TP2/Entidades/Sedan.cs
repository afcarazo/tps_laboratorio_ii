using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    public class Sedan : Vehiculo
    {
        private ETipo tipo;

        /// <summary>
        /// enumerador de tipos de Sedan
        /// </summary>
        public enum ETipo { CuatroPuertas, CincoPuertas }

        /// <summary>
        /// Constructor publico que inicializa los atributos de marca, chasis, color y tipo (por defecto seran cuatro puertas) de Sedan
        /// </summary>
        /// <param name="marca">marca que se asignara en Sedan</param>
        /// <param name="chasis">chasis que se asignara en Sedan</param>
        /// <param name="color">color que se asignara en Sedan</param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color) 
            : this(marca, chasis, color,ETipo.CuatroPuertas)
        {
        }

        /// <summary>
        /// Constructor publico que inicializa los atributos de marca, chasis, color y tipo de Sedan
        /// </summary>
        /// <param name="marca">marca que se asignara en Sedan</param>
        /// <param name="chasis">chasis que se asignara en Sedan</param>
        /// <param name="color">color que se asignara en Sedan</param>
        /// <param name="tipo">tipo que se asignara en Sedan</param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color,ETipo tipo) 
            : base(chasis,marca, color)
        {
            this.tipo = tipo;
        }

        /// <summary>
        /// Sedan son 'Mediano'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get { return ETamanio.Mediano; }
        }
        /// <summary>
        /// Muestra toda la informacion de Sedan.
        /// </summary>
        /// <returns>Retorna string con la informacion de Sedan</returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SEDAN");
            sb.Append(base.Mostrar());
            sb.Append($"TIPO : {this.tipo}\n");
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
