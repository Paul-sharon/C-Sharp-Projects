using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    public class Mobile
    {
        public string brand;
        public string model;
        public int battery_level;
        public string phone_no;
        public Mobile(string brand, string model) 
        {
            this.brand = brand;
            this.model = model;
            this.battery_level = 75;
        }
        public void MakeCall(string phone_no)
        {
            Console.WriteLine("Phone no: "+phone_no);
        }
        public void ChargeBattery(int amount)
        {
            battery_level += amount;
            if (battery_level >= 100)
            {
                battery_level = 100;
            }
            Console.WriteLine("Battery level: "+battery_level);
        }
        public void UseBattery(int amount)
        {
            battery_level -= amount;
            if (battery_level <= 0)
            {
                battery_level = 0;
            }
            Console.WriteLine("Battery level: "+battery_level);
        }
        public void details()
        {
            Console.WriteLine("Brand: "+brand);
            Console.WriteLine("Model: "+model);
            Console.WriteLine("Batter level: "+battery_level);
        }
    }
}
