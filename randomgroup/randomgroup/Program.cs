using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomgroup
{
    class Program
    {
        static void Main(string[] args)
        { 
            // 班上所有人的名字
            string[] name = { "葉俊廷", "張澤瑜", "龘䶛䨻䎱㸞蚮䡶䴞䴝䯬䬛䰕㹚王程捷", "江儀婷", "張秉華", "陳柏霖", "黃紀瑜", "黃昱維", "蔡逸群", "登琳", "世新魏鈞孝吧", "劉定南", "陳信如", "童信傑", "李岳倫", "鄒和恆", "簡毓玟", "劉子瑄", "蕭紹洋", "李亞宸la", "張以潔", "邱仕紳", "呂家瑩", "世新林鑫佑", "徐均得", "陳佳欣", "張恩瑋 遊戲虛寶序號免費送ヾ(◎´・ω・｀)ノ", "周詮", "王湘婷", "蕭宇成", "張家銘", "馬嘉誠Σヽ(ﾟД ﾟ; )ﾉ魔貫光殺砲(ﾟДﾟ)σ━0000", "陳昱嘉", "康珈熏", "盧奕宏", "陳郁佳的大哥黃博涵", "遲正雯", "世新林星彤", "許晏誠ｘ勒是奇多＿８＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝Ｄ　", "許子安", "高子晴", "陳思婷", "矝鵘鮿", "余彥廷", "吳耀輝", "鄭丞智", "林冠廷", "世新何曜宇", "邵喬雨", "張豐愷", "林子晴", "邱雁回", "陳家欣是韓妞", "鄧雅馨", "謝汶珊", "李曼寧", "徐偉哲 錯誤代碼CB48", "張鈺慈", "鍾宜珊", "raer_tsai", "世新李姳諼", "鄭曼君", "陳柏霖", "世新許子安", "世新方若帆", "李曼寧", "世新張豐愷", "世新遲正雯", "世新周詮", "施 續保" };

            // 分配每組人數
            Console.WriteLine("請輸入每一組的人數,不可小於2或大於10");

            int teamPeople = int.Parse(Console.ReadLine());

            // 輸入有效數字
            if (teamPeople > 2 && teamPeople < 10)
            {
                // 分組迴圈執行次數
                int n = 1;

                // 亂數
                Random rand = new Random();

                // 放置全班名字
                List<string> nameList = new List<string>();

                for (int i = 0; i < name.Length; i++)
                {
                    nameList.Add(name[i]);
                }

                // 組別數量
                int TeamCount = nameList.Count / teamPeople;

                // 多出來的人數
                int redundantPeople = nameList.Count % teamPeople;

                // 設置另一個多出來的人數，以防多出來的人數都加入同一組
                int redundantP = redundantPeople;

                while (n <= TeamCount)
                {
                    Console.Write("第" + n + "組的人員有:  ");

                    for (int i = 0; i < teamPeople; i++)
                    {
                        if (redundantPeople > 0 && redundantP == redundantPeople)
                        {
                            int j = rand.Next(0, nameList.Count);
                            Console.Write(nameList[j] + " ");
                            nameList.RemoveAt(j);
                            redundantPeople--;
                        }
                        int k = rand.Next(0, nameList.Count);
                        Console.Write(nameList[k] + " ");
                        nameList.RemoveAt(k);
                    }
                    redundantP--;
                    Console.WriteLine("");
                    n++;
                }
            }

            // 輸入無效數字
            else
            {
                Console.WriteLine("你輸入了無效數字");
            }
                
          Console.ReadLine();
            
        }
    }
}
