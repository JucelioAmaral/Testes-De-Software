﻿using System;
using System.Linq;
using Xunit;
using static Vendas.Domain.Voucher;

namespace Vendas.Domain.Tests
{
    public class VoucherTests
    {

        [Fact(DisplayName = "Validar Voucher Tipo Valor Válido")]
        [Trait("Categoria", "Vendas Vocher")]
        public void Voucher_ValidarVoucherTipoValor_DeveEstarValido()
        {
            //Arrange
            var voucher = new Voucher("PROMO-15-YEAR", null, 15, 1,
                TipoDescontoVoucher.Valor, DateTime.Now.AddDays(15), true, false);

            //Act
            var result = voucher.ValidarSeAplicavel();

            //Assert
            Assert.True(result.IsValid);
        }

        [Fact(DisplayName = "Validar Voucher Tipo Valor Inválido")]
        [Trait("Categoria", "Vendas Vocher")]
        public void Voucher_ValidarVoucherTipoValor_DeveEstarInvalido()
        {
            //Arrange
            var voucher = new Voucher("", null, null, 0,
                TipoDescontoVoucher.Valor, DateTime.Now.AddDays(-1), false, true);

            //Act
            var result = voucher.ValidarSeAplicavel();

            //Assert
            Assert.False(result.IsValid);
            Assert.Equal(6, result.Errors.Count);
            Assert.Contains(VoucherAplicavelValidation.AtivoErroMsg, result.Errors.Select(c => c.ErrorMessage));
            Assert.Contains(VoucherAplicavelValidation.CodigoErroMsg, result.Errors.Select(c => c.ErrorMessage));
            Assert.Contains(VoucherAplicavelValidation.DataValidadeErroMsg, result.Errors.Select(c => c.ErrorMessage));
            Assert.Contains(VoucherAplicavelValidation.QuantidadeErroMsg, result.Errors.Select(c => c.ErrorMessage));
            Assert.Contains(VoucherAplicavelValidation.UtilizadoErroMsg, result.Errors.Select(c => c.ErrorMessage));
            Assert.Contains(VoucherAplicavelValidation.ValorDescontoErroMsg, result.Errors.Select(c => c.ErrorMessage));
        }
    }
}

