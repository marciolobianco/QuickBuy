﻿using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
   public class ItemPedido: Entidade
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        internal static bool Any()
        {
            throw new NotImplementedException();
        }

        public override void Validade()
        {

            if (Quantidade < 1)
            {
                AdicionarCritica("Quantidade não pod ser nulo");
            }
        }
    }
}
