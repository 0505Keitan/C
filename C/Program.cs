using System;

namespace C {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            Console.WriteLine(1 + 1);
            Console.WriteLine("初めてのC#スクリプトを書いたよ！");
            int x = 0;
            string moji = "Hello, World";
            Console.WriteLine(x);
            Console.WriteLine(moji);
            moji = "こんにちは、 世界。";
            Console.WriteLine(moji);
            // 楽しい！
            int[] data = new int[5];
            data[0] = 5;
            data[1] = 4;
            data[2] = 3;
            Console.WriteLine(data[0]);
            String[] emoji = {"あああ", "いいい"};
            Console.WriteLine(emoji[0]);
        }
    }
}