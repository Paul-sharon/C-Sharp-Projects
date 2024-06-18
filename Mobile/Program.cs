using System.Runtime.InteropServices;

namespace Mobile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mobile mb = new Mobile("Samsung", "A34");
            Android ad = new Android("Samsung", "A34", "Android 12");
            ad.ChargeBattery(50);
            ad.MakeCall("7306851606");
            ad.UseBattery(50);
            ad.details();
            ad.get_os();
            ad.TakePhoto();
            ad.GetLocation();
            Console.ReadLine();
        }
    }
}
