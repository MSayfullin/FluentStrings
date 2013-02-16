﻿using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dokas.FluentStrings.Tests
{
    [TestClass]
    public class RemoveTests
    {
        #region Full Remove

        [TestMethod]
        public void RemoveFromNullString()
        {
            string transformed = Const.NullString.Remove();
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveFromEmptyString()
        {
            string transformed = String.Empty.Remove();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void Remove()
        {
            string transformed = "Some string".Remove();
            transformed.Should().Be(String.Empty);
        }

        #endregion

        #region Remove

        [TestMethod]
        public void RemoveTextFromNullString()
        {
            string transformed = Const.NullString.Remove("bla");
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveNullText()
        {
            string transformed = Const.SampleString.Remove(null);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveNullTextFromNullString()
        {
            string transformed = Const.NullString.Remove(null);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveEmptyText()
        {
            string transformed = Const.SampleString.Remove(String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveText()
        {
            string transformed = "TEST string will be removed".Remove("TEST");
            transformed.Should().Be(" string will be removed");

            transformed = "string will be removed ->TEST".Remove("TEST");
            transformed.Should().Be("string will be removed ->");

            transformed = "string will be removed ->TEST and this will be left TEST".Remove("TEST");
            transformed.Should().Be("string will be removed -> and this will be left TEST");

            transformed = "TEST string will be removed only from left side TEST".Remove("TEST");
            transformed.Should().Be(" string will be removed only from left side TEST");
        }

        #endregion

        #region Remove From

        [TestMethod]
        public void RemoveTextFromBeginningOfNullString()
        {
            string transformed = Const.NullString.Remove("bla").From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveTextFromEndOfNullString()
        {
            string transformed = Const.NullString.Remove("bla").From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveNullTextFromBeginning()
        {
            string transformed = Const.SampleString.Remove(null).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveNullTextFromEnd()
        {
            string transformed = Const.SampleString.Remove(null).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveNullTextFromBeginningOfNullString()
        {
            string transformed = Const.NullString.Remove(null).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveNullTextFromEndOfNullString()
        {
            string transformed = Const.NullString.Remove(null).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveEmptyTextFromBeginning()
        {
            string transformed = Const.SampleString.Remove(String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveEmptyTextFromEnd()
        {
            string transformed = Const.SampleString.Remove(String.Empty).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveTextFromBeginning()
        {
            string transformed = "TEST string will be removed".Remove("TEST").From(The.Beginning);
            transformed.Should().Be(" string will be removed");

            transformed = "TEST <- string will be removed, not this -> TEST".Remove("TEST").From(The.Beginning);
            transformed.Should().Be(" <- string will be removed, not this -> TEST");

            transformed = "Some additional string |TEST| string will be removed".Remove("TEST").From(The.Beginning);
            transformed.Should().Be("Some additional string || string will be removed");
        }

        [TestMethod]
        public void RemoveTextFromEnd()
        {
            string transformed = "string will be removed -> TEST".Remove("TEST").From(The.End);
            transformed.Should().Be("string will be removed -> ");

            transformed = "TEST <- this string will be left, but this will be removed -> TEST".Remove("TEST").From(The.End);
            transformed.Should().Be("TEST <- this string will be left, but this will be removed -> ");

            transformed = "string will be removed -> |TEST| some additional string".Remove("TEST").From(The.End);
            transformed.Should().Be("string will be removed -> || some additional string");
        }

        #endregion

        #region Remove Ignoring Case

        [TestMethod]
        public void RemoveTextFromNullStringIgnoringCase()
        {
            string transformed = Const.NullString.Remove("bla").IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveNullTextIgnoringCase()
        {
            string transformed = Const.SampleString.Remove(null).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveNullTextFromNullStringIgnoringCase()
        {
            string transformed = Const.NullString.Remove(null).IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveEmptyTextIgnoringCase()
        {
            string transformed = Const.SampleString.Remove(String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveTextIgnoringCase()
        {
            string transformed = "TEST string will be removed".Remove("TeSt").IgnoringCase();
            transformed.Should().Be(" string will be removed");

            transformed = "string will be removed ->tEST".Remove("tEsT").IgnoringCase();
            transformed.Should().Be("string will be removed ->");

            transformed = "string will be removed ->TEST and this will be left TEST".Remove("TEST").IgnoringCase();
            transformed.Should().Be("string will be removed -> and this will be left TEST");

            transformed = "TesT string will be removed only from left side TEST".Remove("TEST").IgnoringCase();
            transformed.Should().Be(" string will be removed only from left side TEST");
        }

        #endregion

        #region Remove Ignoring Case From

        [TestMethod]
        public void RemoveTextFromBeginningOfNullStringIgnoringCase()
        {
            string transformed = Const.NullString.Remove("bla").IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveTextFromEndOfNullStringIgnoringCase()
        {
            string transformed = Const.NullString.Remove("bla").IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveNullTextFromBeginningIgnoringCase()
        {
            string transformed = Const.SampleString.Remove(null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveNullTextFromEndIgnoringCase()
        {
            string transformed = Const.SampleString.Remove(null).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveNullTextFromBeginningOfNullStringIgnoringCase()
        {
            string transformed = Const.NullString.Remove(null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveNullTextFromEndOfNullStringIgnoringCase()
        {
            string transformed = Const.NullString.Remove(null).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveEmptyTextFromBeginningIgnoringCase()
        {
            string transformed = Const.SampleString.Remove(String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveEmptyTextFromEndIgnoringCase()
        {
            string transformed = Const.SampleString.Remove(String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveTextFromBeginningIgnoringCase()
        {
            string transformed = "TEST string will be removed".Remove("TeSt").IgnoringCase().From(The.Beginning);
            transformed.Should().Be(" string will be removed");

            transformed = "string will be removed ->tEST".Remove("tEsT").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("string will be removed ->");

            transformed = "string will be removed ->TEST and this will be left TEST".Remove("TEST").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("string will be removed -> and this will be left TEST");

            transformed = "TesT string will be removed only from left side TEST".Remove("TEST").IgnoringCase().From(The.Beginning);
            transformed.Should().Be(" string will be removed only from left side TEST");
        }

        [TestMethod]
        public void RemoveTextFromEndIgnoringCase()
        {
            string transformed = "string will be removed -> TEST".Remove("tESt").IgnoringCase().From(The.End);
            transformed.Should().Be("string will be removed -> ");

            transformed = "TEST <- this string will be left, but this will be removed -> TEST".Remove("test").IgnoringCase().From(The.End);
            transformed.Should().Be("TEST <- this string will be left, but this will be removed -> ");

            transformed = "string will be removed -> |TesT| some additional string".Remove("TEST").IgnoringCase().From(The.End);
            transformed.Should().Be("string will be removed -> || some additional string");
        }

        #endregion

        #region Remove All

        [TestMethod]
        public void RemoveAllTextFromNullString()
        {
            string transformed = Const.NullString.RemoveAll("bla");
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveAllNullText()
        {
            string transformed = Const.SampleString.RemoveAll(null);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveAllNullTextFromNullString()
        {
            string transformed = Const.NullString.RemoveAll(null);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveAllEmptyText()
        {
            string transformed = Const.SampleString.RemoveAll(String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveAllText()
        {
            string transformed = "TEST string will be removed".RemoveAll("TEST");
            transformed.Should().Be(" string will be removed");

            transformed = "TEST string will be removed from both sides TEST".RemoveAll("TEST");
            transformed.Should().Be(" string will be removed from both sides ");
        }

        #endregion
    }
}
