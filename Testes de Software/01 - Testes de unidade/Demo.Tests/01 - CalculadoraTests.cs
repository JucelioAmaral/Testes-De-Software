﻿using Xunit;

namespace Demo.Tests
{
    public class _01___CalculadoraTests
    {
        [Fact]
        public void Calculadora_Somar_RetornarValorSoma()
        {
            //Arrange
            var calculadora = new Calculadora();
            //Act
            var resultado = calculadora.Somar(2, 2);
            //Assert            
            Assert.Equal(4, resultado);
        }

        [Theory]
        [InlineData(1,1,2)]
        [InlineData(2, 4, 6)]
        [InlineData(4, 5, 9)]
        [InlineData(6, 7, 13)]
        [InlineData(8, 9, 17)]
        public void Calculadora_Somar_RetornarValoresSomaCorretos(double v1, double v2, int total)
        {
            //Arrange
            var calculadora = new Calculadora();
            //Act
            var resultado = calculadora.Somar(v1, v2);
            //Assert            
            Assert.Equal(total, resultado);
        }
    }
}