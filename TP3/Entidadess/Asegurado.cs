using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace Entidades
{
    public class Asegurado
    {
        #region Atributos
        protected int dni;
        protected EGenero genero;
        protected string nombre;
        protected string apellido;
        protected string email;
        protected ELocalidad localidad;
        protected Vehiculo vehiculo;
        protected Seguro seguro;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor Asegurado parametrizado
        /// </summary>
        /// <param name="nombre">nombre que se asignara en asegurado</param>
        /// <param name="apellido">apellido que se asignara en asegurado</param>
        /// <param name="localidad">localidad que se asignara en asegurado</param>
        /// <param name="email">email que se asignara en asegurado</param>
        /// <param name="dni">dni que se asignara en asegurado</param>
        /// <param name="genero">genero que se asignara en asegurado</param>
        /// <param name="vehiculo">vehiculo que se asignara en asegurado</param>
        /// <param name="seguro">seguro que se asignara en asegurado</param>
        public Asegurado(string nombre, string apellido, ELocalidad localidad, string email, int dni, EGenero genero, Vehiculo vehiculo, Seguro seguro) : this(nombre, apellido, localidad, email, dni, genero, vehiculo)
        {
            this.Seguro = seguro;
        }
        /// <summary>
        /// Constructor parametrizado Asegurado
        /// </summary>
        /// <param name="nombre">nombre que se asignara en asegurado</param>
        /// <param name="apellido">apellido que se asignara en asegurado</param>
        /// <param name="localidad">localidad que se asignara en asegurado</param>
        /// <param name="email">email que se asignara en asegurado</param>
        /// <param name="dni">dni que se asignara en asegurado</param>
        /// <param name="genero">genero que se asignara en asegurado</param>
        /// <param name="vehiculo">vehiculo que se asignara en asegurado</param>
        public Asegurado(string nombre, string apellido, ELocalidad localidad, string email, int dni, EGenero genero, Vehiculo vehiculo) : this(nombre, apellido, localidad, email, dni, genero)
        {
            this.Vehiculo = vehiculo;
        }
        /// <summary>
        /// Constructor Asegurado parametrizado
        /// </summary>
        /// <param name="nombre">nombre que se asignara en asegurado</param>
        /// <param name="apellido">apellido que se asignara en asegurado</param>
        /// <param name="localidad">localidad que se asignara en asegurado</param>
        /// <param name="email">email que se asignara en asegurado</param>
        /// <param name="dni">dni que se asignara en asegurado</param>
        /// <param name="genero">genero que se asignara en asegurado</param>
        public Asegurado(string nombre, string apellido, ELocalidad localidad, string email, int dni, EGenero genero)
        {
            this.Localidad = localidad;
            this.Email = email;
            this.Dni = dni;
            this.Genero = genero;
            this.Nombre = nombre;
            this.Apellido = apellido;
        }
        /// <summary>
        /// Constructor de asegurado inicializa el campo Localidad en avellaneda y genero femenino por defecto
        /// </summary>
        public Asegurado()
        {
            this.Localidad = ELocalidad.Avellaneda;
            this.genero = EGenero.Femenino;
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad seguro, asigna y retorna atributo seguro
        /// </summary>
        public Seguro Seguro
        {
            get
            {
                return this.seguro;
            }
            set
            {
                this.seguro = value;
            }
        }

        /// <summary>
        /// Propiedad vehiculo, asigna y retorna atributo vehiculo
        /// </summary>
        public Vehiculo Vehiculo
        {
            get
            {
                return this.vehiculo;
            }
            set
            {
                this.vehiculo = value;
            }
        }

        /// <summary>
        /// Propiedad localidad, asigna y retorna atributo localidad
        /// </summary>
        public ELocalidad Localidad
        {
            get
            {
                return this.localidad;
            }
            set
            {
                this.localidad = value;
            }
        }
        /// <summary>
        /// Propiedad email, asigna y retorna atributo localidad
        /// </summary>
        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (Asegurado.EsEmailValido(value))
                {
                    this.email = value;
                }
            }
        }

        /// <summary>
        /// Propiedad apellido, asigna y retorna atributo apellido
        /// </summary>
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length < 21)
                {
                    this.apellido = value;
                }
            }
        }

        /// <summary>
        ///  Propiedad genero, asigna y retorna atributo genero
        /// </summary>
        public EGenero Genero
        {
            get
            {
                return this.genero;
            }
            set
            {
                this.genero = value;
            }
        }
        /// <summary>
        ///   Propiedad dni, asigna y retorna atributo dni
        /// </summary>
        public int Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                if (value > 10000000 && value < 90000000)
                {
                    this.dni = value;
                }
            }
        }

        /// <summary>
        ///   Propiedad nombre, asigna y retorna atributo nombre
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length < 21)
                {
                    this.nombre = value;
                }
            }
        }
        #endregion

        #region Sobrecarga Operadores
        /// <summary>
        /// Dos asegurados son iguales si comparten mismo dni e email
        /// </summary>
        /// <param name="asegurado">primer asegurado a comparar</param>
        /// <param name="aseguradoDos">segundo asegurado a comparar</param>
        /// <returns>retorna true si se trata del mismo asegurado, caso contrario false</returns>
        public static bool operator ==(Asegurado asegurado, Asegurado aseguradoDos)
        {
            bool retorno = false;
            if (asegurado.Dni==aseguradoDos.Dni && asegurado.Email == aseguradoDos.Email)
            {
                retorno = true;
            }
            return retorno;
        }
        /// <summary>
        /// Dos asegurados no son iguales si no poseen el mismo dni e email
        /// </summary>
        /// <param name="asegurado">primer asegurado a comparar</param>
        /// <param name="aseguradoDos">segundo asegurado a comparar</param>
        /// <returns>retorna true si se trata de distintos asegurados, caso contrario true</returns>
        public static bool operator !=(Asegurado asegurado, Asegurado aseguradoDos)
        {
            return !(asegurado==aseguradoDos);
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Dos asegurados son iguales si comparen mismo email y dni
        /// </summary>
        /// <param name="obj">objeto a comparar con la instancia Asegurado</param>
        /// <returns>retorna true si se trata del mismo asegurado, caso contario false</returns>
        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Asegurado)
            {
                retorno = (Asegurado)obj == this;
            }
            return retorno;
        }
        /// <summary>
        /// Muestratodos los datos del asegurado
        /// </summary>
        /// <returns>retorna string con los datos</returns>
        protected string  Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.Nombre}");
            sb.AppendLine($"Apellido: {this.Apellido}");
            sb.AppendLine($"Localidad: {this.Localidad}");
            sb.AppendLine($"Email: {this.Email}");
            sb.AppendLine($"Genero: {this.Genero}");
            sb.AppendLine($"Seguro: {this.seguro}");
            sb.Append($"Vehiculo: {this.vehiculo}");
            return sb.ToString();
        }
        /// <summary>
        ///Muestra todos los datos del asegurado
        /// </summary>
        /// <returns>retorna string con los datos del asegurado</returns>
        public override string ToString()
        {
            return this.Mostrar();
        }

        /// <summary>
        /// Verifica si es un email valido
        /// </summary>
        /// <param name="email">email que sera evaluado</param>
        /// <returns>retorna true caso contrario false</returns>
        public static bool EsEmailValido(string email)
        {
            bool retorno = false;
            if (!string.IsNullOrWhiteSpace(email))
            {
                try
                {
                    MailAddress a = new MailAddress(email);
                    retorno = a.Address == email;
                }
                catch
                {
                    retorno = false;
                }
            }
            return retorno;
        }
        #endregion
    }
}
