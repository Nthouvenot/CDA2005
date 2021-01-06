using ClassLibraryDataPersistence;
using ClassLibraryDomainPersistence;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodCreate()
        {
            SuplierPersistence persistence = new SuplierPersistence("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PapyrusNicolas;Integrated Security=True;Pooling = true");
            SuplierStructure suplier1 = new SuplierStructure();
            suplier1.name = "paperExpert";
            suplier1.streetNumber = 3;
            suplier1.streetName = "rue des experts";
            suplier1.cityName = "Toulouse";
            suplier1.zipCode = 21560;
            suplier1.contact = "Mireille";
            suplier1.satisfaction = 6;
            suplier1.id = persistence.CreateSuplier(suplier1);
            Assert.AreNotEqual(-1, suplier1.id);
        }

        [TestMethod]
        public void TestMethodReadOneSuplierById()
        {

            SuplierPersistence persistence = new SuplierPersistence("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PapyrusNicolas;Integrated Security=True;Pooling = true");
            SuplierStructure suplier1 = new SuplierStructure();
            suplier1.id = 4;
            suplier1 = persistence.ReadOneSuplierById(4);
            Assert.AreEqual(4, suplier1.id);
            Assert.AreEqual("Discobol", suplier1.name);
            Assert.AreEqual(40, suplier1.streetNumber);
            Assert.AreEqual("rue de la decouverte", suplier1.streetName);
            Assert.AreEqual("curieuxcity", suplier1.cityName);
            Assert.AreEqual(75201, suplier1.zipCode);
            Assert.AreEqual("Tom", suplier1.contact);
            Assert.AreEqual(9, suplier1.satisfaction);
        }
    }
}
