﻿using System.Collections.Generic;

namespace LojaVirtual.Dominio.Entidades
{
    public class Usuario : Entidade
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public bool EhAdministrador { get; set; }

        public virtual ICollection<Pedido>  Pedidos { get; set; }

        public Usuario()
        {

        }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Email))
                AdcionarCritica("Email não foi informado");

            if (string.IsNullOrEmpty(Senha))
                AdcionarCritica("Senha não foi informado");
        }
    }
}
