using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IArchivo<T> where T: class
    {
        #region Enumerados
        /// <summary>
        /// Enumerados de tipo de archivo
        /// </summary>
        public enum ETipoDeArchivo
        {
            JSON,
            XML
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Guarda un archivo
        /// </summary>
        /// <param name="path">ruta del archivo</param>
        /// <param name="dato">dato que se guardara</param>
        void GuardarArchivo(string path, T dato);

        /// <summary>
        /// Lee un archivo
        /// </summary>
        /// <param name="path"></param>
        /// <returns>retorna informacion recuperada</returns>
        T LeerArchivo(string path);
        #endregion

    }
}
