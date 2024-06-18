using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class redmi
    {
        String name;
        String model;
        int Battery;
        public redmi(String name,String model)
        {
            this.name = name;
            this.model = model;
            Battery = 0;
        }
        public void details()
        {
            Console.WriteLine("Brand : " + name);
            Console.WriteLine("Model :" + model);
        }
        public void charge(int amt)
        {
            if (amt >= 100)
            {
                Battery = 100;
                Console.WriteLine("Your battery is full " + Battery);
            }  
            else
            {
                Battery = amt;
                Console.WriteLine(Battery);
            } 
        }
        public void usage(int amt)
        {
            if (amt <= 0)
            {
                Battery = 0;
                Console.WriteLine("Your battery is low " + Battery);
            }
            else
            {
                Battery -= amt;
                Console.WriteLine(Battery);
            }
        }
        public void makeCall(string num)
        {
            Console.WriteLine(num +" Calling" );
            Console.WriteLine("Press y to take or n to cancel");
            String attend=Console.ReadLine();
        }

    }
}
