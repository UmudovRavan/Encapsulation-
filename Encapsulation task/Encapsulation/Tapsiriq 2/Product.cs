using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Tapsiriq_2
{
    public class Product
    {
        private double _price;
        private int _count;
        public int Id { get; set; }
        public string Name { get; set; }

        public double Price
        {
            get { return _price; }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
                else
                {
                    _price = 0;
                }
                    
            }
        }
        public int Count
        {
            set
            {
                if( value > 0)
                {
                    _count = value;
                }
                else
                {
                    _count = 0;
                }
            }
        }

        public Product(int id,string name,double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }
}
