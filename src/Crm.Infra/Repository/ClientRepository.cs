using Crm.ApplicationCore.Entity;
using Crm.ApplicationCore.Interface;
using Crm.Infra.Data;
using System;
using System.Collections.Generic;
using System.Text;


namespace Crm.Infra.Repository
{
    public class ClientRepository : EFRepository<Client>, IClientRepository
    {
        public ClientRepository(ClientContext dbContext) : base(dbContext)
        {

        }
        public Client obterNovosDados()
        {
            throw new NotImplementedException();
        }
    }
}
