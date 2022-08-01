using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Demo.Tests
{
    public class AssertStringTests
    {
        [Fact]
        public void StringsTools_UnirNomes_RetornarNomeCompleto()
        {
            // Arrange
            var calculadora = new StringsTools();

            // Act
            var resultado = calculadora.Unir("Jonathan", "Dias");

            // Assert
            Assert.Equal("Jonathan Dias", resultado);
        }

        [Fact]
        public void StringsTools_UnirNomes_DeveIgnorarCase()
        {
            // Arrange
            var calculadora = new StringsTools();

            // Act
            var resultado = calculadora.Unir("Jonathan", "Dias");

            // Assert
            Assert.Equal("JONATHAN DIAS", resultado, true);
        }

        [Fact]
        public void StringsTools_UnirNomes_DeveConterTrecho()
        {
            // Arrange
            var calculadora = new StringsTools();

            // Act
            var resultado = calculadora.Unir("Jonathan", "Dias");

            // Assert
            Assert.Contains("nathan", resultado);
        }

        [Fact]
        public void StringsTools_UnirNomes_DeveComecarCom()
        {
            // Arrange
            var calculadora = new StringsTools();

            // Act
            var resultado = calculadora.Unir("Jonathan", "Dias");

            // Assert
            Assert.StartsWith("Jona", resultado);
        }

        [Fact]
        public void StringsTools_UnirNomes_DeveAcabarCom()
        {
            // Arrange
            var calculadora = new StringsTools();

            // Act
            var resultado = calculadora.Unir("Jonathan", "Dias");

            // Assert
            Assert.EndsWith("ias", resultado);
        }
    }
}
