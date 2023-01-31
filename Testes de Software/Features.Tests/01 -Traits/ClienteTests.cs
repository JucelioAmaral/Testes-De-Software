using Features.Clientes;
using System;
using Xunit;

namespace Features.Tests
{
    public class ClienteTests
    {
        [Fact(DisplayName ="Novo Cliente Válido")]
        [Trait("Categoria", "Cliente Trait Testes")] //Observação: Para aparecer os Traits deve-se mudar o agrupamento (Group By) dos testes para "Traits"
        public void Cliente_NovoCliente_DeveEstarValidado()
        {
            //Arrange
            var cliente = new Cliente(
                Guid.NewGuid(),
                "Jucelio",
                "Amaral",
                DateTime.Now.AddYears(-30),
                "jra@jra.com",
                true,
                DateTime.Now);
            //Act
            var result = cliente.EhValido();

            //Assert
            Assert.True(result);
            Assert.Equal(0, cliente.ValidationResult.Errors.Count);
        }

        [Fact(DisplayName = "Novo Cliente Inválido")]
        [Trait("Categoria", "Cliente Trait Testes")] //Observação: Para aparecer os Traits deve-se mudar o agrupamento (Group By) dos testes para "Traits"
        public void Cliente_NovoCliente_DeveEstarInvalido()
        {
            //Arrange
            var cliente = new Cliente(
                Guid.NewGuid(),
                "",
                "",
                DateTime.Now,
                "jraZjra.com",
                true,
                DateTime.Now);
            //Act
            var result = cliente.EhValido();

            //Assert
            Assert.False(result);
            Assert.NotEqual(0, cliente.ValidationResult.Errors.Count);
        }
    }
}
