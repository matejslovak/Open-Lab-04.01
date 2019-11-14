using System;

namespace Open_Lab_04._01
{
    class Program
    {
        public static bool DoubleLetters(string str)
        {
            for (var i = 0; i < str.Length -1; i++)
            {
                if (str[i] == str[i + 1])
                {
                    return true;
                }
            }
            return false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(DoubleLetters("woooooooooooooooow"));
        }
    }
}
