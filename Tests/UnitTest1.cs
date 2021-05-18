using NUnit.Framework;
using Anagrams;

namespace Tests
{
    public class Tests
    {

        [Test]
        public void Test1()
        {
            bool result = Anagrams.Program.IsAnagram("Rat","Tar");


            Assert.IsTrue(result);
        }
    }
}