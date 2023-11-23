using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using BACK;
using BACK.Entidades;
using BACK.Herramientas;
using BACK.Scripts;

namespace pruebitas
{
    [TestClass]
    public class PruebasUnitarias
    {
        [TestMethod]
        public void PruebaResetearTabla()
        {
            // Arrange
            ConexionConTabla conec = new ConexionConTabla("Data Source=DESKTOP-FT8QR65\\NEWSERVER; Initial Catalog=RENT-A-TRONICDB;Integrated Security=True");

            // Act
            FilesManager.ResetearTablas(conec);
            FilesManager.CargarInformacionBase(conec, new List<InterfazEntidades>()
        {
            new UsuarioEntidad(),
            new AnimatronicoEntidad(),
            new FiestaEntidad(),
            new CantidadEntidad(),
            new AnimatronicoFiestaEntidad()
        });

            // Assert
            Assert.IsTrue(conec.FuncionaConexion);
        }

        [TestMethod]
        public void PruebaCreadoAnimatronico()
        {
            // Arrange
            ConexionConTabla conec = new ConexionConTabla("Data Source=DESKTOP-FT8QR65\\NEWSERVER; Initial Catalog=RENT-A-TRONICDB;Integrated Security=True");
            AnimatronicoEntidad freddy = new AnimatronicoEntidad(-1, "golden freddy", "es fachero", true, 1, 1);

            // Act
            ((InterfazEntidades)freddy).CrearEntradaEnLaTabla(conec);
            ColeccionEntidades<AnimatronicoEntidad> totalAnim = new ColeccionEntidades<AnimatronicoEntidad>(conec);

            // Assert
            Assert.AreEqual(totalAnim["nombre", "golden freddy"].Count, 1);
        }

        [TestMethod]
        public void PruebaCreadoFiesta()
        {
            // Arrange
            ConexionConTabla conec = new ConexionConTabla("Data Source=DESKTOP-FT8QR65\\NEWSERVER; Initial Catalog=RENT-A-TRONICDB;Integrated Security=True");
            FiestaEntidad fiesta = new FiestaEntidad("mi casa", -1, true, 1500, "Juan", "+54 9 11 4194 3821", "correo@hotmail.com", new DateTime(2023, 12, 1), 0);

            // Act
            ((InterfazEntidades)fiesta).CrearEntradaEnLaTabla(conec);
            ColeccionEntidades<FiestaEntidad> totalFiesta = new ColeccionEntidades<FiestaEntidad>(conec);

            // Assert
            Assert.AreEqual(totalFiesta["nombre", "Juan"].Count, 1);
        }
    }
}


