namespace MobileApps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int batterylevel;
            String model, brand;
            Console.WriteLine("Enter the model");
            model=Console.ReadLine();
            Console.WriteLine("Enter the brand");
            brand = Console.ReadLine(); 
            Console.WriteLine("Enter the batterylevel");
            batterylevel= int.Parse(Console.ReadLine());
            Mobile m=new Mobile(model,brand,batterylevel);
        }
    }
}
