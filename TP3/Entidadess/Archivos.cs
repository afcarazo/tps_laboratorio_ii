using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Archivos : IArchivo<string>
    {
        #region Métodos
        /// <summary>
        /// Lee un archivo de texto
        /// </summary>
        /// <param name="path">ruta del archivo</param>
        /// <returns>retorna string con la información recuperada</returns>
        public string LeerArchivo(string path)
        {
            Encoding encoding = Encoding.UTF8;
            string retorno = string.Empty;
            try
            {
                using (StreamReader lector = new StreamReader(path, encoding))
                {
                    while (!lector.EndOfStream)
                    {
                        retorno += $"{lector.ReadLine()}\n"; 
                    }
                }
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
            return retorno;
        }

        /// <summary>
        /// Guarda un archivo de texto
        /// </summary>
        /// <param name="path">ruta del archivo</param>
        /// <param name="dato">dato que se guardara</param>
       public void GuardarArchivo(string path, string dato)
        {
            Encoding encoding = Encoding.UTF8;
            try
            {
                using (StreamWriter escritor = new StreamWriter(path, false, encoding))
                {
                    escritor.WriteLine(dato);
                }
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
        }
        #endregion
    }
}
