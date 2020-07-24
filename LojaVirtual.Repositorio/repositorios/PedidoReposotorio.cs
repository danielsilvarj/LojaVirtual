using LojaVirtual.Dominio.Contratos;
using LojaVirtual.Dominio.Entidades;
using LojaVirtual.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace LojaVirtual.Repositorio.repositorios
{
    public class PedidoReposotorio : BaseRepositorio<Pedido>, IPedidoRepositorio
    {
        public PedidoReposotorio(LojaVirtualContexto lojaVirtualContexto) : base(lojaVirtualContexto)
        {
        }
    }
}
