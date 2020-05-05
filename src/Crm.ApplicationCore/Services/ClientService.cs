using Crm.ApplicationCore.Entity;
using Crm.ApplicationCore.Interface;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Crm.ApplicationCore.Services
{
    class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;
        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
        public Client Adicionar(Client entity)
        {
            //TODO Adicionar regrade negocio

            return _clientRepository.Adicionar(entity);
        }

        public void Atualizar(Client entity)
        {
            _clientRepository.Atualizar(entity);
        }

        public IEnumerable<Client> Buscar(Expression<Func<Client, bool>> predicado)
        {
            return _clientRepository.Buscar(predicado);
        }

        public Client ObterpoID(int id)
        {
            return _clientRepository.ObterpoID(id);
        }

        public IEnumerable<Client> ObterTodos()
        {
            return _clientRepository.ObterTodos();
        }

        public void Remover(Client entity)
        {
            _clientRepository.Remover(entity);
        }
    }
}
