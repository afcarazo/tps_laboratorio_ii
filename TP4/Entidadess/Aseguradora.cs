using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void TotalAcumuladoDelegado(Aseguradora aseguradora);

    public class Aseguradora
    {
        #region Atributos
        private List<Asegurado> asegurados;
        #endregion


        #region Evento
        public event TotalAcumuladoDelegado TotalAcumulado;
        #endregion Evento


        #region Constructores
        /// <summary>
        /// Constructor Aseguradora
        /// </summary>
        public Aseguradora()
        {
            this.asegurados = new List<Asegurado>();
        }
        #endregion

        #region Propiedades

        /// <summary>
        /// Propiedad Asegurados, retorna y asigna lista de asegurados
        /// </summary>
        public List<Asegurado> Asegurados
        {
            get 
            {
                return this.asegurados; 
            }
            set 
            {
                this.asegurados = value;
                this.TotalAcumulado(this);
            }

        }
        #endregion

        #region Métodos
        /// <summary>
        /// Lista todos los asegurados 
        /// </summary>
        /// <returns>retorna string con todos los asegurados existentes</returns>
        protected string Listar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Listado de asegurados: ");
            foreach (Asegurado item in this.Asegurados)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
  
        /// <summary>
        /// Lista todos los asegurados que contiene aseguradora
        /// </summary>
        /// <returns>retorna string con todos los asegurados</returns>
        public override string ToString()
        {
            return this.Listar();
        }
        #endregion

        #region Sobrecarga de operadores
        /// <summary>
        /// Compara todos los asegurados con el asegurado recibido por parametro para comprobar que este en la aseguradora
        /// </summary>
        /// <param name="a">aseguradora</param>
        /// <param name="b">asegurado a comparar</param>
        /// <returns>retorna true si el asegurado esta contenido en la aseguradora,caso contrario false</returns>
        public static bool operator ==(Aseguradora a, Asegurado b)
        {
            bool retorno = false;
            foreach (Asegurado item in a.Asegurados)
            {
                if (item == b)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        /// <summary>
        /// Compara todos los asegurados con el asegurado recibido por parametro para comprobar que no este en la aseguradora
        /// </summary>
        /// <param name="a">aseguradora</param>
        /// <param name="b">asegurado a comparar</param>
        /// <returns>retorna false si el asegurado esta contenido en la aseguradora,caso contrario true</returns>
        public static bool operator !=(Aseguradora a, Asegurado b)
        {
            return !(a==b);
        }
        /// <summary>
        /// Agrega un asegurado en la aseguradora
        /// </summary>
        /// <param name="a">aseguradora en donde se agregara el asegurado</param>
        /// <param name="b">asegurado que se agregara en la aseguradora</param>
        /// <returns>si pudo agregar el asegurado(no se encontranba en la lista) retorna true, caso contrario false(el asegurado ya existe)</returns>
        public static Aseguradora operator +(Aseguradora a, Asegurado b)
        {
            if (a!=b)
            {
                a.Asegurados.Add(b);
                a.TotalAcumulado(a);
            }
    
            return a;
        } 
        /// <summary>
        /// Elimina un asegurado de la aseguradora
        /// </summary>
        /// <param name="a">aseguradora de la cual se eliminara el asegurado</param>
        /// <param name="b">asegurado a eliminar de la aseguradora</param>
        /// <returns>retorna true si pudo eliminar el asegurado(estaba en la lista), false caso contrari(no existe)</returns>
        public static Aseguradora operator -(Aseguradora a, Asegurado b)
        {
            if (a==b)
            {
                a.Asegurados.Remove(b);
            }
    
            return a;
        }
     #endregion

    }
}
