using System;
using System.Text;
using System.Collections.Generic;
using Entidades;
using System.IO;

namespace TestEntidades
{
    class Program
    {
        static void Main(string[] args)
        {

            Aseguradora aseguradora = new Aseguradora();
            Asegurado aseguradoUno = new Asegurado("Tomas", "Gallardo", ELocalidad.Berazategui, "tomasgallardo@gmail.com", 40585871, EGenero.Masculino, new Auto(EMarca.Renault, 2019, "AFDE92", "Renault c320 Privilege 6x4 construction"), new Seguro(EPlanDePago.Debito, ETipoSeguro.ResponsabilidadCivil, 3500));
            Asegurado aseguradoDos = new Asegurado("Irina", "Ruz", ELocalidad.Glew, "irina@gmail.com", 30585871, EGenero.Femenino, new Auto(EMarca.Peugeot, 2017, "ASDE22", "Peugeot 2008 1.6 Active"), new Seguro(EPlanDePago.Efectivo, ETipoSeguro.ResponsabilidadCivil, 3100));
            Asegurado aseguradoTres = new Asegurado("Laila", "Campo", ELocalidad.Wilde, "lailaC@gmail.com", 19585871, EGenero.Femenino, new Camioneta(EMarca.Honda, 2021, "FEWE22", "Honda cr-v 2021"), new Seguro(EPlanDePago.Efectivo, ETipoSeguro.TercerosCompleto, 12100));
            Asegurado aseguradoCuatro = new Asegurado("Victor", "Ocampo", ELocalidad.Lanus, "vicOcampo@gmail.com", 29585871, EGenero.Masculino, new Moto(EMarcaMoto.Yamaha, 2021, "REWE62", 150, "Yamaha Xtz"), new Seguro(EPlanDePago.Debito, ETipoSeguro.ResponsabilidadCivil, 2000));
            Asegurado aseguradoCinco = new Asegurado("Andy", "Rivas", ELocalidad.Quilmes, "andy0584@gmail.com", 43585871, EGenero.NoBinario, new Auto(EMarca.Toyota, 2017, "AERE22", "Toyota camry 2.5 aut l/2012"), new Seguro(EPlanDePago.Efectivo, ETipoSeguro.TercerosCompleto, 6000));
            Asegurado aseguradoSeis = new Asegurado("Jess", "Ocampo", ELocalidad.LomasDeZamora, "jessOcampo@gmail.com", 42585871, EGenero.NoBinario, new Auto(EMarca.Volkswagen, 2020, "ASDE22", "VW 10.150 E 39"), new Seguro(EPlanDePago.Debito, ETipoSeguro.ResponsabilidadCivil, 6100));
            Asegurado aseguradoSiete = new Asegurado("Antonia", "Fernandez", ELocalidad.Quilmes, "AntoniaF@gmail.com", 44585871, EGenero.Femenino, new Auto(EMarca.Renault, 2019, "RFDE92", "Renault c320 privilege p 6x4 construction"), new Seguro(EPlanDePago.Debito, ETipoSeguro.ResponsabilidadCivil, 3700));
            aseguradora += aseguradoUno;
            aseguradora += aseguradoDos;
            aseguradora += aseguradoTres;
            aseguradora += aseguradoCuatro;
            aseguradora += aseguradoCinco;
            aseguradora += aseguradoSeis;
            aseguradora += aseguradoSiete;
            Console.WriteLine(aseguradora.ToString());
            aseguradora -= aseguradoUno;
            aseguradora -= aseguradoDos;
            Console.WriteLine(aseguradora.ToString());

            Seguro seguro = new Seguro();
            double monto = seguro.GenerarSeguroResponsabilidadCivil(aseguradoDos);
            Console.WriteLine($"Monto uno : {monto}");
            double montoDos = seguro.GenerarSeguroResponsabilidadCivil(aseguradoTres);
            Console.WriteLine($"Monto uno : {montoDos}");
            
            //ARCHIVOS .TXT
            //prueba con listado de asegurados
            Console.WriteLine("Archivo: ");
            Archivos archivoTexto = new Archivos();
            archivoTexto.GuardarArchivo("AseguradosConsola.txt", aseguradora.ToString()) ;
            Console.WriteLine(archivoTexto.LeerArchivo("AseguradosConsola.txt"));

        
            
            //Prueba de serializacion y deserializacion con un asegurado .json y xml

            Asegurado asegurado = new Asegurado("Ernesto", "Gomez", ELocalidad.Avellaneda, "ernestogomez@gmail.com", 43405871, EGenero.Masculino, new Auto(EMarca.Chevrolet, 2002, "ASDE22", "Chevrolet Agile 1.4 LS/L14"), new Seguro(EPlanDePago.Debito, ETipoSeguro.ResponsabilidadCivil,3300));
            Serializador<Asegurado> serializarXML = new Serializador<Asegurado>(IArchivo<Asegurado>.ETipoDeArchivo.XML);
            Serializador<Asegurado> serializarJson = new Serializador<Asegurado>(IArchivo<Asegurado>.ETipoDeArchivo.JSON);
            try
            {
                serializarXML.GuardarArchivo("asegurado.xml",asegurado);
                Asegurado asegurado2 = serializarXML.LeerArchivo("asegurado.xml");
                Console.WriteLine("xml");
                Console.WriteLine(asegurado2.ToString());
            }
            catch(Exception e) 
            {
                Console.WriteLine(e.Message);
            }  

            try
            {
              serializarJson.GuardarArchivo("aseguradoTres.json",asegurado);
              Asegurado asegurado3 = serializarJson.LeerArchivo("aseguradoTres.json");
                Console.WriteLine("json");
                Console.WriteLine(asegurado3.ToString());
            }
            catch (SerializarException ex)
            {
                Console.WriteLine($"{ex.Message},\n En la clase:{ex.Clase}, \n En el método: {ex.Metodo}\n {ex.InnerException.Message} ");
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }

            //serializacion y deserializacion listado
            try
            {

                //serialización a xml
                string ruta1 = @"..\..\..\..\AseguradosConsola";
                Serializador<List<Asegurado>> serializador = new Serializador<List<Asegurado>>(IArchivo<List<Asegurado>>.ETipoDeArchivo.XML);
                if (!Directory.Exists(ruta1))
                {
                    Directory.CreateDirectory(ruta1);
                }
                else
                {
                    Directory.Delete(ruta1, true);
                    Directory.CreateDirectory(ruta1);
                }
                serializador.GuardarArchivo($"{ruta1}\\aseguradosConsola.xml", aseguradora.Asegurados);

                //deserializar
                List<Asegurado> aseguradosXml = new List<Asegurado>(serializador.LeerArchivo($"{ruta1}\\asegurados.xml"));

                Console.WriteLine("Listado xml");
                foreach (Asegurado item in aseguradosXml)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            catch (SerializarException ex)
            {
                Console.WriteLine($"{ex.Message},\n En la clase:{ex.Clase}, \n En el método: {ex.Metodo}\n {ex.InnerException.Message} ");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.InnerException.Message);
            }


            //json
            try
            {
                string ruta2 = @"..\..\..\..\AseguradosJson";
                Serializador<List<Asegurado>> serilizarJson = new Serializador<List<Asegurado>>(IArchivo<List<Asegurado>>.ETipoDeArchivo.JSON);

                if (!Directory.Exists(ruta2))
                {
                    Directory.CreateDirectory(ruta2);
                }
                else
                {
                    Directory.Delete(ruta2, true);
                    Directory.CreateDirectory(ruta2);
                }
                serilizarJson.GuardarArchivo($"{ruta2}\\asegurados.json", aseguradora.Asegurados);

                //deserializar
                List<Asegurado> asegurados3 = new List<Asegurado>(serilizarJson.LeerArchivo($"{ruta2}\\asegurados.json"));
                Console.WriteLine("Listado xml");
                foreach (Asegurado item in asegurados3)
                {
                    Console.WriteLine(item.ToString());
                }

            }
            catch (SerializarException ex) 
            { 
                Console.WriteLine($"{ex.Message},\n En la clase:{ex.Clase}, \n En el método: {ex.Metodo}\n {ex.InnerException.Message} ");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }

            Estadistica estadistica =new Estadistica(aseguradora.Asegurados);
            estadistica.CantidadDeAutos();
            estadistica.CantidadDeCamionetas();
            estadistica.CantidadDeMotos();
            estadistica.GeneroQueMasAseguraVehiculo();
            estadistica.LocalidadQueMasAsegura();
            estadistica.SeguroMasElevados();
            estadistica.GeneroQueMasAseguraVehiculo();

            Console.ReadKey();
        }
    }
}
