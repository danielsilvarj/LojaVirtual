using LojaVirtual.Dominio.ObjetoDeValor;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LojaVirtual.Dominio.Entidades
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
        public virtual FormaPagamento FormaPagamento { get; set; }
        

        public virtual ICollection<ItemPedido>  ItensPedido { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();

            if (!ItensPedido.Any())
                AdcionarCritica("Item de Pedido não pode ficar vazio");

            if(String.IsNullOrEmpty(CEP))
                AdcionarCritica("CEP deve estar preenchido");

            if (FormaPagamentoId == 0)
                AdcionarCritica("Não informado a forma de pagamento");
        }
    }
}
