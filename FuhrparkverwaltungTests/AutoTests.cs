using Microsoft.VisualStudio.TestTools.UnitTesting;
using FuhrparkverwaltungTests;

namespace FuhrparkverwaltungTests
{
    [TestClass]
    public class AutoTests
    {
        [TestMethod]
        public void Fahren_SteigertKilometerstand()
        {
            //Arrange
            int kilometerstand = 0;
            Auto a = new Auto(kilometerstand);
            int streckeInKilometern = 50;

            //Act
            a.Fahren(streckeInKilometern);

            //Assert
            Assert.AreEqual(50, a.Kilometerstand);
        }

        [TestMethod]
        public void Fahren_NegativStreckeIgnorieren()
        {
            //Arrage

            int kilometerstand = 10;
            Auto a = new Auto(kilometerstand);
            int streckeInKilometern = -1;

            //Act
            a.Fahren(streckeInKilometern);

            //Assert
            Assert.AreEqual(10, a.Kilometerstand);
        }


    }
}

