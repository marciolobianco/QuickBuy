using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Interfaces
{
   public interface IBaseRepositorio<TEntity>: IDisposable where TEntity : class
    {
        void Adicionar(TEntity entity);
        TEntity ObterPorId(int id);
        IEnumerable<TEntity> ObterTodos();
        void Atualizar(TEntity entity);
        void Remover(int id);
    }
}
