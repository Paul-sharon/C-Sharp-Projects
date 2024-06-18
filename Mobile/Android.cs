using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Mobile
{
    interface iCamera
    {
        public void TakePhoto();
    }
    interface iGPS
    {
        public void GetLocation();
    }
    public class Android:Mobile
    {
        public string os_version;
        public Android(string brand,string model,string os_version):base(brand,model)
        {
            this.brand = brand;
            this.model = model;
            this.os_version=os_version;
        }
        public void get_os()
        {
            Console.WriteLine("OS Version: " + os_version);
        }
        public void TakePhoto()
        {
            Console.WriteLine("Photo: Taken");
        }
        public void GetLocation()
        {
            Console.WriteLine("Location: Kannur");
        }
    }
}
