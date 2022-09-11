using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    internal class FlatWhite : Coffee
    {
        public FlatWhite(int discount) : base(discount)
        {
            Discount = discount;
        }

        public int mlMilk()
        {
            return 400;
        }

        public override int Price()
        {
            return 60 - Discount;
        }

        public override string Strength()
        {
            return "Weak";
        }
    }
}
