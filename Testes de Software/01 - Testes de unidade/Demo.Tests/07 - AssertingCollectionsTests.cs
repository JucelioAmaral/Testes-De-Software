using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Demo.Tests
{
    public class _07___AssertingCollectionsTests
    {
        [Fact]
        public void Funcionario_Habilidades_NaoDevePossuirHabilidadesVazias()
        {
            //Arrange e Act
            var funcionario = FuncionarioFactory.Criar("Jucelio", 1000);

            //Assert            
            Assert.All(funcionario.Habilidades, habilidade => Assert.False(string.IsNullOrWhiteSpace(habilidade)));
        }

        [Fact]
        public void Funcionario_Habilidades_JuniorDevePossuirHabilidadeBasica()
        {
            //Arrange e Act
            var funcionario = FuncionarioFactory.Criar("Jucelio", 1000);

            //Assert            
            Assert.Contains("OOP", funcionario.Habilidades);
        }


        [Fact]
        public void Funcionario_Habilidades_JuniorNaoDevePossuirHabilidadeAvancada()
        {
            //Arrange e Act
            var funcionario = FuncionarioFactory.Criar("Jucelio", 1000);

            //Assert            
            Assert.DoesNotContain("Microservices", funcionario.Habilidades);
        }

        [Fact]
        public void Funcionario_Habilidades_SeniorDevePossuirTodasHabilidade()
        {
            //Arrange e Act
            var funcionario = FuncionarioFactory.Criar("Jucelio", 15000);

            var habilidadesBasicas = new[]
            {
                "Lógica de Programação",
                "OOP",
                "Testes",
                "Microservices"
            };

            //Assert            
            Assert.Equal(habilidadesBasicas , funcionario.Habilidades);
        }
    }
}
