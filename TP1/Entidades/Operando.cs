using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        private double numero;

        /// <summary>
        /// Propiedad que asigna al campo numero el valor recibido como string 
        /// </summary>
        private string Numero
        {
            set
            {
                this.numero = this.ValidarOperando(value);
            }

        }

        /// <summary>
        /// Convierte de binario a decimal 
        /// </summary>
        /// <param name="binario">string a convertir</param>
        /// <returns>si la conversion pudo realizarse retorna el numero decimal como string, de lo contrario "valor inválido"</returns>
        public string BinarioDecimal(string binario)
        {
            string retorno = "Valor inválido.";
            double valorAbsoluto = Math.Abs(this.ValidarOperando(binario));
            string numeroAbsBinario = valorAbsoluto.ToString();

            if (this.EsBinario(numeroAbsBinario))
            {
                retorno = Convert.ToInt64(numeroAbsBinario, 2).ToString();
            }

            return retorno;
        }

        /// <summary>
        ///Convertira el numero recibido a binario si positivo
        /// </summary>
        /// <param name="numero">double a convertir</param>
        /// <returns>retorna como string el numero binario si la conversion es posible, de lo contrario retorna "Valor inválido."</returns>
        public string DecimalBinario(double numero)
        {
            string retorno = "Valor inválido.";
            long auxNumero = Convert.ToInt64(Math.Abs(numero)); 

            if (numero > 0)
            {
                retorno = Convert.ToString(auxNumero, 2);
            }
            return retorno;
        }
        /// <summary>
        /// Convierte un numero decimal a binario
        /// </summary>
        /// <param name="numero">string a convertir</param>
        /// <returns>Si es posible la conversion devuelve el numero binario como string, de lo contrario retorna que es un valor invalido</returns>
        public string DecimalBinario(string numero)
        {
            string retorno = "valor inválido";
            double auxNumero = this.ValidarOperando(numero);
            if (auxNumero != 0)
            {
                retorno = this.DecimalBinario(auxNumero);
            }
            return retorno;
        }

        /// <summary>
        /// validará que la cadena de caracteres esté compuesta SOLAMENTE por caracteres '0' o '1'
        /// </summary>
        /// <param name="binario">string a evaluar</param>
        /// <returns>retorna true si la cadena esta compuesta por 0 o 1, de lo contrario false</returns>
        private bool EsBinario(string binario)
        {
            bool retorno = true;

            foreach (char item in binario)
            {
                if (item != '0' && item != '1')
                {
                    retorno = false;
                    break;
                }
            }
            return retorno;
        }

        /// <summary>
        /// Constructor que asigna al atributo numero el valor 0
        /// </summary>
        public Operando()
        {
            this.numero = 0;
        }

        /// <summary>
        /// constructor que asigna al atributo numero el tipo de dato double 
        /// </summary>
        /// <param name="numero"></param>
        public Operando(double numero)
        {
            this.numero = numero;
        }
        
        /// <summary>
        /// constructor que asigna al atributo numero el tipo de dato string 
        /// </summary>
        /// <param name="strNumero"></param>
        public Operando(string strNumero) 
        {
            this.Numero = strNumero;
        }

        /// <summary>
        /// Operador que realiza la resta entre dos numeros
        /// </summary>
        /// <param name="n1">Primer operando para realizar la operacion</param>
        /// <param name="n2">Segundo operando para realizar la operacion</param>
        /// <returns>retorna la resta entre ambos numeros</returns>
        public static double operator -(Operando n1, Operando n2)
        {
            double retorno = n1.numero - n2.numero;
            return retorno;
        }

        /// <summary>
        /// Operador que realiza la multiplicacion entre ambos numeros
        /// </summary>
        /// <param name="n1">Primer operando para realizar la operacion</param>
        /// <param name="n2">Segundo operando para realizar la operacion</param>
        /// <returns>retorna la multiplicacion entre ambos numeros</returns>
        public static double operator *(Operando n1, Operando n2)
        {
            double retorno = n1.numero * n2.numero;
            return retorno;
        }

        /// <summary>
        /// Operador que realiza la division entre ambos numeros
        /// </summary>
        /// <param name="n1">Primer operando para realizar la operacion</param>
        /// <param name="n2">Segundo operando para realizar la operacion</param>
        /// <returns>retorna el resultado de la division si el divisor es distinto de cero, caso contrario retorna el valor minimo</returns>
        public static double operator /(Operando n1, Operando n2)
        {
            double retorno = double.MinValue;
            if (n2.numero != 0)
            {
                retorno = n1.numero / n2.numero;
            }
            return retorno;
        }

        /// <summary>
        /// Operador quye realiza la suma entre ambos numeros
        /// </summary>
        /// <param name="n1">Primer operando para realizar la operacion</param>
        /// <param name="n2">Segundo operando para realizar la operacion</param>
        /// <returns>retorna la suma de los numeros</returns>
        public static double operator +(Operando n1, Operando n2)
        {
            double retorno = n1.numero + n2.numero;
            return retorno;
        }

        /// <summary>
        /// comprobará que el valor recibido sea numérico, y lo convertira a formato double.
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns>el numero convertido a double, si es posible, de lo contrario retorna 0.</returns>
        private double ValidarOperando(string strNumero)
        {
            bool coversionExitosa = double.TryParse(strNumero, out double numeroConvertido);
            double retorno = 0;

            if (coversionExitosa)
            {
                retorno = numeroConvertido;
            }

            return retorno;
        }
    }

}
