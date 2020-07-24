using System.Collections.Generic;
using System.Linq;

namespace LojaVirtual.Dominio.Entidades
{
    public abstract class Entidade
    {
        private List<string> _mensagensValidacao { get; set; }
        
        private List<string> mensagemValidacao 
        { 
            get { return _mensagensValidacao ?? (_mensagensValidacao = new List<string>()); }
        }

        public abstract void Validate();
        
        public bool EhValido
        {
            get { return !mensagemValidacao.Any(); }
        }

        protected void LimparMensagensValidacao()
        {
            mensagemValidacao.Clear();
        }

        // Todo: Mudar Nome Mensagem
        protected void AdcionarCritica(string mensagem) => mensagemValidacao.Add(mensagem);

        public string ObterMensagensValidacao()
        {
            return string.Join(". ", mensagemValidacao);
        }

    }
}
