using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entities;
using BLL;
using System.Collections.Generic;

namespace UnitTestBLL
{
    [TestClass]
    public class UnitTestctrDatosClinicos
    {
        ctrDatosClinicos ctrDC = new ctrDatosClinicos();
        [TestMethod]
        public void Test_Insertar()
        {
            List<DatosClinicos> lstDC = new List<DatosClinicos>();
            DatosClinicos enf =new DatosClinicos();
            enf.cedula = "1065645736";
            enf.descripcion = "Gastritis";
            enf.tipo = "Enfermedad";
            DatosClinicos cir = new DatosClinicos();
            cir.cedula = "1065645736";
            cir.descripcion = "Apendice";
            cir.tipo = "Cirugía";
            lstDC.Add(enf);
            lstDC.Add(cir);
            string espected = "Guardado satisfactoriamente";
            string actual = ctrDC.insertar(lstDC);
            Assert.AreEqual(espected, actual);
            //enf.cedula = "1065645736";
            //enf.descripcion = "frio";
            //cir.cedula = "106";
            //cir.descripcion = "cáncer";
            //lstDC.Add(enf);
            //lstDC.Add(cir);
            //espected = "Los datos no cumplen las especificaciones dadas.";
            //actual = ctrDC.insertar(lstDC);
            //Assert.AreEqual(espected, actual);
            //enf.cedula = "1065645736";
            //enf.descripcion = "frio";
            //cir.cedula = "1065645736";
            //cir.descripcion = "cá";
            //lstDC.Add(enf);
            //lstDC.Add(cir);
            //espected = "Los datos no cumplen las especificaciones dadas.";
            //actual = ctrDC.insertar(lstDC);
            //Assert.AreEqual(espected, actual);
        }

        //[TestMethod]
        //public void Test_esDatoValido()
        //{
        //    DatosClinicos al = new Alergias();
        //    al.cedula = "1065645736";
        //    al.descripcion = "frio";
        //    bool espected = true;
        //    bool actual = ctrDC.esDatoValido(al);
        //    Assert.AreEqual(espected, actual);
        //    al.cedula = "1065645736";
        //    al.descripcion = "fr";
        //    espected = false;
        //    actual = ctrDC.esDatoValido(al);
        //    Assert.AreEqual(espected, actual);
        //    al.cedula = "1065645";
        //    al.descripcion = "frio";
        //    espected = false;
        //    actual = ctrDC.esDatoValido(al);
        //    Assert.AreEqual(espected, actual);
        //    al.cedula = "10656457367872164537";
        //    al.descripcion = "frio";
        //    espected = false;
        //    actual = ctrDC.esDatoValido(al);
        //    Assert.AreEqual(espected, actual);
        //    al.cedula = "1065";
        //    al.descripcion = "fr";
        //    espected = false;
        //    actual = ctrDC.esDatoValido(al);
        //    Assert.AreEqual(espected, actual);
        //}

    }
}
