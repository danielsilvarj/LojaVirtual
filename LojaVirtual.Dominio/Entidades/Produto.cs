using System;
using System.Collections.Generic;
using System.Text;

namespace LojaVirtual.Dominio.Entidades
{
    public class Produto : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public string NomeArquivo { get; set; }

        public Produto()
        {

        }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Nome))
                AdcionarCritica("Nome do Produto não foi informado");

            if (string.IsNullOrEmpty(Descricao))
                AdcionarCritica("Descrição não foi informado");
        }
    }
}
