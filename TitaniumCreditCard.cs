using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class TitaniumCreditCard : ICreditCard
    {
        public string GetCardType()
        {
            return "Titanium";
        }
        public int GetCreditLimit()
        {
            return 30000;
        }
        public int GetAnnualCharge()
        {
            return 2500;
        }
    }
}
