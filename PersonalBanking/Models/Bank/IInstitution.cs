using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBanking.Models.Bank
{
    interface IInstitution
    {
        String Id { get; set; }
        String Name { get; set; }
        String Url { get; set; }
    }
}
