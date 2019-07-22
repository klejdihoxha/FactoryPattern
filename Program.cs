using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int cardType = 1;

            ICreditCard cardDetails = CardFactory.GetCardInstance(cardType);
            if (cardDetails != null)
            {
                Console.WriteLine("Card Type : " + cardDetails.GetCardType());
                Console.WriteLine("Credit Limit : " + cardDetails.GetCreditLimit());
                Console.WriteLine("Annual Charge : " + cardDetails.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid!");
            }
            Console.ReadLine();
        }
    }
}
