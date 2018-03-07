using System;
using System.Collections.Generic;
using System.Linq;

namespace p01_d_Convert_from_base10tobaseN
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strArr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            int n = (int)Math.Round(double.Parse(strArr[0]));
            var numbrAtBas10 = MBgNmbr.CrMBigNmb(strArr[1]);
            var lsRmnngs = new List<string>();

            string n_BaseStr = "" + n;
            string mainPartStr = MBgNmbr.DvdByN_bsInt(numbrAtBas10, '1');
            string rmnngStr = "";
            var myHlpMainPart = MBgNmbr.CrMBigNmb(mainPartStr);
            var testExitBool = false;
            do
            {
                var lsDvsnResults = MBgNmbr.RtnDvisnSptdMdl(myHlpMainPart, n_BaseStr[0]);
                rmnngStr = lsDvsnResults[1].Value();
                mainPartStr = lsDvsnResults[0].Value();
                var lsCmprExit = new List<string>(2) { n_BaseStr, mainPartStr };
                MBgNmbr.IndntLngthWZrs(lsCmprExit);
                lsRmnngs.Add(rmnngStr);
                myHlpMainPart = MBgNmbr.CrMBigNmb(mainPartStr);
                testExitBool = MBgNmbr.FrstLnSmllrThnScnd(lsCmprExit[0], lsCmprExit[1]);
            } while (testExitBool);
            string nBasedStr = "" + mainPartStr;
            for (int i = lsRmnngs.Count; i > 0; i--)
            {
                nBasedStr += lsRmnngs[i - 1];
            }
            Console.WriteLine(nBasedStr);
        }
    }
    class MBgNmbr
    {
        public string BNDgt { get; set; }
        public int FltPntPsitin { get; set; }
        public int SignNmbr { get; set; }
        public string Value()
        {
            var charValue = this.BNDgt.ToCharArray(); var listValue = new List<char>();
            for (int i = 0; i < charValue.Length; i++)
            {
                if (i == charValue.Length - this.FltPntPsitin) listValue.Add('.');
                listValue.Add(charValue[i]);
            }
            string signStr = "";
            if (this.SignNmbr < 0) signStr = "-";
            return signStr + string.Join("", listValue);
        }
        public static MBgNmbr CrMBigNmb(string nmbrString)
        {
            string[] strArr = nmbrString.Split(new char[] { '.', ',', '-', '+' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            int signNmbr = 1;
            for (int i = 0; i < nmbrString.Length; i++)
            {
                if (nmbrString[i].Equals('-')) signNmbr *= -1;
                else if (!(nmbrString[i].Equals('+'))) break;
            }
            string tmpStrVal = strArr[0].TrimStart('0');
            if (tmpStrVal == "") strArr[0] = "0";
            else strArr[0] = tmpStrVal;
            int FltPntPsitin = 0;
            if (strArr.Length > 1)
            {
                tmpStrVal = strArr[1].TrimEnd('0');
                if (!tmpStrVal.Equals(""))
                {
                    FltPntPsitin = tmpStrVal.Length;
                    strArr[0] += tmpStrVal;
                }
            }
            if (strArr[0] == "0") signNmbr = 1;
            MBgNmbr nmbr = new MBgNmbr() { BNDgt = strArr[0], FltPntPsitin = FltPntPsitin, SignNmbr = signNmbr };
            return nmbr;
        }
        public static MBgNmbr MultiplyBy(MBgNmbr MBgNmbr, MBgNmbr myBigMultiplier)
        {
            string tmpNmbrString = MBgNmbr.BNDgt;
            string tmpMltplrString = myBigMultiplier.BNDgt;
            var lstMtpldLines = new List<string>(tmpMltplrString.Length);
            for (int i = tmpMltplrString.Length - 1; i >= 0; i--)
            {
                string line = MBgNmbr.MltiplLnByChr(tmpNmbrString, tmpMltplrString[i]);
                line = MBgNmbr.AdNmbrZr(line, (-1 * (tmpMltplrString.Length - 1 - i)));
                lstMtpldLines.Add(line);
            }
            MBgNmbr.IndntLngthWZrs(lstMtpldLines);
            string lineSum = lstMtpldLines[0];
            for (int i = 1; i < lstMtpldLines.Count; i++)
            {
                string tmpLine = lstMtpldLines[i];
                var lsAppend = new List<string>(2);
                lsAppend.Add(lineSum);
                lsAppend.Add(tmpLine);
                MBgNmbr.IndntLngthWZrs(lsAppend);
                lineSum = MBgNmbr.AddTwoLines(lsAppend[0], lsAppend[1]);
            }
            int pstnFloatPoint = MBgNmbr.FltPntPsitin + myBigMultiplier.FltPntPsitin;
            int nmbrLeadZeroes = pstnFloatPoint - lineSum.Length + 1;
            if (nmbrLeadZeroes > 0)
            {
                lineSum = MBgNmbr.AdNmbrZr(lineSum, nmbrLeadZeroes);
            }
            int newSign = myBigMultiplier.SignNmbr * MBgNmbr.SignNmbr;
            var newMyNumber = new MBgNmbr() { BNDgt = lineSum, FltPntPsitin = pstnFloatPoint, SignNmbr = newSign };
            string resultValue = newMyNumber.Value();
            var resMyNumber = MBgNmbr.CrMBigNmb(resultValue);
            return resMyNumber;
        }
        public static string AddTwoLines(string lineOne, string lineTwo)
        {
            int lengthShort = lineOne.Length;
            int spareOne = 0;
            int shortNmbr = 0;
            int longNmbr = 0;
            char[] newNmbrPart = new char[lengthShort + 1];
            for (int i = lengthShort; i > 0; i--)
            {
                longNmbr = int.Parse(lineOne[i - 1].ToString());
                shortNmbr = int.Parse(lineTwo[i - 1].ToString());
                longNmbr += shortNmbr;
                longNmbr += spareOne;
                spareOne = 0;
                if (longNmbr > 9)
                {
                    spareOne++;
                    longNmbr = longNmbr % 10;
                }
                newNmbrPart[i] = (char)(longNmbr + 48);
            }
            if (spareOne > 0) newNmbrPart[0] = (char)(spareOne + 48);
            else
                newNmbrPart[0] = ' ';
            return string.Join("", newNmbrPart).TrimStart(' ');
        }
        public static string MltiplLnByChr(string line, char oneChar)
        {
            if (oneChar.Equals('0') || (line.TrimStart('0').Equals(""))) return "0";
            int storeNumber = 0;
            int inNumber = int.Parse(oneChar.ToString());
            var result = new List<int>();
            for (int i = line.Length - 1; i >= 0; i--)
            {
                int digitLine = int.Parse(line[i].ToString());
                int tmpVal = digitLine * inNumber;
                tmpVal += storeNumber;
                digitLine = tmpVal % 10;
                storeNumber = tmpVal / 10;
                result.Add(digitLine);
            }
            result.Add(storeNumber);
            result.Reverse();
            string tmpResult = string.Join("", result);
            tmpResult = tmpResult.TrimStart('0');
            if (tmpResult == "") return "0";
            else return tmpResult;
        }
        public static string AdNmbrZr(string line, int nmbrZero)
        {
            if (nmbrZero == 0) return line;
            int nmbZero = Math.Abs(nmbrZero);
            var charArr = new char[line.Length + nmbZero];
            if (nmbrZero < 0)
            {
                for (int i = 0; i < line.Length; i++) charArr[i] = line[i];
                for (int i = 0; i < nmbZero; i++) charArr[line.Length + i] = '0';
            }
            else
            {
                for (int i = 0; i < nmbZero; i++) charArr[i] = '0';
                for (int i = 0; i < line.Length; i++) charArr[i + nmbZero] = line[i];
            }
            return string.Join("", charArr);
        }
        public static void IndntLngthWZrs(List<string> inLsLines)
        {
            int maxLength = 0;
            for (int i = 0; i < inLsLines.Count; i++)
            {
                if (maxLength < inLsLines[i].Length)
                    maxLength = inLsLines[i].Length;
            }
            for (int i = 0; i < inLsLines.Count; i++)
            {
                string elm = inLsLines[i];
                int nmbZero = maxLength - elm.Length;
                if (nmbZero > 0)
                {
                    string newElm = MBgNmbr.AdNmbrZr(elm, nmbZero);
                    inLsLines[i] = newElm;
                }
            }
        }
        public static bool FrstLnSmllrThnScnd(string fString, string sString)
        {
            bool cmpr = false;
            for (int i = 0; i < fString.Length; i++)
            {
                int cmprValF = int.Parse(fString[i].ToString());
                int cmprValS = int.Parse(sString[i].ToString());
                if (cmprValF < cmprValS)
                {
                    cmpr = true;
                    break;
                }
                else if (cmprValF > cmprValS) break;
            }
            return cmpr;
        }
        public static int SmallByAbsIsFrstOrScnd(MBgNmbr myNmbr1, MBgNmbr myNmbr2)
        {
            int floatPstn1 = myNmbr1.FltPntPsitin;
            int floatPstn2 = myNmbr2.FltPntPsitin;
            MBgNmbr longFloatPart, shortFloatPart;
            int longFloatLngth = 0;
            int shortFloatLngth = 0;
            if (floatPstn2 > floatPstn1)
            {
                longFloatLngth = floatPstn2;
                shortFloatLngth = floatPstn1;
                longFloatPart = myNmbr2;
                shortFloatPart = myNmbr1;
            }
            else
            {
                longFloatLngth = floatPstn1;
                shortFloatLngth = floatPstn2;
                longFloatPart = myNmbr1;
                shortFloatPart = myNmbr2;
            }
            string longFltStr = longFloatPart.BNDgt;
            string shortFltStr = MBgNmbr.AdNmbrZr(shortFloatPart.BNDgt, -1 * (longFloatLngth - shortFloatLngth));
            var lsToEqual = new List<string>(2);
            lsToEqual.Add(longFltStr);
            lsToEqual.Add(shortFltStr);
            MBgNmbr.IndntLngthWZrs(lsToEqual);
            bool smallerLong = MBgNmbr.FrstLnSmllrThnScnd(lsToEqual[0], lsToEqual[1]);
            int resCmpr = 0;
            if (smallerLong)
                if (floatPstn2 > floatPstn1) resCmpr = 2;
                else resCmpr = 1;
            else
                if (floatPstn2 > floatPstn1) resCmpr = 1;
            else resCmpr = 2;
            return resCmpr;
        }
        public static string BiggerMinusSmaller(string bgrAbNmbs, string smlAbsNmbrs)
        {
            char[] bgrArrNmbr = bgrAbNmbs.ToCharArray();
            char[] smlrArrNmbr = smlAbsNmbrs.ToCharArray();
            int dgtBigr = 0;
            int dgtSmllr = 0;
            for (int i = bgrArrNmbr.Length - 1; i >= 0; i--)
            {
                dgtSmllr = int.Parse(smlrArrNmbr[i].ToString());
                dgtBigr = int.Parse(bgrArrNmbr[i].ToString());
                if (dgtBigr < dgtSmllr)
                {
                    int hlpIndx = i - 1;
                    int addnlVal = 0;
                    char hlpCh = ' ';
                    for (int j = hlpIndx; j >= 0; j--)
                    {
                        addnlVal = int.Parse(bgrArrNmbr[j].ToString());
                        if (addnlVal > 0)
                        {
                            hlpCh = (char)(addnlVal - 1 + 48);
                            bgrArrNmbr[j] = hlpCh;
                            hlpIndx = j;
                            break;
                        }
                    }
                    for (int j = hlpIndx + 1; j < i; j++)
                        bgrArrNmbr[j] = '9';
                    dgtBigr += 10;
                }
                dgtBigr -= dgtSmllr;
                bgrArrNmbr[i] = (char)(dgtBigr + 48);
            }
            return string.Join("", bgrArrNmbr);
        }
        public static MBgNmbr Sum2MBgNmbrs(MBgNmbr myNmbr1, MBgNmbr myNmbr2)
        {
            int smallerByAbs = MBgNmbr.SmallByAbsIsFrstOrScnd(myNmbr1, myNmbr2);
            MBgNmbr bgrByAbs, smlrByAbs;
            int signOfBigger = 0;
            if (smallerByAbs == 1)
            {
                smlrByAbs = myNmbr1;
                bgrByAbs = myNmbr2;
                signOfBigger = myNmbr2.SignNmbr;
            }
            else
            {
                smlrByAbs = myNmbr2;
                bgrByAbs = myNmbr1;
                signOfBigger = myNmbr1.SignNmbr;
            }
            string bgrAbNmbs = bgrByAbs.BNDgt;
            string smlAbsNmbrs = smlrByAbs.BNDgt;
            int bigAbsFlPs = bgrByAbs.FltPntPsitin;
            int smallerAbsFlPos = smlrByAbs.FltPntPsitin;
            int biggerFlPPos = 0;
            if (bigAbsFlPs > smallerAbsFlPos)
            {
                biggerFlPPos = bigAbsFlPs;
                smlAbsNmbrs = MBgNmbr.AdNmbrZr(smlAbsNmbrs, -1 * (bigAbsFlPs - smallerAbsFlPos));
            }
            else
            {
                biggerFlPPos = smallerAbsFlPos;
                bgrAbNmbs = MBgNmbr.AdNmbrZr(bgrAbNmbs, -1 * (smallerAbsFlPos - bigAbsFlPs));
            }
            if (smlAbsNmbrs.Length < bgrAbNmbs.Length)
                smlAbsNmbrs = MBgNmbr.AdNmbrZr(smlAbsNmbrs, bgrAbNmbs.Length - smlAbsNmbrs.Length);
            string newStrBNDgt;
            if ((myNmbr1.SignNmbr * myNmbr2.SignNmbr) >= 0)
                newStrBNDgt = MBgNmbr.AddTwoLines(bgrAbNmbs, smlAbsNmbrs);
            else
                newStrBNDgt = MBgNmbr.BiggerMinusSmaller(bgrAbNmbs, smlAbsNmbrs);
            var myNmbr3 = new MBgNmbr() { BNDgt = newStrBNDgt, SignNmbr = signOfBigger, FltPntPsitin = biggerFlPPos };
            string newStringVal = myNmbr3.Value();
            return MBgNmbr.CrMBigNmb(newStringVal);
        }
        public static string DvdByN_bsInt(MBgNmbr myBigNmbr, char n_BaseCHAR)
        {
            string strPartDgt1 = myBigNmbr.BNDgt;
            int base_N = int.Parse(n_BaseCHAR.ToString());
            int mainPartLength = strPartDgt1.Length - myBigNmbr.FltPntPsitin;
            var lsRmnngs = new List<int>();
            int testDigit = 0;
            string testStr = "";
            int rmnngVal = 0;
            int hlpVal = 0;
            lsRmnngs.Add(rmnngVal);
            for (int i = 0; i < mainPartLength; i++)
            {
                testStr = strPartDgt1[i].ToString();
                testDigit = int.Parse(testStr) + hlpVal * 10;
                if (testDigit < base_N)
                {
                    for (int m = i + 1; m < mainPartLength; m++)
                    {
                        testStr += strPartDgt1[i + 1].ToString();
                        testDigit = int.Parse(testStr);
                        i++;
                        lsRmnngs.Add(0);
                        if (testDigit >= base_N) break;
                    }
                }
                if (testDigit < base_N)
                {
                    lsRmnngs.Add(0);
                    break;
                }
                rmnngVal = testDigit / base_N;
                lsRmnngs.Add(rmnngVal);
                hlpVal = testDigit - rmnngVal * base_N;
            }
            string reslTmp = string.Join("", lsRmnngs);
            string resNoZero = reslTmp.TrimStart('0');
            if (resNoZero.Length == 0)
                resNoZero = "0";
            else
                if (myBigNmbr.SignNmbr < 0) resNoZero = "-" + resNoZero;
            return resNoZero;
        }
        public static List<MBgNmbr> RtnDvisnSptdMdl(MBgNmbr myBigNmbr, char base_N_inCHAR)
        {
            string strBase = base_N_inCHAR.ToString();
            string intBigPart = MBgNmbr.DvdByN_bsInt(myBigNmbr, strBase[0]);
            var IntPrtBgNm = MBgNmbr.CrMBigNmb(intBigPart);
            string mltplr = "-" + strBase;
            var myHlpBig = MBgNmbr.CrMBigNmb(mltplr);
            var myNegativeIntPart = MBgNmbr.MultiplyBy(IntPrtBgNm, myHlpBig);
            var myRmnng = MBgNmbr.Sum2MBgNmbrs(myBigNmbr, myNegativeIntPart);
            var lsResult = new List<MBgNmbr>() { IntPrtBgNm, myRmnng };
            return lsResult;
        }
    }
}