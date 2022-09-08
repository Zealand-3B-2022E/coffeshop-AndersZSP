using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    internal abstract class Coffee
    {

        public virtual int Price()
        {
            return 20;
        }

        public abstract string Strength();  
        //private int _price;
        //private string _strength;
        //private int _discount;

        //public int Price
        //{
        //    get { return _price; }
        //    set { _price = value; }
        //}
        //public string Strength
        //{
        //    get { return _strength; }
        //    set { _strength = value; }
        //}
        //public int Discount
        //{
        //    get { return _discount; }
        //    set { _discount = value; }
        //}


        //public int CoffeePrice()
        //{
        //    return _price;
        //}
    }
}
