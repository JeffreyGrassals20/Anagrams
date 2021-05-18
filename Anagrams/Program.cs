using System;
using System.Linq;

namespace Anagrams
{
    public class Program
    {

        public static Boolean IsAnagram(string str1, string str2)
        {
            string x = str1.ToLower();
            string y = str2.ToLower();

            if (x == null || y == null)
                return false;

            if (x.Equals(y))
                return true;

            string ordered1 = String.Concat(x.OrderBy(x => x));
            string ordered2 = String.Concat(y.OrderBy(x => x));


            Console.WriteLine(ordered1);
            Console.WriteLine(ordered2);

            if (ordered1 == ordered2)
            {
                return true;
            }
            return false;

        }
        static void Main(string[] args)
        {
            Console.WriteLine(Anagrams.Program.IsAnagram("Rat", " "));

        }
    }
}
