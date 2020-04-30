using System;
using System.Collections.Generic;
using System.Text;

namespace Crm.ApplicationCore.Entity
{
    class Client
    {
        public Client() 
            {

            }

        public int cliID { get; set; }

        public string cliNome { get; set; }

        public string cliEmail { get; set; }

        public DateTime cliData { get; set; }

        public int cliSexo { get; set; }

        public Boolean cliAtivo { get; set; }
    }
}
