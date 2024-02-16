namespace string_interpolation
{
    public class Program
    {
        public static void Main()
        {
            var date = new DateTime(2019, 1, 22);
            var pi = Math.PI;


            Console.WriteLine($"{date,40}");


            Console.WriteLine($"{date:yyyy.MM.dd}");


            Console.WriteLine($"Day {date:dd} of {date:MMMM}, {date:yyyy}");

            Console.WriteLine($"Year: {date:yyyy}, Month: {date:MM}, Day: {date:dd}");

            Console.WriteLine($"{date.DayOfWeek,10}");

            Console.WriteLine($"{date:h:mm tt,10} {date.DayOfWeek,10}");

            Console.WriteLine($"h:{date:HH}, m:{date:mm}, s:{date:ss}");

            Console.WriteLine($"{date:yyyy.MM.dd.HH.mm.ss}");

            Console.WriteLine($"{pi:C}");

            Console.WriteLine($"{pi,10:F3}");

            Console.WriteLine($"Year in hexadecimal: {Number11.GetHexadecimalYear()}");
        }
    }

    public interface Number11
    {
        public static string GetHexadecimalYear()
        {
            var date = new DateTime(2019, 1, 22);
            return $"{date.Year:X}";
        }
    }
}
