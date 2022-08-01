using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Demo.Tests
{
    public class AssertNullBoolTests
    {
        [Fact]
        public void Funcionario_Nome_NaoDeveSerNuloOuVazio()
        {
            // Arrange & Act
            var funcionario = new Funcionario("", 1000);

            Assert.False(string.IsNullOrEmpty(funcionario.Nome));
        }

        [Fact]
        public void Funcionario_Apelido_NaoDeveTerApelido()
        {
            // Arrange & Act
            var funcionario = new Funcionario("Jonathan", 1000);

            // Assert
            Assert.Null(funcionario.Apelido);

            // Assert Bool
            Assert.True(string.IsNullOrEmpty(funcionario.Apelido));
            Assert.False(funcionario.Apelido?.Length > 0);
        }
    }
}
