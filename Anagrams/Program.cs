using System;
using System.Linq;

namespace Anagrams
{
    public class Program
    {

        public static Boolean IsAnagram(string str1, string str2)
        {
            if (str1.ToLower().Equals(str2.ToLower()))
                return true;

            string ordered1 = String.Concat(str1.ToLower().OrderBy(x => x));
            string ordered2 = String.Concat(str2.ToLower().OrderBy(x => x));


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
            //Program prog = new Program();
            Console.WriteLine(Anagrams.Program.IsAnagram("Rat", "Tar"));

        }
    }
}
