using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1.Input: aaabbcca Output: a3b2c2a1

            //2.String reverse by special character intact:
            // Input: 	ad&g%dj$$cqa
            //Output: aq&c%jd$$gda


            string str = "ad&g%dj$$cqa";
            char[] specialCharArr = new char[] { '&', '%', '$' };

            char[] tempArr = str.ToCharArray();

            for (int i = 0; i < tempArr.Length; i++)
            {
                if (!specialCharArr.Contains(tempArr[i]))
                    tempArr[i] = '0';
            }    

            for (int j = str.Length-1; j >= 0; j--)
            {
                for (int i = 0; i < tempArr.Length; i++)
                {
                    if (tempArr[i].Equals('0') && !specialCharArr.Contains(str[j]))
                    {
                        tempArr[i] = str[j];
                        break;
                    }
                    else
                        continue;
                }
            }

            string tempStr = new string(tempArr);

            Console.Write("Output : " + tempStr);

            //string str = "aaabbcca";
            //StringBuilder sb = new StringBuilder();
            //int tempCount = 1;
            //for (int i = 0; i < str.Length; i++)
            //{

            //    if (i + 1 == str.Length)
            //    {
            //        sb.Append(str[i].ToString() + tempCount);
            //        break;
            //    }

            //    if (str[i] == str[i + 1])
            //        tempCount++;
            //    else
            //    {
            //        sb.Append(str[i].ToString() + tempCount);
            //        tempCount = 1;
            //    }
            //}

            //Console.Write("Output : " + sb);
            Console.ReadKey();
        }
    }
}
