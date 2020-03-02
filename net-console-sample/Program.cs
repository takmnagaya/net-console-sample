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

            // 配列の宣言
            int[] data = new int[5];
            Console.WriteLine(data[0]);
            int[] array = { 1, 2, 3, 4 };
            Console.WriteLine(array[0]);
            var array2 = new[] { 1, 2, 3 };
            Console.WriteLine(array2[0]);
            // 後から要素を追加、削除するような可変の配列を表現するにはListクラスを利用する
            int[,] array3 = new int[3, 3];
            // 多次元配列の場合はarray[0][0]ではなくarray[0,0]で要素にアクセスする
            Console.WriteLine(array3[0, 1]);

            // ジャグ配列
            int[][] jagged = new int[3][];
            jagged[0] = new int[2];
            jagged[1] = new int[3];
            jagged[2] = new int[4];
            var jagged2 = new int[3][];
            jagged2[0] = new[] { 1, 2, 3 };
            jagged2[1] = new[] { 1, 2, 3, 4, 5 };
            jagged2[2] = new[] { 1 };
            // VsVim does not work code snippet...
            // so that jagged array is not multidimansional array, do not use jagged2[0, 1]
            Console.WriteLine(jagged2[0][0]);
            Console.WriteLine(jagged2.Rank); // returns 1
        }
    }
}
