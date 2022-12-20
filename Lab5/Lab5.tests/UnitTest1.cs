using System;
using Xunit;
using Lab5;

namespace MyProject.tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(Program.factorial(5), 120);

        }
        [Fact]
        public void Test2()
        {
            Assert.Equal(Program.factorial(6), 720);

        }
        [Fact]
        public void Test3()
        {
            Assert.Equal(Program.factorial(3), 6);

        }
    }
}