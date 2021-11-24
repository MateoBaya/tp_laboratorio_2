using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System.Collections.Generic;
using System;

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
            text = Pelicula.ElegirHorarioDisponible();
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
        /// <summary>
        /// Se verifica que no se pueda cargar un mismo usuario en la base de datos, segun su Usuario
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(UsuarioMalCargadoException))]
        public void TestCargarUsuarioYaCargado()
        {
            SqlHandler.RegistrarUsuario("Server=.;Database=Pelis;Trusted_Connection=True;",new UsuarioRegistrado("a",21564845,"admin","a","a"));
        }
        public delegate void SumarVisitas(Pelicula pelicula);
        [TestMethod]
        public void TestSumarVisitas()
        {
            //Arrange
            string conexion = "Server=.;Database=Pelis;Trusted_Connection=True;";
            List<Pelicula> pelisSinSumarVisitas = SqlHandler.LeerPeliculas(conexion);
            Pelicula[] pelisSinSumar = pelisSinSumarVisitas.ToArray();
            Pelicula peli = pelisSinSumar[0];
            List<Pelicula> pelisSumando = SqlHandler.LeerPeliculas(conexion);
            Pelicula[] pelisSumadas = pelisSumando.ToArray();
            Pelicula peliCambiada = pelisSumadas[0];
            //Act
            peliCambiada.VisitasCambiada += (peliCambiada) => SqlHandler.ModificarPeliculaVisitas(conexion, peliCambiada.Id, peliCambiada.Visitas);
            peliCambiada.Visitas++;
            //Assert
            Assert.AreEqual(peli.Visitas+1, peliCambiada.Visitas);
        }
    }
}
