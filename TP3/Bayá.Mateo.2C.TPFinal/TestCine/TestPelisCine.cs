using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace TestCine
{
    [TestClass]
    public class TestPelisCine
    {
        /// <summary>
        /// Se confirma que los textos son realmente distintos y por ende la asignacion aleatoria funciona
        /// </summary>
        [TestMethod]
        public void TestHorarioAleatorio()
        {
            //Arrange
            string text;
            string text2;
            //Act
            text=Pelicula.ElegirHorarioDisponible();
            text2 = Pelicula.ElegirHorarioDisponible();
            //Assert
            Assert.AreNotEqual(text, text2);

        }

        /// <summary>
        /// Se confirma si las validaciones se hicieron correctamente, causando una excepcion en el constructor
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(PeliculaMalCargadaException))]
        public void TestExceptionDatosMalCargados()
        {
            //Arrenge
            Pelicula peli;
            //Act
            peli = new Pelicula(1, "ra", 20, 3, 2, "rar");
        }
    }
}
