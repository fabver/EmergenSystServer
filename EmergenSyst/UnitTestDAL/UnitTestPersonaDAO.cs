using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entities;
using DAL;

namespace UnitTestDAL
{
    [TestClass]
    public class UnitTestPersonaDAO
    {
        [TestMethod]
        public void Test_insertar()
        {
            DateTime f = DateTime.Today;
            f = f.Date;
            Persona p = new Persona("1234","Fabián","Urrego", f, 'M');
            PersonaDAO pDAO = new PersonaDAO();
            int espected = 1;
            int actual = pDAO.insertar(p);
            Assert.AreEqual(espected, actual);
        }
    }
}
