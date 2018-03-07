using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace p03_StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int nmbrMssgs = int.Parse(Console.ReadLine());
            string[] arrStrings = new string[nmbrMssgs];
            var dctnrReadMssg = new Dictionary<char, List<MessageDecrypted>>();
            for (int i = 0; i < nmbrMssgs; i++)
            {
                ReadMessage(arrStrings, i);
            }
            for (int i = 0; i < nmbrMssgs; i++)
            {
                ExtractMessageInfo(arrStrings[i], dctnrReadMssg);
            }
            bool foundAtacked = dctnrReadMssg.TryGetValue('A', out List<MessageDecrypted> planetsLsAttacked);
            if (foundAtacked)
            {
                Console.WriteLine($"Attacked planets: { planetsLsAttacked.Count}");
               
                var listDstrd2 = new List<string>();
                foreach (MessageDecrypted itemDstrPlnt in planetsLsAttacked)
                {
                    listDstrd2.Add(itemDstrPlnt.PlanetName);
                }
                var listDstrdls1 = listDstrd2.OrderBy(x => x);
                foreach (var item in listDstrdls1)
                {
                    Console.WriteLine($"-> {item}");
                }
            }
            else
                Console.WriteLine($"Attacked planets: 0");
            bool foundDestroyed = dctnrReadMssg.TryGetValue('D', out List<MessageDecrypted> planetsLsDstrd);
            if (foundDestroyed)
            {
                Console.WriteLine($"Destroyed planets: {planetsLsDstrd.Count}");
                
                var listDstrd = new List<string>();
                foreach (MessageDecrypted itemDstrPlnt in planetsLsDstrd)
                {
                    listDstrd.Add(itemDstrPlnt.PlanetName);
                }
                var listDstrdls = listDstrd.OrderBy(x => x);
                foreach (var item in listDstrdls)
                {
                    Console.WriteLine($"-> {item}");
                }
            }
            else
                Console.WriteLine($"Destroyed planets: 0");
            
        }

        static void ExtractMessageInfo(string dcrptdLine, Dictionary<char, List<MessageDecrypted>> dctnrReadMssg)
        {
            string[] strArrPlnt = dcrptdLine.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string regexPlntNmane = @"([@][A-Za-z]+)";
            MatchCollection plnt = Regex.Matches(strArrPlnt[0], regexPlntNmane);
            string regexPopul = @"[0-9]+";
            MatchCollection popultn = Regex.Matches(strArrPlnt[1], regexPopul);
            string hlp = strArrPlnt[1];
            string regexAtack = @"([\!A|D\!])";
            MatchCollection atack_coll = Regex.Matches(hlp, regexAtack);
            string regexSoldiers = @"(([-][>])[0-9]+)";
            MatchCollection sldiers = Regex.Matches(strArrPlnt[1], regexSoldiers);
            if (sldiers.Count == 0)
            {
                return;
            }

            string sldiersPlanet = sldiers[0].Value;
            sldiersPlanet = sldiersPlanet.Trim('-');
            sldiersPlanet = sldiersPlanet.Trim('>');
            int sldPlnt = int.Parse(sldiersPlanet);

            if (plnt.Count==0)
            {
                return;
            }
            string planetStr = plnt[0].Value;
            planetStr = planetStr.Trim('@');
            if (popultn.Count == 0)
            {
                return;
            }
            int popPlanet = int.Parse(popultn[0].Value);
            string atack_chr = "";
            foreach (Match item in atack_coll)
            {
                if (item.Value=="A"|item.Value=="D")
                {
                    atack_chr += item.Value;
                    break;
                }
            }
            if (atack_chr=="")
            {
                return;
            }
            char attacChar = atack_chr[0];
            var msgDcrptd = new MessageDecrypted();
            msgDcrptd.PlanetName = planetStr;
            msgDcrptd.AttakType = attacChar;
            msgDcrptd.Population = popPlanet;
            msgDcrptd.SoldierCount = sldPlnt;
            bool found = dctnrReadMssg.TryGetValue(attacChar, out List<MessageDecrypted> planetsLs);
            if (found)
            {
                bool foundPlanet = false;
                foreach (var itemPlnt in planetsLs)
                {
                    if (itemPlnt.PlanetName.Equals(planetStr))
                    {
                        foundPlanet = true;
                        break;
                    }
                }
                if (!foundPlanet)
                {
                    planetsLs.Add(msgDcrptd);

                }
            }
            else
            {
                planetsLs = new List<MessageDecrypted>();
                planetsLs.Add(msgDcrptd);
                dctnrReadMssg[attacChar] = planetsLs;
            }
        }

        static void ReadMessage(string[] arrStrings, int indxCrrnt)
        {
            string input_str = Console.ReadLine();
            string input_tmp = input_str.ToLower();
            int countKeySymbols = 0;
            for (int i = 0; i < input_str.Length; i++)
            {
                if ("star".Contains(input_tmp[i]))
                {
                    countKeySymbols++;
                }
            }
            input_tmp = "";
            for (int i = 0; i < input_str.Length; i++)
            {
                int chrNmbr = (int)input_str[i];
                chrNmbr -= countKeySymbols;
                char newChar = (char)chrNmbr;
                input_tmp += newChar;
            }
            arrStrings[indxCrrnt] = input_tmp;
        }
    }
    public class MessageDecrypted
    {
        public string PlanetName { get; set; }
        public int Population { get; set; }
        public char AttakType { get; set; }
        public int SoldierCount { get; set; }
    }
}
