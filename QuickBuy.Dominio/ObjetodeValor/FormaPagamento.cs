using QuickBuy.Dominio.Enumerados;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.ObjetodeValor
{
  public   class FormaPagamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public bool ehBoleto
        {
            get { return Id == (int)TipoFormaPagamentoEnum.Boleto; } 
        }
        public bool ehCartaoCredito
        {
            get { return Id == (int)TipoFormaPagamentoEnum.CartaoCredito; }
        }
        public bool ehDeposito
        {
            get { return Id == (int)TipoFormaPagamentoEnum.Deposito; }
        }

        public bool NãoFoiDefinido
        {
            get { return Id == (int)TipoFormaPagamentoEnum.NaoDefinodo; }
        }
    }
}
