using System;

namespace Entidades
{
    public class Calculadora
    {
        /// <summary>
        /// validará y realizará la operación suma/resta/multiplicacion/división entre ambos números.
        /// </summary>
        /// <param name="num1">Primer numero para realizar la operacion</param>
        /// <param name="num2">Segundo numero para realizar la operacion</param>
        /// <param name="operador"></param>
        /// <returns>retorna el resultado de la operacion</returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            operador = Calculadora.ValidarOperador(operador);
            double resultado = 0;
            switch (operador)
            {
                case '+':
                    resultado = num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
                case '/':
                    resultado = num1 / num2;
                    break;
                default:
                    resultado = num1 + num2;
                    break;
            }
            return resultado;
        }

        /// <summary>
        /// Valida que el operador recibido sea +, -, / o*
        /// </summary>
        /// <param name="operador">operador que se evaluara</param>
        /// <returns>retorna el operador si se trata de uno correcto, sino retorna +</returns>
        private static char ValidarOperador(char operador)
        {
            char retorno = '+';
            if (operador == '+' || operador == '-' || operador == '/' || operador == '*')
            {
                retorno = operador;
            }
            return retorno;
        }
    }
}
