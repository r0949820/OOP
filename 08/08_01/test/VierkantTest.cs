using models;
using NUnit.Framework;
using System;

namespace test
{
    [TestFixture]
    public class VierkantTests
    {
        //Maak de nodige test-methodes om de property Zijde te testen.

        [Test]
        public void Zijde_MinderDanNul_ZetOpNul()
        {
            //Arrange
            Vierkant vierkant = new Vierkant();
            int invalidValue = -5;

            // Act
            vierkant.Zijde = invalidValue;

            // Assert
            Assert.AreEqual(0, vierkant.Zijde);
        }

        [Test]
        public void Zijde_GroterDan25_ZetOp25()
        {
            // Arrange
            Vierkant vierkant = new Vierkant();
            int invalidValue = 30;

            // Act
            vierkant.Zijde = invalidValue;

            // Assert
            Assert.AreEqual(25, vierkant.Zijde);
        }

        [Test]
        public void Zijde_JuisteWaarde_Correct()
        {
            // Arrange
            Vierkant vierkant = new Vierkant();
            int expectedValue = 10;

            // Act
            vierkant.Zijde = expectedValue;

            // Assert
            Assert.AreEqual(expectedValue, vierkant.Zijde);
        }

        //Maak de nodige test-methodes om de constructors te testen.
        [Test]
        public void Constructor_MetLengte_ZetZijdeNaarLengte()
        {
            // Arrange
            int expectedValue = 5;

            // Act
            Vierkant vierkant = new Vierkant(expectedValue);

            // Assert
            Assert.AreEqual(expectedValue, vierkant.Zijde);
        }

        [Test]
        public void Constructor_ZonderLengte_ZetZijdeNaarNul()
        {
            // Act
            Vierkant vierkant = new Vierkant();

            // Assert
            Assert.AreEqual(0, vierkant.Zijde);
        }

        //Maak de nodige test-methodes om de methode Diagonaal te testen.
        [Test]
        public void Diagonaal_ReturnCorrecteWaarde()
        {
            // Arrange
            int zijde = 5;
            Vierkant vierkant = new Vierkant(zijde);
            double expectedValue = Math.Round(Math.Sqrt(2) * zijde, 2);
            
            // Act
            double result = vierkant.Diagonaal();

            // Assert
            Assert.IsTrue(Math.Abs(expectedValue - result) < 0.0001);
        }

        //Maak de nodige test-methodes om de methode Omtrek te testen.
        [Test]
        public void Omtrek_ReturnCorrecteWaarde()
        {
            // Arrange
            int zijde = 5;
            int expectedValue = 4 * zijde;
            Vierkant vierkant = new Vierkant(zijde);

            // Act
            int result = vierkant.Omtrek();

            // Assert
            Assert.AreEqual(expectedValue, result);
        }

        //Maak de nodige test-methodes om de methode Oppervlakte te testen.
        [Test]
        public void Oppervlakte_ReturnCorrecteWaarde()
        {
            // Arrange
            int zijde = 5;
            int expectedValue = zijde * zijde;
            Vierkant vierkant = new Vierkant(zijde);

            // Act
            int result = vierkant.Oppervlakte();

            // Assert
            Assert.AreEqual(expectedValue, result);
        }

        //Maak de nodige test-methodes om de methode Teken te testen.
        [Test]
        public void Teken_ReturnCorrecteString()
        {
            // Arrange
            int zijde = 3;
            string expectedString = "* * * \n* * * \n* * * \n";
            Vierkant vierkant = new Vierkant(zijde);

            // Act
            string result = vierkant.Teken();

            // Assert
            Assert.AreEqual(expectedString, result);
        }
    }
}