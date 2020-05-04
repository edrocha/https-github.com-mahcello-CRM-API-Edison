﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Crm.ApplicationCore.Interface
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Adicionar(TEntity entity);
        void Atualizar(TEntity entity);
        IEnumerable<TEntity> ObterTodos();
        TEntity  ObterpoID(int id);
        IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicado);
        void Remover(TEntity entity); 

    }
}
