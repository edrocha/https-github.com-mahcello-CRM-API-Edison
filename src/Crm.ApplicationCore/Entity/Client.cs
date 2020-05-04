using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Crm.ApplicationCore.Entity
{
    public class Client
    {
        
        public Client() 
            {

            }
        
        [Key]
        public int cliID { get; set; }

        public string cliNome { get; set; }

        public string cliEmail { get; set; }

        public DateTime cliData { get; set; }

        public int cliSexo { get; set; }

        public Boolean cliAtivo { get; set; }
    }
}
