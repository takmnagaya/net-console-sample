using System;

namespace net_console_sample
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Takumi Nagaya";
            Console.WriteLine($"Hello World, {name}");

            // Cast 明示的な型変換
            long m = 10;
            int i = (int)m;
            Console.WriteLine(i);

            // 文字列<->数値の変換
            Console.WriteLine(Int32.Parse("12"));
            Console.WriteLine(Single.Parse("1.34"));
            Console.WriteLine(Int32.Parse("FF", System.Globalization.NumberStyles.HexNumber));

            // nullでもエラーにならない
            string str = null;
            string unspace = str?.Trim();

            // null許容型
            int i2 = 109;
            int? num = i2;
            int i3 = (int)num;
            Console.WriteLine(i3);
            int? i4 = 1;
            Console.WriteLine(i4.HasValue);
        }
    }
}
