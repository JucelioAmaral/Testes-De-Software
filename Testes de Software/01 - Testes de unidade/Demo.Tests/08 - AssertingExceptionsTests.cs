using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Demo.Tests
{
    public class _08___AssertingExceptionsTests
    {
        [Fact]
        public void Calculadora_Dividir_DeveRetornarErroDivisaoPorZero()
        {
            //Arrange
            var calculadora = new Calculadora();

            //Act e Assert
            Assert.Throws<DivideByZeroException>(() => calculadora.Dividir(10, 0));
        }

        [Fact]
        public void Funcionario_Salario_DeveRetornarErroSalarioInferiorPermitido()
        {
            //Arrange e Act e Assert
            var exception = Assert.Throws<Exception>(() => FuncionarioFactory.Criar("Jucelio", 250));

            Assert.Equal("Salario inferior ao permitido", exception.Message);
        }
    }
}
