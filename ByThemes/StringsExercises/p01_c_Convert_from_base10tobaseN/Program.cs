using System;
using System.Collections.Generic;
using System.Linq;

namespace p01_c_Convert_from_base10tobaseN
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strArr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            int n = (int)Math.Round(double.Parse(strArr[0]));
            var numbrAtBas10 = MyBigNumber.CreateMyBigNumber(strArr[1]);
            var lsRmnngs = new List<string>();

            string n_BaseStr = "" + n;
            string mainPartStr = MyBigNumber.DevideByN_baseInt(numbrAtBas10, '1');
            string rmnngStr = "";
            var myHlpMainPart = MyBigNumber.CreateMyBigNumber(mainPartStr);
            var testExitBool = false;
            do
            {

                var lsDvsnResults = MyBigNumber.ReturnDevisionSeparatedMdl(myHlpMainPart, n_BaseStr[0]);

                rmnngStr = lsDvsnResults[1].Value();
                mainPartStr = lsDvsnResults[0].Value();
                var lsCmprExit = new List<string>(2) { n_BaseStr, mainPartStr };
                MyBigNumber.IndentLengthWithZeroes(lsCmprExit);
                lsRmnngs.Add(rmnngStr);
                myHlpMainPart = MyBigNumber.CreateMyBigNumber(mainPartStr);
                testExitBool = MyBigNumber.FirstLineSmallerThanSecond(lsCmprExit[0], lsCmprExit[1]);
            } while (testExitBool);
            string nBasedStr = "" + mainPartStr;
            for (int i = lsRmnngs.Count; i > 0; i--)
            {
                nBasedStr += lsRmnngs[i - 1];
            }
            Console.WriteLine(nBasedStr);
        }
    }
    class MyBigNumber
    {
        public string PartDigits { get; set; }
        public int FloatPointPosition { get; set; }
        public int SignNmbr { get; set; }
        public string Value()
        {
            var charValue = this.PartDigits.ToCharArray();var listValue = new List<char>();
            for (int i = 0; i < charValue.Length; i++)
            {
                if (i == charValue.Length - this.FloatPointPosition) listValue.Add('.');
                listValue.Add(charValue[i]);
            }
            string signStr = "";
            if (this.SignNmbr < 0) signStr = "-";
            return signStr + string.Join("", listValue);
        }
        public static MyBigNumber CreateMyBigNumber(string nmbrString)
        {
            string[] strArr = nmbrString.Split(new char[] { '.', ',', '-', '+' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            int signNmbr = 1;
            for (int i = 0; i < nmbrString.Length; i++)
            {
                if (nmbrString[i].Equals('-')) signNmbr *= -1;
                else if (!(nmbrString[i].Equals('+'))) break;
            }
            string tmpStrVal = strArr[0].TrimStart('0');
            if (tmpStrVal.Equals("")) strArr[0] = "0";
            else strArr[0] = tmpStrVal;
            int floatPointPosition = 0;
            if (strArr.Length > 1)
            {
                tmpStrVal = strArr[1].TrimEnd('0');
                if (!tmpStrVal.Equals(""))
                {
                    floatPointPosition = tmpStrVal.Length;
                    strArr[0] += tmpStrVal;
                }
            }

            if (strArr[0].Equals("0")) signNmbr = 1;
            MyBigNumber nmbr = new MyBigNumber() { PartDigits = strArr[0], FloatPointPosition = floatPointPosition, SignNmbr = signNmbr };
            return nmbr;
        }
        public static MyBigNumber MultiplyBy(MyBigNumber myBigNumber, MyBigNumber myBigMultiplier)
        {
            string tmpNmbrString = myBigNumber.PartDigits;
            string tmpMltplrString = myBigMultiplier.PartDigits;
            var lstMtpldLines = new List<string>(tmpMltplrString.Length);
            for (int i = tmpMltplrString.Length - 1; i >= 0; i--)
            {
                string line = MyBigNumber.MultiplyLineByChar(tmpNmbrString, tmpMltplrString[i]);
                line = MyBigNumber.AddNmbrZero(line, (-1 * (tmpMltplrString.Length - 1 - i)));
                lstMtpldLines.Add(line);
            }
            MyBigNumber.IndentLengthWithZeroes(lstMtpldLines);
            string lineSum = lstMtpldLines[0];
            for (int i = 1; i < lstMtpldLines.Count; i++)
            {
                string tmpLine = lstMtpldLines[i];
                var lsAppend = new List<string>(2);
                lsAppend.Add(lineSum);
                lsAppend.Add(tmpLine);
                MyBigNumber.IndentLengthWithZeroes(lsAppend);
                lineSum = MyBigNumber.AddTwoLines(lsAppend[0], lsAppend[1]);
            }
            int pstnFloatPoint = myBigNumber.FloatPointPosition + myBigMultiplier.FloatPointPosition;
            int nmbrLeadZeroes = pstnFloatPoint - lineSum.Length + 1;
            if (nmbrLeadZeroes > 0)
            {
                lineSum = MyBigNumber.AddNmbrZero(lineSum, nmbrLeadZeroes);
            }
            int newSign = myBigMultiplier.SignNmbr * myBigNumber.SignNmbr;
            var newMyNumber = new MyBigNumber() { PartDigits = lineSum, FloatPointPosition = pstnFloatPoint, SignNmbr = newSign };
            string resultValue = newMyNumber.Value();
            var resMyNumber = MyBigNumber.CreateMyBigNumber(resultValue);
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
        public static string MultiplyLineByChar(string line, char oneChar)
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
            if (tmpResult.Equals(""))return "0";
            else return tmpResult;
        }
        public static string AddNmbrZero(string line, int nmbrZero)
        {
            if (nmbrZero == 0) return line;
            int nmbZero = Math.Abs(nmbrZero);
            var charArr = new char[line.Length + nmbZero];
            if (nmbrZero < 0)
            {
                for (int i = 0; i < line.Length; i++)
                    charArr[i] = line[i];
                for (int i = 0; i < nmbZero; i++)
                    charArr[line.Length + i] = '0';
            }
            else
            {
                for (int i = 0; i < nmbZero; i++)
                    charArr[i] = '0';
                for (int i = 0; i < line.Length; i++)
                    charArr[i + nmbZero] = line[i];
            }
            return string.Join("", charArr);
        }
        public static void IndentLengthWithZeroes(List<string> inLsLines)
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
                    string newElm = MyBigNumber.AddNmbrZero(elm, nmbZero);
                    inLsLines[i] = newElm;
                }
            }
        }
        public static bool FirstLineSmallerThanSecond(string fString, string sString)
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
        public static int SmallerByAbsIsFirstOrSecond(MyBigNumber myNmbr1, MyBigNumber myNmbr2)
        {
            int floatPstn1 = myNmbr1.FloatPointPosition;
            int floatPstn2 = myNmbr2.FloatPointPosition;
            MyBigNumber longFloatPart, shortFloatPart;
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
            string longFltStr = longFloatPart.PartDigits;
            string shortFltStr = MyBigNumber.AddNmbrZero(shortFloatPart.PartDigits, -1 * (longFloatLngth - shortFloatLngth));
            var lsToEqual = new List<string>(2);
            lsToEqual.Add(longFltStr);
            lsToEqual.Add(shortFltStr);
            MyBigNumber.IndentLengthWithZeroes(lsToEqual);
            bool smallerLong = MyBigNumber.FirstLineSmallerThanSecond(lsToEqual[0], lsToEqual[1]);
            int resCmpr = 0;
            if (smallerLong)
            {
                if (floatPstn2 > floatPstn1) resCmpr = 2;
                else resCmpr = 1;
            }
            else
            {
                if (floatPstn2 > floatPstn1) resCmpr = 1;
                else resCmpr = 2;
            }
            return resCmpr;
        }
        public static string BiggerMinusSmaller(string biggerAbsNmbrs, string smallerAbsNmbrs)
        {
            char[] bgrArrNmbr = biggerAbsNmbrs.ToCharArray();
            char[] smlrArrNmbr = smallerAbsNmbrs.ToCharArray();
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
            string strngReslt = string.Join("", bgrArrNmbr);
            return strngReslt;
        }
        public static MyBigNumber Sum2MyBigNumbers(MyBigNumber myNmbr1, MyBigNumber myNmbr2)
        {
            int smallerByAbs = MyBigNumber.SmallerByAbsIsFirstOrSecond(myNmbr1, myNmbr2);
            MyBigNumber bgrByAbs, smlrByAbs;
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
            string biggerAbsNmbrs = bgrByAbs.PartDigits;
            string smallerAbsNmbrs = smlrByAbs.PartDigits;
            int biggerAbsFlPos = bgrByAbs.FloatPointPosition;
            int smallerAbsFlPos = smlrByAbs.FloatPointPosition;
            int biggerFlPPos = 0;
            if (biggerAbsFlPos > smallerAbsFlPos)
            {
                biggerFlPPos = biggerAbsFlPos;
                smallerAbsNmbrs = MyBigNumber.AddNmbrZero(smallerAbsNmbrs, -1 * (biggerAbsFlPos - smallerAbsFlPos));
            }
            else
            {
                biggerFlPPos = smallerAbsFlPos;
                biggerAbsNmbrs = MyBigNumber.AddNmbrZero(biggerAbsNmbrs, -1 * (smallerAbsFlPos - biggerAbsFlPos));
            }
            if (smallerAbsNmbrs.Length < biggerAbsNmbrs.Length)
            {
                smallerAbsNmbrs = MyBigNumber.AddNmbrZero(smallerAbsNmbrs, biggerAbsNmbrs.Length - smallerAbsNmbrs.Length);
            }
            string newStrPartDigits;
            if ((myNmbr1.SignNmbr * myNmbr2.SignNmbr) >= 0)
            {
                newStrPartDigits = MyBigNumber.AddTwoLines(biggerAbsNmbrs, smallerAbsNmbrs);
            }
            else
                newStrPartDigits = MyBigNumber.BiggerMinusSmaller(biggerAbsNmbrs, smallerAbsNmbrs);
            var myNmbr3 = new MyBigNumber() { PartDigits = newStrPartDigits, SignNmbr = signOfBigger, FloatPointPosition = biggerFlPPos };
            string newStringVal = myNmbr3.Value();
            return MyBigNumber.CreateMyBigNumber(newStringVal);
        }
        public static string DevideByN_baseInt(MyBigNumber myBigNmbr, char n_BaseCHAR)
        {
            string strPartDgt1 = myBigNmbr.PartDigits;
            int base_N = int.Parse(n_BaseCHAR.ToString());
            int mainPartLength = strPartDgt1.Length - myBigNmbr.FloatPointPosition;
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
            {
                if (myBigNmbr.SignNmbr < 0)
                    resNoZero = "-" + resNoZero;
            }
            return resNoZero;
        }
        public static List<MyBigNumber> ReturnDevisionSeparatedMdl(MyBigNumber myBigNmbr, char base_N_inCHAR)
        {
            string strBase = base_N_inCHAR.ToString();
            string intBigPart = MyBigNumber.DevideByN_baseInt(myBigNmbr, strBase[0]);
            var myIntPartBigNmbr = MyBigNumber.CreateMyBigNumber(intBigPart);
            string mltplr = "-" + strBase;
            var myHlpBig = MyBigNumber.CreateMyBigNumber(mltplr);
            var myNegativeIntPart = MyBigNumber.MultiplyBy(myIntPartBigNmbr, myHlpBig);
            var myRmnng = MyBigNumber.Sum2MyBigNumbers(myBigNmbr, myNegativeIntPart);
            var lsResult = new List<MyBigNumber>() { myIntPartBigNmbr, myRmnng };
            return lsResult;
        }
    }
}
