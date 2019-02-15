using System;

namespace C {
    class Program {
        static void Main(string[] args) {
            /*
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
            Console.WriteLine("--------------");
            */
            Console.WriteLine("あなたのお名前を教えてね");
            string YourName = Console.ReadLine();
            Console.WriteLine("あなたの名前は" + YourName + "です。合ってますか？");
            string okng = Console.ReadLine();
            if(okng == "はい"){
                Console.WriteLine("よかった。安心しました！");
            }else{
                Console.WriteLine("もう一度お名前をお聞きします。");
                Console.WriteLine("あなたの名前はなんですか？");
                string ReYourName = Console.ReadLine();
                Console.WriteLine("あなたの名前は" + ReYourName + "です。もう知りません。");
            }
        }
    }
}