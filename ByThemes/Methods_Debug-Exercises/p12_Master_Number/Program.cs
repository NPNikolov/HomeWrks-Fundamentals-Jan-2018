using System;

namespace p12_Master_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int upperBound = int.Parse(Console.ReadLine());
            for (int i = 1; i <= upperBound; i++)
            {
                if (IsMasterNmbr(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        static bool IsMasterNmbr(int TestNmbr)
        {
            string tmp_str_nmbr = "" + TestNmbr;
            ushort lngth_tst = (ushort)tmp_str_nmbr.Length;
            if (DevidedBy7(tmp_str_nmbr, lngth_tst))
            {
                
                if (ContainsEvenDgt(tmp_str_nmbr, lngth_tst))
                {
                        return TestSymetric(tmp_str_nmbr, lngth_tst);
                }
                else
                return false;
            }
            else
            return false;
            
        }

        private static bool TestSymetric(string digitString, ushort lngthTst)
        {
            if (lngthTst==1) return true;
            else
            {
                string str1 = "";
                string str2 = "";
                byte nmToAdd = (byte)(lngthTst % 2);
                
                    ushort midString = (ushort)(lngthTst / 2);
                    for (ushort i = 0; i < midString; i++)
                    {
                        str1 += digitString[i].ToString();
                    }
                    for (ushort i = lngthTst; i > midString+nmToAdd; i--)
                    {
                        str2 += digitString[i-1].ToString();
                    }

                return str2.Equals(str1);
            }
        }

        static bool DevidedBy7(string digitString, ushort lngthTst)
        {
            int nmbr = 0;
            for (ushort i = 0; i < lngthTst; i++)
            {
                nmbr += int.Parse(digitString[i].ToString());
            }
            double test = nmbr % 7;
            return !(test > 0.0);
        }
        static bool ContainsEvenDgt(string digitString, ushort digitStrLength)
        {
            bool testBool = false;
            for (ushort i = 0; i < digitStrLength; i++)
            {
                int testNmbr = int.Parse(digitString[i].ToString());
                if (testNmbr%2==0)
                {
                    testBool = true;
                    break;
                }
            }
            return testBool;
        }
    }
}
