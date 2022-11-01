
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace BiblioCalculadora
{
    [TestClass]
    public class TestCalculadoraString
    {
        [TestMethod]
        public void addDeberiaRetornar0CuandoStingVacio()
        {
            //Arrange
             CalculadoraString calculadoraString = new CalculadoraString();    
            int expected = 0;

            //act
            int actual = calculadoraString.Add(string.Empty);

            //asser
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void addDeberiaRetornarNumeroCuadnoRecibeStringNumero()
        {
            //Arrange
            CalculadoraString calculadoraString = new CalculadoraString();
            int expected = 5;
         
            //act
            int actual = calculadoraString.Add("5");
           
            //asser
            Assert.AreEqual(expected, actual);
            

        }
        [TestMethod]
        public void addDeberiaRetornarSumaCuandoRecibeDosNumeros()
        {
            //arange
            CalculadoraString calculadoraString = new CalculadoraString();
            int expected = 3;

            //act
            int actual = calculadoraString.Add("1,2");

            //assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void RetornarSumaCuandoRecibeCualquierCantidadDeNumeros()
        {
            //arange
            CalculadoraString calculadoraString = new CalculadoraString();
            int expected = 10;

            //act
            int actual = calculadoraString.Add("1,2,3,4");

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void addDeberiaRetornarSumaCuandoRecibeNumerosSeparadosPorSaltosDeLinea()
        {
            //arange
            CalculadoraString calculadoraString = new CalculadoraString();
            int expected = 6;

            //act
            int actual = calculadoraString.Add("1\n2,3");

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddDeberiaDeRetornarSumaCuandoRecibeCualquierDelimitador()
        {
            //arange
            CalculadoraString calculadoraString = new CalculadoraString();
            int expected = 10;

            //act
            int actual = calculadoraString.Add("//..1.2\n3,4");

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(NegativoNoPermitidoExcpetion))]//creo etiqueta para capturar excepcion
        public void AddDeberialanzarExcepcionSiRecibeNegativo()
        {
            //arange
            CalculadoraString calculadoraString = new CalculadoraString();
            int expected = 10;

            //act
            int actual = calculadoraString.Add("//..-1.2\n3,4");

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}