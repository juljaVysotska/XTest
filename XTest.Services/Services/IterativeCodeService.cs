using System;
using System.Collections.Generic;
using System.Text;

namespace XTest.Services.Services
{
    class IterativeCodeService
    {

        public int q { get; set; }
        public int[][] encodingArr { get; set; }

        public IterativeCodeService()
        {
            encodingArr = new int[5][];
            Random rdm = new Random();
            q = rdm.Next(2, 11);
            for (int i = 0; i < encodingArr.Length; i++)
            {
                encodingArr[i] = new int[5];
                for (int j = 0; j < encodingArr[0].Length; j++)
                {
                    encodingArr[i][j] = rdm.Next(10);
                }
            }
        }

        public int[][] encodeArr()
        {
            int[][] result = new int[6][];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = new int[6];
                for (int j = 0; j < result[0].Length; j++)
                {
                    if (i < 5 && j < 5)
                    {
                        result[i][j] = encodingArr[i][j];
                    }
                    else if (i == 5)
                    {
                        result[i][j] = calcLine(sumArrColumn(result, j));
                    }
                    else
                    {
                        result[i][j] = calcLine(sumArrLine(i));
                    }
                }
            }
            return result;
        }

        private int sumArrColumn(int[][] arr, int ColumnNumb)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i][ColumnNumb];
            }
            return sum;
        }


        private int sumArrLine(int lineNumb)
        {
            int sum = 0;
            for (int i = 0; i < encodingArr[0].Length; i++)
            {
                sum += encodingArr[lineNumb][i];
            }
            return sum;
        }

        private int calcLine(int sumOfEl)
        {
            return q - sumOfEl % q;
        }

        public int[][] makeOneMistake()
        {
            int[][] arrWithMisst = encodeArr();
            Random rdm = new Random();
            int i = rdm.Next(encodingArr.Length);
            int j = rdm.Next(encodingArr[0].Length);
            int misstake = rdm.Next(10);
            while (misstake == arrWithMisst[i][j])
            {
                misstake = rdm.Next(10);
            }
            arrWithMisst[i][j] = misstake;
            return arrWithMisst;
        }

        public bool checkAnswer(int[][] answer)
        {
            if (answer.Equals(encodeArr()))
            {
                return true;
            }
            return false;
        }


    }
}
