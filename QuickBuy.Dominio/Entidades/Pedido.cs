﻿using QuickBuy.Dominio.ObjetodeValor;
using System;
using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }

        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public int NumeroEndereco { get; set; }

        public int FormaPagamentoId { get; set; }
        public FormaPagamento FormaPagamento { get; set; }
        public ICollection<ItemPedido> ItensPedido { get; set; }

        public override void Validade()
        {
            if (!ItemPedido.Any())
            {
                MensagemValidacao.Add("Item de pedido não pod ser nulo");
            }

            if (string.IsNullOrWhiteSpace(CEP))
            {
                AdicionarCritica("CEP não pod ser nulo");
            }
        }
    }
}
