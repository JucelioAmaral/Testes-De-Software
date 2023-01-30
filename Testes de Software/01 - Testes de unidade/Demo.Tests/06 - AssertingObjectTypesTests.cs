using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Demo.Tests
{
    public class _06___AssertingObjectTypesTests
    {
        [Fact]
        public void FuncionarioFactory_Criar_DeveRetornarTipoFuncionario()
        {
            //Arrange e act
            var funcionario = FuncionarioFactory.Criar("Jucelio", 1000);

            //Assert
            //verifica se o objeto criado é dotipo "funcionario"
            Assert.IsType<Funcionario>(funcionario);
        }

        [Fact]
        public void FuncionarioFactory_Criar_DeveRetornarTipoDerivadoPessoa()
        {
            //Arrange e act
            var funcionario = FuncionarioFactory.Criar("Jucelio", 1000);

            //Assert
            //verifica se o objeto/classe herda de "Pessoa".
            Assert.IsAssignableFrom<Pessoa>(funcionario);
        }
    }
}
