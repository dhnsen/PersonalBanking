using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBanking.Models.Bank
{
    interface ITransaction
    {
        String Id { get; set; }
        Decimal Amount { get; set; }
        String Date { get; set; }
        String Category { get; set; }
        String Description { get; set; }
        String Status { get; set; }



    }
}
