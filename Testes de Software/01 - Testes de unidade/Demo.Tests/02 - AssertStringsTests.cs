using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Demo.Tests
{
    public class _02___AssertStringsTests
    {
        [Fact]
        public void StringsTools_UnitNomes_RetornarNomeCompleto()
        {
            //Arrange
            var sut = new StringsTools();
            //Act
            var nomeCompleto = sut.Unir("Jucelio","Amaral");
            //Assert
            Assert.Equal("Jucelio Amaral", nomeCompleto);
        }

        [Fact]
        public void StringsTools_UnitNomes_DeveIgnorarCase()
        {
            //Arrange
            var sut = new StringsTools();
            //Act
            var nomeCompleto = sut.Unir("Jucelio", "Amaral");
            //Assert
            //Ignora se recebe em minusculo, mas compara com maiusculo
            Assert.Equal("JUCELIO AMARAL", nomeCompleto, true);

        }

        [Fact]
        public void StringsTools_UnitNomes_DeveConterTrecho()
        {
            //Arrange
            var sut = new StringsTools();
            //Act
            var nomeCompleto = sut.Unir("Jucelio", "Amaral");
            //Assert
            //Ignora se recebe em minusculo, mas compara com maiusculo
            Assert.Contains("maral", nomeCompleto);

        }

        [Fact]
        public void StringsTools_UnitNomes_DeveComecarCom()
        {
            //Arrange
            var sut = new StringsTools();
            //Act
            var nomeCompleto = sut.Unir("Jucelio", "Amaral");
            //Assert
            //Ignora se recebe em minusculo, mas compara com maiusculo
            Assert.StartsWith("Juc", nomeCompleto);

        }

        [Fact]
        public void StringsTools_UnitNomes_DeveAcabarCom()
        {
            //Arrange
            var sut = new StringsTools();
            //Act
            var nomeCompleto = sut.Unir("Jucelio", "Amaral");
            //Assert
            //Ignora se recebe em minusculo, mas compara com maiusculo
            Assert.EndsWith("ral", nomeCompleto);

        }

        [Fact]
        public void StringsTools_UnitNomes_ValidaExpressaoRegular()
        {
            //Arrange
            var sut = new StringsTools();
            //Act
            var nomeCompleto = sut.Unir("Jucelio", "Amaral");
            //Assert
            //Ignora se recebe em minusculo, mas compara com maiusculo
            Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", nomeCompleto);

        }
    }
}
