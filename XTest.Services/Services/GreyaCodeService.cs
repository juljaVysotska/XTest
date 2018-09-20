using System;
using System.Collections.Generic;
using System.Text;

namespace XTest.Services.Services
{
    public class GreyaCodeService
    {
        public string x { get; set; }

        public GreyaCodeService(int xLength)
        {
            var sb = new StringBuilder();
            Random rdm = new Random();
            for (int i = 0; i < xLength; i++)
                sb.Append(rdm.Next(2).ToString());
            x = sb.ToString();
        }


        private int xor(int a, int b)
        {
            if (a == b)
                return 0;
            else
                return 1;
        }

        public string encode()
        {
            var sb = new StringBuilder();
            sb.Append(x[0]);
            for (int i = 1; i < x.Length; i++)
            {
                sb.Append(xor(x[i], x[i - 1]).ToString());
            }
            return sb.ToString();
        }

        public string decode(string code)
        {
            var sb = new StringBuilder();
            sb.Append(code[0]);
            for (int i = 1; i < code.Length; i++)
            {
                int temp = (int)char.GetNumericValue(code[0]);
                //sb.Append(xor(x[i], x[i - 1]).ToString());
                for (int j = 1; j <= i; j++)
                {
                    temp = xor(temp, (int)char.GetNumericValue(code[j]));
                }
                sb.Append(temp.ToString());
            }
            return sb.ToString();
        }
    }
}
