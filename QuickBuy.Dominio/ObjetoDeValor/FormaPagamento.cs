using QuickBuy.Dominio.Enumerados;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.ObjetoDeValor
{
    public class FormaPagamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public bool EhBoleto
        {
            get => Id == (int)TipoFormaPagamentoEnum.Boleto;
        }
        public bool EhCartaoCredito
        {
            get => Id == (int)TipoFormaPagamentoEnum.CartaoCredito;
        }
        public bool EhDeposito
        {
            get => Id == (int)TipoFormaPagamentoEnum.Deposito;
        }
        public bool EhNaoDefinido
        {
            get => Id == (int)TipoFormaPagamentoEnum.NaoDefinido;
        }
    }
}
