using System;
using System.Linq;
using Xunit;
using RomanNumerals;

namespace UnitTestProject1
{
    public class UnitTest1
    {
        RomanNumbersConverter rmc = new RomanNumbersConverter();
        [Fact]
        public void TestMethod1()
        {
            Assert.Equal("I", rmc.Convert(1));
        }
        [Fact]
        public void TestMethod2()
        {
            Assert.Equal("II", rmc.Convert(2));
        }
        [Fact]
        public void TestMethod3()
        {
            Assert.Equal("III", rmc.Convert(3));
        }
        [Fact]
        public void TestMethod4()
        {
            Assert.Equal("IV", rmc.Convert(4));
        }
        [Fact]
        public void TestMethod5()
        {
            Assert.Equal("V", rmc.Convert(5));
        }
        [Fact]
        public void TestMethod6()
        {
            Assert.Equal("VI", rmc.Convert(6));
        }
        [Fact]
        public void TestMethod7()
        {
            Assert.Equal("VII", rmc.Convert(7));
        }
        [Fact]
        public void TestMethod8()
        {
            Assert.Equal("VIII", rmc.Convert(8));
        }
        [Fact]
        public void TestMethod9()
        {
            Assert.Equal("IX", rmc.Convert(9));
        }
        [Fact]
        public void TestMethod10()
        {
            Assert.Equal("X", rmc.Convert(10));
        }
        [Fact]
        public void TestMethod11()
        {
            Assert.Equal("XV", rmc.Convert(15));
        }
        [Fact]
        public void TestMethod12()
        {
            Assert.Equal("XXIV", rmc.Convert(24));
        }
        [Fact]
        public void TestMethod13()
        {
            Assert.Equal("XXXIII", rmc.Convert(33));
        }
        [Fact]
        public void TestMethod14()
        {
            Assert.Equal("XXXX", rmc.Convert(40));
        }
        [Fact]
        public void TestMethod15()
        {
            Assert.Equal("L", rmc.Convert(50));
        }
        [Fact]
        public void TestMethod16()
        {
            Assert.Equal("LVI", rmc.Convert(56));
        }
        [Fact]
        public void TestMethod17()
        {
            Assert.Equal("LXII", rmc.Convert(62));
        }
        [Fact]
        public void TestMethod18()
        {
            Assert.Equal("LXXIII", rmc.Convert(73));
        }
        [Fact]
        public void TestMethod19()
        {
            Assert.Equal("LXXXVIII", rmc.Convert(88));
        }
        [Fact]
        public void TestMethod20()
        {
            Assert.Equal("LXXXXIX", rmc.Convert(99));
        }
        [Fact]
        public void TestMethod21()
        {
            Assert.Equal("C", rmc.Convert(100));
        }
        [Fact]
        public void TestMethod22()
        {
            Assert.Equal("CXI", rmc.Convert(111));
        }
        [Fact]
        public void TestMethod23()
        {
            Assert.Equal("CCLXII", rmc.Convert(262));
        }
        [Fact]
        public void TestMethod24()
        {
            Assert.Equal("CCCLXXV", rmc.Convert(375));
        }
        [Fact]
        public void TestMethod25()
        {
            Assert.Equal("CCCCXXIX", rmc.Convert(429));
        }
        [Fact]
        public void TestMethod26()
        {
            Assert.Equal("CCCCLXXXXIX", rmc.Convert(499));
        }
    }
}
