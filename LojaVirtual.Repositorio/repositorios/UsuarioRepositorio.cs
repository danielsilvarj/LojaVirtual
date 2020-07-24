using LojaVirtual.Dominio.Contratos;
using LojaVirtual.Dominio.Entidades;
using LojaVirtual.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LojaVirtual.Repositorio.repositorios
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(LojaVirtualContexto lojaVirtualContexto) : base(lojaVirtualContexto)
        {
        }

        public Usuario Obter(string email, string senha)
        {
            return LojaVirtualContexto.Usuarios.FirstOrDefault(u=> u.Email == email.ToString() && u.Senha == senha.ToString());
        }

        public Usuario Obter(string email)
        {
            return LojaVirtualContexto.Usuarios.FirstOrDefault(u => u.Email == email.ToString());
        }
    }
}
