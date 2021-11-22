using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Entidades
{

    public class AccederDatos
    {
        #region Atributos

        private static string cadena_conexion;
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        #endregion

        #region Constructores
        /// <summary>
        /// Constructor establece los datos de la conexion
        /// </summary>
        static AccederDatos()
        {
            AccederDatos.cadena_conexion = @"Server=localhost;Database=Asegurados_DB;Trusted_Connection=True;";
        }
        /// <summary>
        /// Constructor establece conexion
        /// </summary>
        public AccederDatos()
        {
            this.conexion = new SqlConnection(AccederDatos.cadena_conexion);
        }

        #endregion

        #region Métodos

        #region Probar conexión
        /// <summary>
        /// Se encarga de testear la conexion
        /// </summary>
        /// <returns>retorna false si ocurrio algun problema, de lo contrario retorna false</returns>
        public bool ProbarConexion()
        {
            bool rta = true;

            try
            {
                this.conexion.Open();
            }
            catch (Exception e)
            {
                rta = false;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return rta;
        }

        #endregion

        #region Select
        /// <summary>
        /// obtiene una lista de asegurados de la base de datos
        /// </summary>
        /// <returns> retorna lista de asegurados recuperada de la base de datos</returns>
        public List<Asegurado> ObtenerListaAsegurado()
        {
            List<Asegurado> lista = new List<Asegurado>();

            try
            {
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = "SELECT * FROM asegurados";
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                this.lector = comando.ExecuteReader();
       
                while (lector.Read())
                {
                    double dni = double.Parse(lector["Dni"].ToString());
                    bool existeAsegurado = lista.Exists((x) => x.Dni == dni);

                    if (!existeAsegurado)
                    {
                        Asegurado item = new Asegurado();

                        item.Dni = int.Parse(lector["Dni"].ToString());
                        item.Genero = (EGenero)Enum.Parse(typeof(EGenero), lector["Genero"].ToString());
                        item.Nombre = lector["Nombre"].ToString();
                        item.Apellido = lector["Apellido"].ToString();
                        item.Email = lector["Email"].ToString();
                        item.Localidad = (ELocalidad)Enum.Parse(typeof(ELocalidad), lector["IdLocalidad"].ToString());

                        item.Vehiculo = new Vehiculo();
   
                        item.Vehiculo.TipoVehiculo = (ETipoVehiculo)Enum.Parse(typeof(ETipoVehiculo), lector["IdTipoVehiculo"].ToString());

                        if (item.Vehiculo.TipoVehiculo == ETipoVehiculo.Camioneta || item.Vehiculo.TipoVehiculo == ETipoVehiculo.Auto)
                        {
                            item.Vehiculo.Marca = (EMarca)Enum.Parse(typeof(EMarca), lector["IdMarcaVehiculo"].ToString());
                        }
                        else
                        {
                            Moto moto = new Moto();
                  
                            moto.MarcaMoto = (EMarcaMoto)Enum.Parse(typeof(EMarcaMoto), lector["IdMarcaMoto"].ToString());
                            moto.Cilindrada = int.Parse(lector["Cilindrada"].ToString());
                            moto.TipoVehiculo = ETipoVehiculo.Moto;
                            item.Vehiculo = moto;
                        }

                        item.Vehiculo.Anio = int.Parse(lector["AnioVehiculo"].ToString());
                        item.Vehiculo.Modelo = lector["ModeloVehiculo"].ToString();
                        item.Vehiculo.Patente = lector["PatenteVehiculo"].ToString();
                               
                        item.Seguro = new Seguro();
                        item.Seguro.PlanDePago = (EPlanDePago)Enum.Parse(typeof(EPlanDePago), lector["IdPlanDePago"].ToString());
                        item.Seguro.MontoTotal = double.Parse(lector["MontoTotal"].ToString());
                        item.Seguro.TipoDeSeguro = (ETipoSeguro)Enum.Parse(typeof(ETipoSeguro), lector["IdTipoSeguro"].ToString());
                        lista.Add(item);

                    }

                 
                }

                lector.Close();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return lista;
        }

        #endregion

        #region Insert

        /// <summary>
        /// Agrega un asegurado a la tabla de la base de datos
        /// </summary>
        /// <param name="param"></param>
        /// <returns>retorna true si pudo agregar el asegurado, de lo contrario false</returns>
        public bool AgregarDato(Asegurado param)
        {
            bool rta = true;

            try
            {

                
                string sql = "INSERT INTO asegurados (Dni, Genero, Nombre, Apellido, Email, IdLocalidad," +
                                                     "AnioVehiculo,ModeloVehiculo,PatenteVehiculo,IdTipoVehiculo,IdPlanDePago," +
                                                     "MontoTotal,IdTipoSeguro,IdMarcaMoto,Cilindrada,IdMarcaVehiculo) VALUES(";


                sql = sql + param.Dni.ToString() + "," + ((int)param.Genero).ToString() + "," + "'" + param.Nombre + "'," + "'" + param.Apellido + "',"
                      + "'" + param.Email + "'," + ((int)param.Localidad).ToString()  + ","
                      + param.Vehiculo.Anio.ToString() + "," + "'" + param.Vehiculo.Modelo + "'" + ",'" + param.Vehiculo.Patente.ToString() + "',"
                      + ((int)param.Vehiculo.TipoVehiculo).ToString() + "," + ((int)param.Seguro.PlanDePago).ToString() + ","
                      + param.Seguro.MontoTotal.ToString() + "," + ((int)param.Seguro.TipoDeSeguro).ToString();

                if (param.Vehiculo.TipoVehiculo == ETipoVehiculo.Moto)
                {

                    sql = sql +  "," + ((int)((Moto)param.Vehiculo).MarcaMoto).ToString() + "," + ((int)((Moto)param.Vehiculo).Cilindrada).ToString() +"," + "NULL" + ")";

                }
                else
                {
                    sql = sql  +"," + "NULL" + "," + "NULL"+ ","+((int)param.Vehiculo.Marca).ToString() + ")";
                }



                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return rta;
        }

        #endregion

        #endregion
    }
}
