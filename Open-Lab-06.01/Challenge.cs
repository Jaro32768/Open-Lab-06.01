using System;

namespace Open_Lab_06._01
{
    public class Challenge
    {
        public string MysteryFunc(string str)
        {
            string ret = "";
            int k = 0;
            for (int i = 0; i < str.Length; i = i + 2)
            {
                switch (str[i+1])
                {
                    case '0':
                        {
                           k = 0;
                            break;
                        }
                    case '1':
                        {
                           k = 1;
                            break;
                        }
                    case '2':
                        {
                           k = 2;
                            break;
                        }
                    case '3':
                        {
                           k = 3;
                            break;
                        }
                    case '4':
                        {
                           k = 4;
                            break;
                        }
                    case '5':
                        {
                           k = 5;
                            break;
                        }
                    case '6':
                        {
                           k = 6;
                            break;
                        }
                    case '7':
                        {
                           k = 7;
                            break;
                        }
                    case '8':
                        {
                           k = 8;
                            break;
                        }
                    case '9':
                        {
                           k = 9;
                            break;
                        }
                }
                for (int z = 0; z < k; z++)
                {
                    ret = "" + ret + str[i];
                }
            }
            return ret;
        }
    }
}
