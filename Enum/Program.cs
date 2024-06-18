namespace Enum
{
    public class Program
    {
        public enum Days
        {
            sunday,
            monday,
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday
        }
        static void Main(string[] args)
        {
            Days today = Days.wednesday;
            switch (today)
            {
                case Days.sunday:
                    Console.WriteLine("sunday");
                    break;
                case Days.monday:
                    Console.WriteLine("monday");
                    break;
                case Days.tuesday:
                    Console.WriteLine("tuesday");
                    break;
                case Days.wednesday:
                    Console.WriteLine("wednesday");
                    break;
                case Days.thursday:
                    Console.WriteLine("thurday");
                    break;
                case Days.friday:
                    Console.WriteLine("thursday");
                    break;
                default: Console.WriteLine("Not a day");
                    break;
            }
        }
    }
}
