using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Demo.Tests
{
    public class _04___AssertNullBoolTests
    {
        [Fact]
        public void Funcionario_Nome_NãoDeveSerNuloOuVazio()
        {
            // Arrange e Act
            var funcionario = new Funcionario("", 1000);

            //Assert
            //O resultado passará porque por mais que passe vazio no construtor, se está vazio preencherá como "Fulano"
            Assert.False(string.IsNullOrEmpty(funcionario.Nome));
        }

        [Fact]
        public void Funcionario_Nome_NãoDeveterApelido()
        {
            // Arrange e Act
            var funcionario = new Funcionario("Jucelio", 1000);

            //Assert
            Assert.Null(funcionario.Apelido);

            //Assert Bool
            Assert.True(string.IsNullOrEmpty(funcionario.Apelido));
            Assert.False(funcionario.Apelido?.Length > 0);
        }
    }
}
