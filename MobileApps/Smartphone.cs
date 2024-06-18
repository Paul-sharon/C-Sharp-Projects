using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApps
{
    public class Smartphone : Mobile
    {
        public Smartphone(string brand, string model, int batterylevel)
        {
            this.brand = brand;
            this.model = model;
            this.batterylevel = batterylevel;
        }
        override public void StartDevice()
        {
            Console.WriteLine("Inside Start Device");
        }
        public override void UseDevice()
        {
            Console.WriteLine("Inside use device");
        }
    }
}
