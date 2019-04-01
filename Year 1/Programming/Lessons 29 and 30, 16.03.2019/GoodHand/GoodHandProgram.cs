using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodHand
{
    class GoodHandProgram
    {
        static void Main(string[] args)
        {
            var playersInfo = new Dictionary<string, List<string>>();

            while (true)
            {
                string[] cards = Console.ReadLine().Split(' ', ':', ',').Where(x => x != "").Distinct().ToArray();
                if (cards[0].Equals("JOKER")) break;

                if (playersInfo.ContainsKey(cards[0])) playersInfo[cards[0]].AddRange(cards.Skip(1));
                else playersInfo.Add(cards[0], cards.Skip(1).ToList());
            }

            var tempDic = new Dictionary<string, List<string>>(playersInfo);
            foreach (var pair in tempDic)
            {
                playersInfo[pair.Key] = playersInfo[pair.Key].Distinct().ToList();
            }

            foreach(var pair in playersInfo)
            {
                int value = 0;

                for (int i = 0; i < pair.Value.Count; i++)
                {
                    int card = 0;

                    if (playersInfo[pair.Key][i][0].Equals('J')) card = 11;
                    else if (playersInfo[pair.Key][i][0].Equals('Q')) card = 12;
                    else if (playersInfo[pair.Key][i][0].Equals('K')) card = 13;
                    else if (playersInfo[pair.Key][i][0].Equals('A')) card = 14;
                    else if (playersInfo[pair.Key][i][0].Equals('1')) card = 10;
                    else card = int.Parse(playersInfo[pair.Key][i].First().ToString());

                    var temp = playersInfo[pair.Key][1];

                    if (playersInfo[pair.Key][i].Last().Equals('S')) card *= 4;
                    else if (playersInfo[pair.Key][i].Last().Equals('H')) card *= 3;
                    else if (playersInfo[pair.Key][i].Last().Equals('D')) card *= 2;
                    else card *= 1;

                    value += card;
                }
                playersInfo[pair.Key].Add(value.ToString());

            }

            foreach (var pair in playersInfo)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value.Last()}");
            }
        }
    }
}
