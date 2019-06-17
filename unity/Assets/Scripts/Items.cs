using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public static class Items 
{
    static List<ItemData> items = new List<ItemData>();

    public static void CreateItem() {
        items.Add(new ItemData(1, "サーロイン", 1300, "きめが細かく、柔らかい背中部分。", "meat"));
        items.Add(new ItemData(2, "リブロース", 1100, "牛肉の中では最も厚みのある部分。", "meat"));
        items.Add(new ItemData(3, "肩ロース", 1000, "肩にあるロース部位で柔らかな肉質が特徴です。", "meat"));
        items.Add(new ItemData(4, "ヒレ", 1500, "他の部位に比べてかなり柔らかい肉質。", "meat"));
        items.Add(new ItemData(5, "バラ肉", 500, "肉じゃがや焼き豚などにもおすすめ。", "meat"));
        items.Add(new ItemData(6, "ロース", 1000, "きめが細かく適度に脂がのっているのが特徴です", "meat"));
        items.Add(new ItemData(7, "サザエ", 400, "旬のさざえをつぼ焼きにして、磯の風味を\n心ゆくまでお楽しみください。", "fish"));
        items.Add(new ItemData(8, "岩がき", 550, "丸みのあるゴツゴツの殻を開ければ、\nぷっくり太った大きな身。", "fish"));
        items.Add(new ItemData(9, "ホタテ", 150, "甘くて肉厚なホタテ、\nバター焼きにぴったり。", "fish"));
        items.Add(new ItemData(10, "イカ", 500, "これを選んだあなた！イカすねぇ！", "fish"));
        items.Add(new ItemData(11, "マグロ", 1850, "バーベキューを盛り上げ、参加者に\n歓声を上げさせるならコレ。", "fish"));
        items.Add(new ItemData(12, "玉ねぎ", 180, "バーベキューに欠かせない野菜1位", "vegetable"));
        items.Add(new ItemData(13, "ピーマン", 150, "独特の食感や風味を楽しむ", "vegetable"));
        items.Add(new ItemData(14, "じゃがいも", 200, "アウトドアで食べると美味しさもひときわ。", "vegetable"));
        items.Add(new ItemData(15, "フランスパンのガーリック\nトースト", 150, "ニンニクの香ばしい香りに\nフランスパンの食感が癖になる。", "neta"));
        items.Add(new ItemData(16, "焼きタラバガニ", 300, "お肉に飽きたらこれ！\n半解凍にして焼けば旨みが増す。", "neta"));
        items.Add(new ItemData(17, "バームクーヘン", 250, "焼くのに時間が掛かるが焦げ目がいい感じに\n焼ければもう買わずにはいられない。", "neta"));
        items.Add(new ItemData(18, "網焼きマシュマロ", 150, "簡単な上にかなり美味しいので買って損なし。", "neta"));
        items.Add(new ItemData(19, "焼きフルーツ", 250, "水分が飛び旨みが凝縮して\n新たなフルーツの扉が開かれる。", "neta"));
        items.Add(new ItemData(20, "トマト", 80, "お肉やチーズなどと相性が抜群で、様々な\nバーベキューレシピに\n活用できる便利な食材。", "neta"));
        items.Add(new ItemData(21, "ライスバーガー", 150, "ご飯に合う具材を挟んでおにぎりの要領で網焼き。", "neta"));
        items.Add(new ItemData(22, "マッシュルーム", 3, "オーストラリアで定番食材。", "neta"));
        items.Add(new ItemData(23, "炭", 1000, "よくもえる", "other"));
        items.Add(new ItemData(24, "着火剤", 1000, "ふぁいやぁー", "other"));
        items.Add(new ItemData(25, "サンマ", 100, "焼き上げたさんまは格別で、お肉はちょっと苦手...\nという女性にもうける。", "fish"));
        items.Add(new ItemData(26, "鮭", 300, "海鮮バーベキューでは主役級の食材", "fish"));
        items.Add(new ItemData(27, "鯛", 350, "ちょっと豪勢に演出するならコレ。", "fish"));
        items.Add(new ItemData(28, "カニ", 280, "甘くて薫り高いホクホクの身\nはタラバガニならではの食味で忘れられない体験になるはず。", "fish"));
        items.Add(new ItemData(29, "あさり", 100, "アサリ、貝である事を\n朝、理解。", "fish"));
        items.Add(new ItemData(30, "ビア缶チキン", 300, "スパイスとハーブのコンビは最強かもしれない。", "neta"));
        items.Add(new ItemData(31, "ナス", 100, "炭火で素焼きにするだけで、\nとても美味しくなる焼き野菜\nの定番といえば茄子。", "neta"));
        items.Add(new ItemData(32, "キャベツ", 200, "ホイル焼きやホットサンドなどバーベキューで人気の調理法にもよく合う。", "vegetable"));
        items.Add(new ItemData(33, "ニンジン", 190, "蒸し焼きにするのがおすすめ。", "vegetable"));
        items.Add(new ItemData(34, "カボチャ", 250, "ホイル焼きで調理するのが無難だ。", "vegetable"));
        items.Add(new ItemData(35, "長いも", 230, "炙る程度に仕上げれば\nシャキシャキとした食感が楽しめる。", "vegetable"));
        items.Add(new ItemData(36, "たけのこ", 120, "皮付きのままのタケノコの丸焼き。\n普段の味わいとは別物のため\n思い出に残ること間違いなし。", "vegetable"));
        items.Add(new ItemData(37, "スペアリブ", 1000, "かぶりついて食べるダイナミックな\n食べ方もバーベキューならでは。", "meat"));
        items.Add(new ItemData(38, "むね", 400, "淡白な味わいと脂肪の少ないヘルシーさが特徴の部位。", "meat"));
        items.Add(new ItemData(39, "手羽", 200, "骨まわりの濃厚な味が楽しめるのが魅力です。", "meat"));
        items.Add(new ItemData(40, "もも", 100, "よく焼いてもパサつきにくく、ふっくら\n仕上げやすいので初心者におすすめ。", "meat"));
    }

    public static List<ItemData> GetData(){
        return items;
    }


    public static ItemData GetItem(int _id) {
        return items.Where(x => x.id == _id).First();
    }

    public static List<ItemData> GetItemTag(string _tag) {
        var query = items.Where(x => x.tag == _tag);
        List<ItemData> data = new List<ItemData>();
        foreach (var item in query) {
            data.Add(item);
        }
        return data;
    }
}
