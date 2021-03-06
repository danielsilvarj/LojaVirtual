﻿using LojaVirtual.Dominio.Contratos;
using LojaVirtual.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LojaVirtual.Repositorio.repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {

        protected readonly LojaVirtualContexto LojaVirtualContexto;

        
        public BaseRepositorio(LojaVirtualContexto lojaVirtualContexto)
        {
            LojaVirtualContexto = lojaVirtualContexto;

        }

        public void Adicionar(TEntity entity)
        {
            LojaVirtualContexto.Set<TEntity>().Add(entity);
            LojaVirtualContexto.SaveChanges();


        }

        public void Atualizar(TEntity entity)
        {
            LojaVirtualContexto.Set<TEntity>().Update(entity);
            LojaVirtualContexto.SaveChanges();
        }

        public void Dispose()
        {
            LojaVirtualContexto.Dispose();
        }

        public TEntity ObterPorId(int id)
        {
            return LojaVirtualContexto.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return LojaVirtualContexto.Set<TEntity>().ToList();
        }

        public void Remover(TEntity entity)
        {
            LojaVirtualContexto.Remove(entity);
            LojaVirtualContexto.SaveChanges();
        }
    }
}
