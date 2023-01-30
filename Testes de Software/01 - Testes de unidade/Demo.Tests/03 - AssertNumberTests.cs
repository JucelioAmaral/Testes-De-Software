using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Demo.Tests
{
    public class _03___AssertNumberTests
    {
        [Fact]
        public void Calculadora_Somar_DeveSerIgual()
        {
            // Arrange
            var calculadora = new Calculadora();
            // Act
            var result = calculadora.Somar(1, 2);
            // Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void Calculadora_Somar_NaoDeveSerIgual()
        {
            // Arrange
            var calculadora = new Calculadora();
            // Act
            var result = calculadora.Somar(1,2);
            // Assert
            Assert.NotEqual(5, result);
        }
    }
}
