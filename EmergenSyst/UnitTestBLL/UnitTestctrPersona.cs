using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;

namespace UnitTestBLL
{
    [TestClass]
    public class UnitTestctrPersona
    {

        //[TestMethod]
        //public void Test_esCedulaValida()
        //{
        //    ctrPersona ctrP = new ctrPersona();
        //    bool espected = true;
        //    bool actual = ctrP.esCedulaValida("1234567890");
        //    Assert.AreEqual(espected, actual);
        //    espected = false;
        //    actual = ctrP.esCedulaValida("12");
        //    Assert.AreEqual(espected, actual);
        //    espected = false;
        //    actual = ctrP.esCedulaValida("12345678901234567890");
        //    Assert.AreEqual(espected, actual);
        //}

        //[TestMethod]
        //public void Test_esNombreValido()
        //{
        //    ctrPersona ctrP = new ctrPersona();
        //    bool espected = true;
        //    bool actual = ctrP.esNombreValido("Fabián");
        //    Assert.AreEqual(espected, actual);
        //    espected = false;
        //    actual = ctrP.esNombreValido("Fa");
        //    Assert.AreEqual(espected, actual);
        //    espected = false;
        //    actual = ctrP.esNombreValido("Faiiiiiiiiiiiiiiiiiiiiiiiiiiiiiii");
        //    Assert.AreEqual(espected, actual);
        //}

        //[TestMethod]
        //public void Test_esApellidoValido()
        //{
        //    ctrPersona ctrP = new ctrPersona();
        //    bool espected = true;
        //    bool actual = ctrP.esApellidoValido("Urrego");
        //    Assert.AreEqual(espected, actual);
        //    espected = false;
        //    actual = ctrP.esApellidoValido("Fa");
        //    Assert.AreEqual(espected, actual);
        //    espected = false;
        //    actual = ctrP.esApellidoValido("Faiiiiiiiiiiiiiiiiiiiiiiiiiiiiiii");
        //    Assert.AreEqual(espected, actual);
        //}

        //[TestMethod]
        //public void Test_esFechaValido()
        //{
        //    ctrPersona ctrP = new ctrPersona();
        //    DateTime fecha, hoy;
        //    hoy = DateTime.Today;
        //    fecha = hoy.AddDays(-1);
        //    int r = (hoy.CompareTo(fecha));
        //    bool espected = true;
        //    bool actual = ctrP.esFechaValida(fecha);
        //    Assert.AreEqual(espected, actual);
        //    fecha = hoy;
        //    espected = false;
        //    actual = ctrP.esFechaValida(fecha);
        //    Assert.AreEqual(espected, actual);
        //    fecha = hoy.AddDays(1);
        //    espected = false;
        //    actual = ctrP.esFechaValida(fecha);
        //    Assert.AreEqual(espected, actual);
        //}
        //[TestMethod]
        //public void Test_setPersona()
        //{
        //    ctrPersona ctrP = new ctrPersona();
        //    string p = ctrP.setPersona("1065645736");
        //    Console.WriteLine(p);
        //}
        [TestMethod]
        public void Test_getHitoriaClinica()
        {
            //ctrHistoriaClinica ctrHC.
        }
    }
}
