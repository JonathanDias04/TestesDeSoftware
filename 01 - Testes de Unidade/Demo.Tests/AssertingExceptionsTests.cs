using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Demo.Tests
{
    public class AssertingExceptionsTests
    {
        [Fact]
        public void Calculadora_Dividir_DeveRetorenarErroDivisaoPorZero()
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => calculadora.Dividir(10, 0));
        }

        [Fact]
        public void Calculadora_Dividir_DeveRetornarErroSalarioInferiorPermitido()
        {
            // Arrange & Act & Assert
            var exception = Assert.Throws<Exception>(() => FuncionarioFactory.Criar("Jonathan", 250));

            Assert.Equal("Salario inferior ao permitido", exception.Message);
        }
    }
}
