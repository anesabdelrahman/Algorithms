using System;
using System.Runtime.CompilerServices;
using Algorithms_DataStruct_Lib;
using NUnit.Framework;

namespace Algorithms.DataStruct.Lib.Tests
{
    class OutOverloadExample
    {
        public int SampleMethod(int i)
        {
            Console.Write($"Without Out keyword {i}");
            return i;
        }
        public int SampleMethod(out int i) => i=5;
    }

    [TestFixture]
    public class Misc_Tests
    {
        [Test]
        public void Test()
        {
            int input;
            var sut = new OutOverloadExample().SampleMethod(out input);
            Assert.AreEqual(input, sut);

        }
    }
}
