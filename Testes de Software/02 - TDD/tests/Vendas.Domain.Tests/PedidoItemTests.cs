using Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Vendas.Domain.Tests
{
    public class PedidoItemTests
    {
        [Fact(DisplayName = "Novo Item Pedido com unidades Abaixo do permitido")]
        [Trait("Categoria", "Item Pedido Tests")]
        public void AdicionarItemPedido_UnidadesItemAbaixoDoPermitido_DeveRetornarException()
        {
            //Arrange & Act & Assert
            Assert.Throws<DomainException>(() => new PedidoItem(Guid.NewGuid(), "Porduto Teste", Pedido.MIN_UNIDADES_ITEM - 1, 100));
        }
    }
}
