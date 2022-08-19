using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoanManagement.Models
{
    public class Furniture
    {
        [Key]
        public int id { get; set; }
        public string providerName { get; set; }
        public string loanName { get; set; }
        public string LoanSanctionedDate { get; set; }
        public string amount { get; set; }
    }
}
