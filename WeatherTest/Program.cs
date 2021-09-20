using System;

namespace WeatherTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = "山东 青岛";
            var ss = Meow.Weather.CN.Interpreter.RectifyWord(s.Split(' ')).GetAwaiter().GetResult();
            Console.WriteLine(ss);
        }
    }
}
