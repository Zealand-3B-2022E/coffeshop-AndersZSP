using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    internal abstract class Coffee
    {

        private int _discount;


        public int Discount
        {
            get { return _discount; }
            set { _discount = value; }
        }

        public virtual int Price()
        {
            if(Discount < 6)
            {
                return 20 - Discount;
            }
            else
            {
                throw new ArgumentException("Discount is too big");
            }
        }

        public abstract string Strength();

        //public abstract string BlendType();

        public Coffee(int discount)
        {
            Discount = discount;
        }

        public override string ToString()
        {
            return $"pris = {Price()}DKK,\nStyrke = {Strength()}";
        }

    }
}
