using System;
using System.Collections.Generic;

namespace kensan
{
    class Sample
    {
        public static void ShowWeights()
        {
            // リストの初期化はインラインで行ってもいい感じだよ！作ってからAddするってより、初期化時にぶちこんでしまうイメージだね。
            // 型は慣れてきたらvarが推奨だよ！右辺色々編集した時に面倒臭くならなくていい感じだよ！
            var weights = new List<float> {41.2f, 42.5f, 44.9f, 43.2f};

            // せっかくリスト使っているので、forEachってメソッド使うといいよ！
            // リストの各要素に対して、指定した挙動を実行するよ。この場合、weightsの全てに対してConsole.WriteLineを実行するよ！
            weights.ForEach(Console.WriteLine);
        }
    }
}