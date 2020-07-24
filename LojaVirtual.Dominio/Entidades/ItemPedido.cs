﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LojaVirtual.Dominio.Entidades
{
    public class ItemPedido : Entidade
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public override void Validate()
        {
            if (ProdutoId == 0)
                AdcionarCritica("Não foi identificado qual a referencia do produto");

            if (Quantidade == 0)
                AdcionarCritica("Quantidade não foi informado");
        }
    }
}
