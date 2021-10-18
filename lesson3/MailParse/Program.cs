using System;
using System.Text;
using System.IO;

namespace MailParse
{
    class Program
    {
        public static string splitSym = " ";
        public static string searchSym = "&";
        public static string path = @"D:\projvs\MailParse\sometextfile.txt";
        static void Main(string[] args)
        {
            string test1 = "Кучма Андрей Витальевич & Kuchma@mail.ru Мизинцев Павел Николаевич & Pasha@mail.ru";
            SearchMail(ref test1);
            Console.WriteLine(test1);

            Console.WriteLine();

            string test2 = OpenFile(path);
            SearchMail(ref test2);
            Console.WriteLine(test2);

            Console.ReadLine();
        }

        public static string OpenFile(string way)
        {
            StringBuilder result = new StringBuilder();
            StreamReader sr = new StreamReader(way);

            using (sr)
            {
                result.Append(sr.ReadToEnd());
            }

            return result.ToString();
        }

        public static void SearchMail(ref string s)
        {
            var splitString = s.Split(splitSym);
            StringBuilder result = new StringBuilder();

            

            for(int i = 0; i < splitString.Length; i++)
            {
                if (searchSym.Equals(splitString[i]))
                {
                    result.Append(splitString[i + 1]);
                    result.Append(" ");
                }
            }

            s = result.ToString();
        }

    }
}
