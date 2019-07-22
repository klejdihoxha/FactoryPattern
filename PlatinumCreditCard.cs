using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class PlatinumCreditCard : ICreditCard
    {
        public string GetCardType()
        {
            return "Platinum";
        }
        public int GetCreditLimit()
        {
            return 45000;
        }
        public int GetAnnualCharge()
        {
            return 3000;
        }
    }
}
