namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            redmi r=new redmi("Redmi", "note 7 pro");
            r.details();
            r.charge(100);
            r.usage(50);
            Console.WriteLine("Enter the number to call: ");
            string number = Console.ReadLine();
            r.makeCall(number);
            Console.ReadLine();
        }
    }
}
