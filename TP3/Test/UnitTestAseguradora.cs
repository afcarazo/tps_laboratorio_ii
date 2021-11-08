using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System;

namespace Test
{
    [TestClass]
    public class UnitTestAseguradora
    {
        /// <summary>
        /// Comprueba que la igualdad de asegurados sea correcta
        /// </summary>
        [TestMethod]
        public void IgualdadAsegurados_True()
        {
            Asegurado aseguradoUno = new Asegurado("Tomas", "Gallardo", ELocalidad.Berazategui, "tomasgallardo@gmail.com", 40585871, EGenero.Masculino, new Auto(EMarca.Renault, 2019, "AFDE92", "Renault c320 Privilege 6x4 construction"), new Seguro(EPlanDePago.Debito, ETipoSeguro.ResponsabilidadCivil, 3500));
            Asegurado aseguradoDos = new Asegurado("Tomas", "Gallardo", ELocalidad.Berazategui, "tomasgallardo@gmail.com", 40585871, EGenero.Masculino, new Auto(EMarca.Renault, 2019, "AFDE92", "Renault c320 Privilege 6x4 construction"), new Seguro(EPlanDePago.Debito, ETipoSeguro.ResponsabilidadCivil, 3500));

            bool rta = aseguradoUno == aseguradoDos;

            Assert.IsTrue(rta);
        }
        /// <summary>
        /// Comprueba que la igualdad de asegurados sea incorrecta
        /// </summary>
        [TestMethod]
        public void IgualdadAsegurados_False()
        {
            Asegurado aseguradoUno = new Asegurado("Tomas", "Gallardo", ELocalidad.Berazategui, "tomasgallardo@gmail.com", 40585871, EGenero.Masculino, new Auto(EMarca.Renault, 2019, "AFDE92", "Renault c320 Privilege 6x4 construction"), new Seguro(EPlanDePago.Debito, ETipoSeguro.ResponsabilidadCivil, 3500));
            Asegurado aseguradoDos = new Asegurado("Tomas", "Gallardo", ELocalidad.Berazategui, "gallardo@gmail.com", 42589621, EGenero.Masculino, new Auto(EMarca.Renault, 2019, "AFDE92", "Renault c320 Privilege 6x4 construction"), new Seguro(EPlanDePago.Debito, ETipoSeguro.ResponsabilidadCivil, 3500));

            bool rta = aseguradoUno == aseguradoDos;

            Assert.IsFalse(rta);
        }
        /// <summary>
        /// Comprueba que la igualdad de autos sea correcta
        /// </summary>
        [TestMethod]
        public void IgualdadAutos_True()
        {
            Auto numeroUno = new Auto(EMarca.Renault, 2019, "AFDE92", "Renault c320 Privilege 6x4 construction");
            Auto numeroDos = new Auto(EMarca.Renault, 2019, "AFDE92", "Renault c320 Privilege 6x4 construction");

            bool rta = numeroUno == numeroDos;

            Assert.IsTrue(rta);
        }
        /// <summary>
        /// Comprueba que la igualdad de autos sea incorrecta
        /// </summary>
        [TestMethod]
        public void IgualdadAutos_False()
        {
            Auto numeroUno = new Auto(EMarca.Renault, 2019, "AFDE92", "Renault c320 Privilege 6x4 construction");
            Auto numeroDos = new Auto(EMarca.Renault, 2019, "EJKP99", "Renault c320 Privilege 6x4 construction");

            bool rta = numeroUno == numeroDos;

            Assert.IsFalse(rta);
        }
        /// <summary>
        /// Comprueba que la igualdad de camionetas sea correcta
        /// </summary>
        [TestMethod]
        public void IgualdadCamionetas_True()
        {
            Camioneta numeroUno = new Camioneta(EMarca.Honda, 2021, "FEWE22", "Honda cr-v 2021");
            Camioneta numeroDos = new Camioneta(EMarca.Honda, 2021, "FEWE22", "Honda cr-v 2021");

            bool rta = numeroUno == numeroDos;

            Assert.IsTrue(rta);
        }
        /// <summary>
        /// Comprueba que la igualdad de camionetas sea incorrecta
        /// </summary>
        [TestMethod]
        public void IgualdadCamionetas_False()
        {
            Camioneta numeroUno = new Camioneta(EMarca.Honda, 2021, "HJIK97", "Honda cr-v 2021");
            Camioneta numeroDos = new Camioneta(EMarca.Honda, 2021, "FEWE22", "Honda cr-v 2021");

            bool rta = numeroUno == numeroDos;

            Assert.IsFalse(rta);
        }
        /// <summary>
        /// Comprueba que la igualdad de motos sea correcta
        /// </summary>
        [TestMethod]
        public void IgualdadMotos_True()
        {
            Moto numeroUno = new Moto(EMarcaMoto.Yamaha, 2021, "REWE62", 150, "Yamaha Xtz");
            Moto numeroDos = new Moto(EMarcaMoto.Yamaha, 2021, "REWE62", 150, "Yamaha Xtz");
            
            bool rta = numeroUno == numeroDos;

            Assert.IsTrue(rta);
        }
        /// <summary>
        /// Comprueba que la igualdad de autos sea incorrecta
        /// </summary>
        [TestMethod]
        public void IgualdadMotos_False()
        {
            Moto numeroUno = new Moto(EMarcaMoto.Yamaha, 2021, "OEWE62", 200, "Yamaha Xtz");
            Moto numeroDos = new Moto(EMarcaMoto.Yamaha, 2021, "REWE62", 150, "Yamaha Xtz");
            
            bool rta = numeroUno == numeroDos;

            Assert.IsFalse(rta);
        }
        /// <summary>
        /// Verifica si se ingresa correctamente un asegurado a la lista
        /// </summary>
        [TestMethod]
        public void AgregarAsegurado_Ok()
        {
            Aseguradora aseguradora = new Aseguradora();
            Asegurado aseguradoUno = new Asegurado("Angela", "Gallardo", ELocalidad.Berazategui, "angela@gmail.com", 42585871, EGenero.Femenino, new Auto(EMarca.Renault, 2019, "AFDE92", "Renault c320 Privilege 6x4 construction"), new Seguro(EPlanDePago.Debito, ETipoSeguro.ResponsabilidadCivil, 3500));
            Asegurado aseguradoDos = new Asegurado("Sofia", "Gallardo", ELocalidad.Glew, "sofia@gmail.com", 40585971, EGenero.Femenino, new Auto(EMarca.Honda, 2020, "AFRF92", "Honda cr-v 2021"), new Seguro(EPlanDePago.Efectivo, ETipoSeguro.ResponsabilidadCivil, 4000));
            aseguradora += aseguradoUno;
            aseguradora += aseguradoDos;
            int estacioOcupadoEsperado = 2;

            Assert.AreEqual(estacioOcupadoEsperado,aseguradora.Asegurados.Count);

        }
        /// <summary>
        /// Verifica si se ingresa incorrectamente un asegurado a la lista
        /// </summary>
        [TestMethod]
        public void AgregarAsegurado_Falla()
        {
            Aseguradora aseguradora = new Aseguradora();
            Asegurado aseguradoUno = new Asegurado("Angela", "Gallardo", ELocalidad.Berazategui, "angela@gmail.com", 42585871, EGenero.Femenino, new Auto(EMarca.Renault, 2019, "AFDE92", "Renault c320 Privilege 6x4 construction"), new Seguro(EPlanDePago.Debito, ETipoSeguro.ResponsabilidadCivil, 3500));
            Asegurado aseguradoDos = new Asegurado("Sofia", "Gallardo", ELocalidad.Glew, "sofia@gmail.com", 40585971, EGenero.Femenino, new Auto(EMarca.Honda, 2020, "AFRF92", "Honda cr-v 2021"), new Seguro(EPlanDePago.Efectivo, ETipoSeguro.ResponsabilidadCivil, 4000));
            aseguradora += aseguradoUno;
            aseguradora += aseguradoDos;
            int estacioOcupadoEsperado = 3;

            
            Assert.AreNotEqual(estacioOcupadoEsperado, aseguradora.Asegurados.Count);
        }
        /// <summary>
        /// Verificar si se quita correctamente un asegurado a la lista
        /// </summary>
        [TestMethod]
        public void QuitarAsegurado_Ok()
        {
            Aseguradora aseguradora = new Aseguradora();
            Asegurado aseguradoUno = new Asegurado("Angela", "Gallardo", ELocalidad.Berazategui, "angela@gmail.com", 42585871, EGenero.Femenino, new Auto(EMarca.Renault, 2019, "AFDE92", "Renault c320 Privilege 6x4 construction"), new Seguro(EPlanDePago.Debito, ETipoSeguro.ResponsabilidadCivil, 3500));
            Asegurado aseguradoDos = new Asegurado("Sofia", "Gallardo", ELocalidad.Glew, "sofia@gmail.com", 40585971, EGenero.Femenino, new Auto(EMarca.Honda, 2020, "AFRF92", "Honda cr-v 2021"), new Seguro(EPlanDePago.Efectivo, ETipoSeguro.ResponsabilidadCivil, 4000));
            aseguradora += aseguradoUno;
            aseguradora += aseguradoDos;
            aseguradora -= aseguradoUno;
            int estacioOcupadoEsperado = 1;

            Assert.AreEqual(estacioOcupadoEsperado, aseguradora.Asegurados.Count);

        }
        /// <summary>
        ///  Verificar si se quita incorrectamente un asegurado a la lista
        /// </summary>
        [TestMethod]
        public void QuitarAsegurado_Falla()
        {
            Aseguradora aseguradora = new Aseguradora();
            Asegurado aseguradoUno = new Asegurado("Angela", "Gallardo", ELocalidad.Berazategui, "angela@gmail.com", 42585871, EGenero.Femenino, new Auto(EMarca.Renault, 2019, "AFDE92", "Renault c320 Privilege 6x4 construction"), new Seguro(EPlanDePago.Debito, ETipoSeguro.ResponsabilidadCivil, 3500));
            Asegurado aseguradoDos = new Asegurado("Sofia", "Gallardo", ELocalidad.Glew, "sofia@gmail.com", 40585971, EGenero.Femenino, new Auto(EMarca.Honda, 2020, "AFRF92", "Honda cr-v 2021"), new Seguro(EPlanDePago.Efectivo, ETipoSeguro.ResponsabilidadCivil, 4000));
            aseguradora += aseguradoUno;
            aseguradora += aseguradoDos;
            aseguradora -= aseguradoUno;
            int estacioOcupadoEsperado = 2;

            Assert.AreNotEqual(estacioOcupadoEsperado, aseguradora.Asegurados.Count);

        }
    }
}
