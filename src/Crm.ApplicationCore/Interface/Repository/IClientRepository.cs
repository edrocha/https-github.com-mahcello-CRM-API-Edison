using Crm.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Crm.ApplicationCore.Interface
{
    public interface IClientRepository : IRepository<Client> 
    {
        //Aqui metodos fora da padrão, novos metodos
        Client obterNovosDados();

    }
}
