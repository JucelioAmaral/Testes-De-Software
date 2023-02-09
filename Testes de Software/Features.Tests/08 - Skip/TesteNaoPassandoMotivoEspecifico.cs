using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Features.Tests
{
    public class TesteNaoPassandoMotivoEspecifico
    {

        //Use o Skip
        //Nesse teste será gerado um ponto de exclamação sinalizando que o teste foi que foi quebrado. Não quer dizer que passou ou não passou.
        //Assim vc pode sinalizar e voltar para reescrever o teste e passar por este cenário.
        [Fact(DisplayName = "Novo Cliente 2.0", Skip = "Nova versão 2.0 quebrando")]
        [Trait("Categoria", "Escapando dos testes")]
        public void Teste_NaoEstaPassandoVersaoNovaNaoCompativel()
        {            
            Assert.True(false);
        }
    }
}
