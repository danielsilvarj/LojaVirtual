using LojaVirtual.Dominio.Contratos;
using LojaVirtual.Dominio.Entidades;
using LojaVirtual.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace LojaVirtual.Repositorio.repositorios
{
    public class ProdutoRepositorio : BaseRepositorio<Produto>, IProdutoRepositorio
    {
        public ProdutoRepositorio(LojaVirtualContexto lojaVirtualContexto) : base(lojaVirtualContexto)
        {

        }
    }
}
