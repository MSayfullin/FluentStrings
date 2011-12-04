using System;
using dokas.FluentStrings;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentStrings.Tests
{
    [TestClass]
    public class ReplaceTests
    {
        [TestMethod]
        public void TestCases()
        {
            string transformed = "some very long string".Replace("very");
            transformed = "some very long string".Replace("very").With("not very");
            transformed = "some very long string".Replace("very").With("not very").IgnoringCase();
        }
    }
}
