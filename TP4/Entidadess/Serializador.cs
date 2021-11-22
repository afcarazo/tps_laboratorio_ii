using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Xml;
using System.IO;
using System.Xml.Serialization;
using System.Text.Json.Serialization;

namespace Entidades
{
    public class Serializador<T> : IArchivo<T> where T : class
    {
        #region Atributos
        private IArchivo<T>.ETipoDeArchivo tipoDeArchivo;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructos Serializacdor
        /// </summary>
        /// <param name="tipoDeArchivo">tipo de archivo a asigar a serializador</param>
        public Serializador(IArchivo<T>.ETipoDeArchivo tipoDeArchivo)
        {
            this.tipoDeArchivo = tipoDeArchivo;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Guarda un archivo
        /// </summary>
        /// <param name="path">ruta del archivo</param>
        /// <param name="dato">dato a guardar</param>
        public void GuardarArchivo(string path, T dato)
        {
            Encoding encoding = Encoding.UTF8;
            try
            {
                try
                {
                    if (this.tipoDeArchivo == IArchivo<T>.ETipoDeArchivo.XML)
                    {
                        if (Path.GetExtension(path) == ".xml")
                        {
                            using (XmlTextWriter archivo = new XmlTextWriter(path, encoding))
                            {
                                archivo.Formatting = Formatting.Indented;
                                XmlSerializer escritor = new XmlSerializer(typeof(T));
                                escritor.Serialize(archivo, dato);
                            }
                        }
                    }

                }
                catch (Exception e)
                {
                    throw new SerializarException("Extensión no válida para XML", "Serializador", "Guardar archivo", e);
                }


                try
                {
                    if (this.tipoDeArchivo == IArchivo<T>.ETipoDeArchivo.JSON)
                    {
                        if (Path.GetExtension(path) == ".json")
                        {
                            JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions { Converters = { new JsonStringEnumConverter() } };
                            jsonSerializerOptions.WriteIndented = true;
                            Archivos archivoTexto = new Archivos();
                            archivoTexto.GuardarArchivo(path, JsonSerializer.Serialize(dato, typeof(T), jsonSerializerOptions));
                        }

                    }
                }
                catch (Exception e)
                {
                    throw new SerializarException("Extensión no válida para JSON", "Serializador", "Guardar archivo", e);
                }
            }
            catch (Exception ex)
            {
                throw new SerializarException("FALLO en la escritura", "Serializador", "Guardar archivo", ex);
            }

            }
        /// <summary>
        /// Lee un archivo
        /// </summary>
        /// <param name="path">ruta del archivo</param>
        /// <returns>retorna la información recuperada</returns>
        public T LeerArchivo(string path)
        {
            try
            {
                if (this.tipoDeArchivo == IArchivo<T>.ETipoDeArchivo.XML)
                {
                    if (Path.GetExtension(path) == ".xml")
                    {
                        using (XmlTextReader archivo = new XmlTextReader(path))
                        {
                            XmlSerializer escritor = new XmlSerializer(typeof(T));
                            return (T)escritor.Deserialize(archivo);
                        }
                    }
                    else
                    {
                        throw new SerializarException("Extensión inválida para XML","Serializador","Leer archivo");
                    }
                }
                else
                {
                    if (Path.GetExtension(path) == ".json")
                    {
                        Archivos archivo = new Archivos();
                        JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions { Converters = { new JsonStringEnumConverter(JsonNamingPolicy.CamelCase) } };
                        jsonSerializerOptions.WriteIndented = true;
                        return JsonSerializer.Deserialize<T>(archivo.LeerArchivo(path),jsonSerializerOptions);
                    }
                    else
                    {
                        throw new SerializarException("Extensión inválida para JSON", "Serializador","Leer archivo");
                    }
                    
                }
               
            }
            catch (Exception e)
            {
                throw new SerializarException("FALLO en la lectura","Serializador","Leer archivo",e);
            }
        }

        #endregion
    }
}
