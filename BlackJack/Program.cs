using System;
using System.Collections.Generic;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Card> poker = new List<Card>();
            poker.Add(new Card("ハートの1", 1));
            poker.Add(new Card("ハートの2", 2));
            poker.Add(new Card("ハートの3", 3));
            poker.Add(new Card("ハートの4", 4));
            poker.Add(new Card("ハートの5", 5));
            poker.Add(new Card("ハートの6", 6));
            poker.Add(new Card("ハートの7", 7));
            poker.Add(new Card("ハートの8", 8));
            poker.Add(new Card("ハートの9", 9));
            poker.Add(new Card("ハートの10", 10));
            poker.Add(new Card("ハートのJ", 10));
            poker.Add(new Card("ハートのQ", 10));
            poker.Add(new Card("ハートのK", 10));
            poker.Add(new Card("ハートのA", 1));
            poker.Add(new Card("スペードの1", 1));
            poker.Add(new Card("スペードの2", 2));
            poker.Add(new Card("スペードの3", 3));
            poker.Add(new Card("スペードの4", 4));
            poker.Add(new Card("スペードの5", 5));
            poker.Add(new Card("スペードの6", 6));
            poker.Add(new Card("スペードの7", 7));
            poker.Add(new Card("スペードの8", 8));
            poker.Add(new Card("スペードの9", 9));
            poker.Add(new Card("スペードの10", 10));
            poker.Add(new Card("スペードのJ", 10));
            poker.Add(new Card("スペードのQ", 10));
            poker.Add(new Card("スペードのK", 10));
            poker.Add(new Card("スペードのA", 1));
            poker.Add(new Card("ダイヤの1", 1));
            poker.Add(new Card("ダイヤの2", 2));
            poker.Add(new Card("ダイヤの3", 3));
            poker.Add(new Card("ダイヤの4", 4));
            poker.Add(new Card("ダイヤの5", 5));
            poker.Add(new Card("ダイヤの6", 6));
            poker.Add(new Card("ダイヤの7", 7));
            poker.Add(new Card("ダイヤの8", 8));
            poker.Add(new Card("ダイヤの9", 9));
            poker.Add(new Card("ダイヤの10", 10));
            poker.Add(new Card("ダイヤのJ", 10));
            poker.Add(new Card("ダイヤのQ", 10));
            poker.Add(new Card("ダイヤのK", 10));
            poker.Add(new Card("ダイヤのA", 1));
            poker.Add(new Card("クラブの1", 1));
            poker.Add(new Card("クラブの2", 2));
            poker.Add(new Card("クラブの3", 3));
            poker.Add(new Card("クラブの4", 4));
            poker.Add(new Card("クラブの5", 5));
            poker.Add(new Card("クラブの6", 6));
            poker.Add(new Card("クラブの7", 7));
            poker.Add(new Card("クラブの8", 8));
            poker.Add(new Card("クラブの9", 9));
            poker.Add(new Card("クラブの10", 10));
            poker.Add(new Card("クラブのJ", 10));
            poker.Add(new Card("クラブのQ", 10));
            poker.Add(new Card("クラブのK", 10));
            poker.Add(new Card("クラブのA", 1));

            Random random;
            int count;
            int you = 0;
            int pc = 0;

            bool flag = true;
            bool endFlag = false;

            void check()
            {
                if (you > 21)
                {
                    Console.WriteLine("私の勝ちです。なぜ負けたのか考えてください。");
                    flag = false;
                    endFlag = true;
                    return;

                }
                if (pc>21)
                {
                    Console.WriteLine("あなたが勝ちました。");
                    flag = false;
                    endFlag = true;
                    return;
                }
            }

            Card draw(List<Card> poker)
            {
                random = new Random();
                count = random.Next(poker.Count);
                return poker.Find(c => poker.IndexOf(c) == count);
                
            }
            Console.WriteLine("ゲームを開始します");
            Card card1;
            card1 = draw(poker);
            Console.WriteLine("あなたは{0}をひいた。", card1.getCardName());
            you += card1.getPoint();
            poker.RemoveAt(count);

            card1 = draw(poker);
            Console.WriteLine("あなたは{0}をひいた。", card1.getCardName());
            poker.RemoveAt(count);
            you += card1.getPoint();

            card1 = draw(poker);
            Console.WriteLine("pcは{0}をひいた。", card1.getCardName());
            poker.RemoveAt(count);
            pc += card1.getPoint();

            card1 = draw(poker);
            string second = card1.getCardName();
            Console.WriteLine("pcは秘密をひいた。");
            poker.RemoveAt(count);
            pc += card1.getPoint();

            Console.WriteLine("得点はあなた:{0}", you);

            /*foreach (var card in poker)
            {
                Console.WriteLine(card.getCardName());
            }*/

            

            while(flag)
            {
                Console.WriteLine("引くか？Y/N");
                String choose = Console.ReadLine();
                if (choose == "N")
                {
                    break;
                }
                card1 = draw(poker);
                Console.WriteLine("あなたは{0}をひいた。", card1.getCardName());
                you += card1.getPoint();
                poker.RemoveAt(count);
                Console.WriteLine("得点はあなた:{0}", you);
                check();
            }

            Console.WriteLine("pc2枚目のカードは{0}", second);
            Console.WriteLine("pcの得点は:{0}", pc);

            while (endFlag == false)
            {
                

                while (pc < 17)
                {
                    card1 = draw(poker);
                    Console.WriteLine("pcは{0}をひいた。", card1.getCardName());
                    poker.RemoveAt(count);
                    pc += card1.getPoint();
                    Console.WriteLine("得点はあなた:{0}、pc:{1}", you, pc);
                    check();
                }


                if (pc>=17&&pc<22)
                {
                    if (you > pc)
                    {
                        Console.WriteLine("あなたの勝ち。");
                        flag = false;
                        return;
                    }
                    else if (pc > you)
                    {
                        Console.WriteLine("私の勝ち。");
                        flag = false;
                        return;
                    }
                    else
                    {
                        Console.WriteLine("勝者はいない。");
                        flag = false;
                        return;
                    }
                }

                
            }

            




        }
    }
}
