using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL;
using Entities;
using System.Collections.Generic;

namespace UnitTestDAL
{
    [TestClass]
    public class UnitTestDatosClinicosDAO
    {

        [TestMethod]
        public void Test_InsertarDAO()
        {
            List<DatosClinicos> lstDC = new List<DatosClinicos>();
            DatosClinicos al = new Alergias();
            DatosClinicos ant = new Antecedentes();
            DatosClinicos crg = new Cirugias();
            DatosClinicos enf = new Enfermedades();
            DatosClinicos med = new Medicamentos();
            CreatorDatosClinicosDAO creator = new CreatorDatosClinicosDAO();
            DatosClinicosDAO dcDAO;
            bool espected = true;
            bool actual = false;
            al.cedula = "1065645736";
            al.descripcion = "frio";
            ant.cedula = "1065645736";
            ant.descripcion = "cáncer";
            crg.cedula = "1065645736";
            crg.descripcion = "apendice";
            enf.cedula = "1065645736";
            enf.descripcion = "gastritis";
            med.cedula = "1065645736";
            med.descripcion = "omeprazol";
            lstDC.Add(al);
            lstDC.Add(ant);
            lstDC.Add(crg);
            lstDC.Add(enf);
            lstDC.Add(med);
            dcDAO = creator.creator(lstDC[0]);
            actual = dcDAO.insertar(lstDC[0]);
            Assert.AreEqual(espected, actual);
            dcDAO = creator.creator(lstDC[1]);
            actual = dcDAO.insertar(lstDC[1]);
            Assert.AreEqual(espected, actual);
            dcDAO = creator.creator(lstDC[2]);
            actual = dcDAO.insertar(lstDC[2]);
            Assert.AreEqual(espected, actual);
            dcDAO = creator.creator(lstDC[3]);
            actual = dcDAO.insertar(lstDC[3]);
            Assert.AreEqual(espected, actual);
            dcDAO = creator.creator(lstDC[4]);
            actual = dcDAO.insertar(lstDC[4]);
            Assert.AreEqual(espected, actual);
        }

    }
}
