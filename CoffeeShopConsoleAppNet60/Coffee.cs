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
            return 20;
        }

        public abstract string Strength();


        protected Coffee(int discount)
        {
            Discount = discount;
        }





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
