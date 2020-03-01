﻿using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
   public class Produto : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public int quantidade { get; set; }

        public override void Validade()
        {

            if (string.IsNullOrWhiteSpace(Nome))
            {
                AdicionarCritica("Nome não pod ser nulo");
            }
        }
    }
}
