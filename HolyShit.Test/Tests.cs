using System;
using NUnit.Framework;

namespace HolyShit.Test
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(new int[] {3, 5}, HolyShit.Program.Divisors(15));
            Assert.AreEqual(new int[] {2, 4, 8}, HolyShit.Program.Divisors(16));
            Assert.AreEqual(new int[] {11, 23}, HolyShit.Program.Divisors(253));
            Assert.AreEqual(new int[] {2, 3, 4, 6, 8, 12}, HolyShit.Program.Divisors(24));
        }
    }
}