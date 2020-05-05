using Crm.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Crm.ApplicationCore.Services
{
    interface IClientService
    {
        Client Adicionar(Client entity);
        void Atualizar(Client entity);
        IEnumerable<Client> ObterTodos();
        Client ObterpoID(int id);
        IEnumerable<Client> Buscar(Expression<Func<Client, bool>> predicado);
        void Remover(Client entity);
    }
}
