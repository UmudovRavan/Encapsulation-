using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Tapsiriq_1
{
    public class Car
    {
       

        public int Id { get; set; }
        public string Name { get; set; }
        public double Speed { get; set; }

        public string CarCode { get; private set; }

       
        public Car (int id,string name,double speed,int carNumber)
        {
            Id = id;
            Name = name;
            Speed = speed;
            CarCode = ValueCarCode(name,carNumber);
        }
        public string ValueCarCode(string name,int carNumber)
        {

            return name.Substring(0,2).ToUpper() + (1000+carNumber).ToString();
        }

       
    }
}
