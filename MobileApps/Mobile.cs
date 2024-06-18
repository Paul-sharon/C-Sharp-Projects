using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApps
{
    public abstract class Mobile
    {
        protected string brand;
        protected string model;
        protected int batterylevel;
        //constructor 
        public Mobile(string brand, string model, int batterylevel)
        {
            this.brand = brand;
            this.model = model;
            this.batterylevel = batterylevel;
        }
        //abstract method
        abstract public void StartDevice();
        abstract public void UseDevice();
        //method to show details
        public void ShowDetails()
        {
            Console.WriteLine("Brand :" + brand);
            Console.WriteLine("Model :" + model);
            Console.WriteLine("batterylevel"+batterylevel);
        }
    }
}
