using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dokas.FluentStrings.Tests
{
    [TestClass]
    public class RemoveStartingToTests
    {
        #region Remove Starting To

        [TestMethod]
        public void RemoveStartingCharacterToCharacterInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(3).To(6);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingCharacterToCharacterInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(5).To(14);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingCharacterToCharacter()
        {
            string transformed = Const.SampleString.Remove().Starting(0).To(0);
            transformed.Should().Be(Const.SampleString);

            transformed = "Some very long string".Remove().Starting(0).To(1);
            transformed.Should().Be("ome very long string");

            transformed = "Some very long string".Remove().Starting(1).To(1);
            transformed.Should().Be("ome very long string");

            transformed = "Some very long string".Remove().Starting(1).To(100);
            transformed.Should().Be(String.Empty);

            transformed = "Some very long string".Remove().Starting(5).To(100);
            transformed.Should().Be("Some");

            transformed = "Some very long string".Remove().Starting(7).To(11);
            transformed.Should().Be("Some vlong string");
        }

        [TestMethod]
        public void RemoveStartingCharacterToCharacterInReverse()
        {
            string transformed = "Some very long string".Remove().Starting(1).To(0);
            transformed.Should().Be("ome very long string");

            transformed = "Some very long string".Remove().Starting(100).To(1);
            transformed.Should().Be(String.Empty);

            transformed = "Some very long string".Remove().Starting(100).To(5);
            transformed.Should().Be("Some");

            transformed = "Some very long string".Remove().Starting(13).To(6);
            transformed.Should().Be("Some g string");
        }

        #endregion

        #region Remove Starting From To

        [TestMethod]
        public void RemoveStartingCharacterFromBeginningToCharacterInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(3).From(The.Beginning).To(6);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingCharacterFromEndToCharacterInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(3).From(The.End).To(6);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingCharacterFromBeginningToCharacterInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(5).From(The.Beginning).To(14);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingCharacterFromEndToCharacterInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(5).From(The.End).To(14);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingCharacterFromBeginningToCharacter()
        {
            string transformed = Const.SampleString.Remove().Starting(0).From(The.Beginning).To(0);
            transformed.Should().Be(Const.SampleString);

            transformed = "Some very long string".Remove().Starting(0).From(The.Beginning).To(1);
            transformed.Should().Be("ome very long string");

            transformed = "Some very long string".Remove().Starting(1).From(The.Beginning).To(1);
            transformed.Should().Be("ome very long string");

            transformed = "Some very long string".Remove().Starting(1).From(The.Beginning).To(100);
            transformed.Should().Be(String.Empty);

            transformed = "Some very long string".Remove().Starting(5).From(The.Beginning).To(100);
            transformed.Should().Be("Some");

            transformed = "Some very long string".Remove().Starting(7).From(The.Beginning).To(11);
            transformed.Should().Be("Some vlong string");
        }

        [TestMethod]
        public void RemoveStartingCharacterFromEndToCharacter()
        {
            string transformed = "Some very long string".Remove().Starting(0).From(The.End).To(0);
            transformed.Should().Be(String.Empty);

            transformed = "Some very long string".Remove().Starting(0).From(The.End).To(1);
            transformed.Should().Be(String.Empty);

            transformed = "Some very long string".Remove().Starting(1).From(The.End).To(1);
            transformed.Should().Be(String.Empty);

            transformed = "Some very long string".Remove().Starting(1).From(The.End).To(100);
            transformed.Should().Be("Some very long strin");

            transformed = "Some very long string".Remove().Starting(5).From(The.End).To(100);
            transformed.Should().Be("Some very long s");

            transformed = "Some very long string".Remove().Starting(7).From(The.End).To(11);
            transformed.Should().Be("Some very string");
        }

        [TestMethod]
        public void RemoveStartingCharacterFromBeginningToCharacterInReverse()
        {
            string transformed = "Some very long string".Remove().Starting(1).From(The.Beginning).To(0);
            transformed.Should().Be("ome very long string");

            transformed = "Some very long string".Remove().Starting(100).From(The.Beginning).To(1);
            transformed.Should().Be(String.Empty);

            transformed = "Some very long string".Remove().Starting(100).From(The.Beginning).To(5);
            transformed.Should().Be("Some");

            transformed = "Some very long string".Remove().Starting(13).From(The.Beginning).To(6);
            transformed.Should().Be("Some g string");
        }

        [TestMethod]
        public void RemoveStartingCharacterFromEndToCharacterInReverse()
        {
            string transformed = "Some very long string".Remove().Starting(100).From(The.End).To(1);
            transformed.Should().Be("ome very long string");

            transformed = "Some very long string".Remove().Starting(100).From(The.End).To(5);
            transformed.Should().Be("very long string");

            transformed = "Some very long string".Remove().Starting(13).From(The.End).To(6);
            transformed.Should().Be("Some  long string");

            transformed = "Some very long string".Remove().Starting(13).From(The.End).To(13);
            transformed.Should().Be("Some verg string");
        }

        #endregion

        #region Remove Starting From To From

        [TestMethod]
        public void RemoveStartingCharacterFromBeginningToCharacterFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(3).From(The.Beginning).To(6).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingCharacterFromBeginningToCharacterFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(3).From(The.Beginning).To(6).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingCharacterFromEndToCharacterFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(3).From(The.End).To(6).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingCharacterFromEndToCharacterFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(3).From(The.End).To(6).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingCharacterFromBeginningToCharacterFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(5).From(The.Beginning).To(14).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingCharacterFromBeginningToCharacterFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(5).From(The.Beginning).To(14).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingCharacterFromEndToCharacterFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(5).From(The.End).To(14).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingCharacterFromEndToCharacterFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(5).From(The.End).To(14).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingCharacterFromBeginningToCharacterFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(0).From(The.Beginning).To(0).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);

            transformed = "Some very long string".Remove().Starting(0).From(The.Beginning).To(1).From(The.Beginning);
            transformed.Should().Be("ome very long string");

            transformed = "Some very long string".Remove().Starting(1).From(The.Beginning).To(1).From(The.Beginning);
            transformed.Should().Be("ome very long string");

            transformed = "Some very long string".Remove().Starting(1).From(The.Beginning).To(100).From(The.Beginning);
            transformed.Should().Be(String.Empty);

            transformed = "Some very long string".Remove().Starting(5).From(The.Beginning).To(100).From(The.Beginning);
            transformed.Should().Be("Some");

            transformed = "Some very long string".Remove().Starting(7).From(The.Beginning).To(11).From(The.Beginning);
            transformed.Should().Be("Some vlong string");
        }

        [TestMethod]
        public void RemoveStartingCharacterFromBeginningToCharacterFromEnd()
        {
            string transformed = "Entire string will be removed".Remove().Starting(0).From(The.Beginning).To(0).From(The.End);
            transformed.Should().Be(String.Empty);

            transformed = "Some very long string".Remove().Starting(0).From(The.Beginning).To(1).From(The.End);
            transformed.Should().Be(String.Empty);

            transformed = "Some very long string".Remove().Starting(1).From(The.Beginning).To(1).From(The.End);
            transformed.Should().Be(String.Empty);

            transformed = "Some very long string".Remove().Starting(1).From(The.Beginning).To(100).From(The.End);
            transformed.Should().Be("ome very long string");

            transformed = "Some very long string".Remove().Starting(6).From(The.Beginning).To(100).From(The.End);
            transformed.Should().Be("very long string");

            transformed = "Some very long string".Remove().Starting(7).From(The.Beginning).To(11).From(The.End);
            transformed.Should().Be("Some vong string");
        }

        [TestMethod]
        public void RemoveStartingCharacterFromEndToCharacterFromBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(0).From(The.End).To(0).From(The.Beginning);
            transformed.Should().Be(String.Empty);

            transformed = "Some very long string".Remove().Starting(0).From(The.End).To(1).From(The.Beginning);
            transformed.Should().Be(String.Empty);

            transformed = "Some very long string".Remove().Starting(1).From(The.End).To(1).From(The.Beginning);
            transformed.Should().Be(String.Empty);

            transformed = "Some very long string".Remove().Starting(1).From(The.End).To(100).From(The.Beginning);
            transformed.Should().Be("Some very long strin");

            transformed = "Some very long string".Remove().Starting(5).From(The.End).To(100).From(The.Beginning);
            transformed.Should().Be("Some very long s");

            transformed = "Some very long string".Remove().Starting(7).From(The.End).To(11).From(The.Beginning);
            transformed.Should().Be("Some very string");
        }

        [TestMethod]
        public void RemoveStartingCharacterFromEndToCharacterFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(0).From(The.End).To(0).From(The.End);
            transformed.Should().Be(Const.SampleString);

            transformed = "Some very long string".Remove().Starting(0).From(The.End).To(1).From(The.End);
            transformed.Should().Be("Some very long strin");

            transformed = "Some very long string".Remove().Starting(1).From(The.End).To(1).From(The.End);
            transformed.Should().Be("Some very long strin");

            transformed = "Some very long string".Remove().Starting(1).From(The.End).To(100).From(The.End);
            transformed.Should().Be(String.Empty);

            transformed = "Some very long string".Remove().Starting(5).From(The.End).To(100).From(The.End);
            transformed.Should().Be("ring");

            transformed = "Some very long string".Remove().Starting(7).From(The.End).To(11).From(The.End);
            transformed.Should().Be("Some very string");
        }

        [TestMethod]
        public void RemoveStartingCharacterFromBeginningToCharacterFromBeginningInReverse()
        {
            string transformed = "Some very long string".Remove().Starting(1).From(The.Beginning).To(0).From(The.Beginning);
            transformed.Should().Be("ome very long string");

            transformed = "Some very long string".Remove().Starting(100).From(The.Beginning).To(1).From(The.Beginning);
            transformed.Should().Be(String.Empty);

            transformed = "Some very long string".Remove().Starting(100).From(The.Beginning).To(5).From(The.Beginning);
            transformed.Should().Be("Some");

            transformed = "Some very long string".Remove().Starting(13).From(The.Beginning).To(6).From(The.Beginning);
            transformed.Should().Be("Some g string");
        }

        [TestMethod]
        public void RemoveStartingCharacterFromBeginningToCharacterFromEndInReverse()
        {
            string transformed = "Some very long string".Remove().Starting(100).From(The.Beginning).To(1).From(The.End);
            transformed.Should().Be("Some very long strin");

            transformed = "Some very long string".Remove().Starting(100).From(The.Beginning).To(5).From(The.End);
            transformed.Should().Be("Some very long s");

            transformed = "Some very long string".Remove().Starting(13).From(The.Beginning).To(12).From(The.End);
            transformed.Should().Be("Some veryg string");
        }

        [TestMethod]
        public void RemoveStartingCharacterFromEndToCharacterFromBeginningInReverse()
        {
            string transformed = "Some very long string".Remove().Starting(100).From(The.End).To(1).From(The.Beginning);
            transformed.Should().Be("ome very long string");

            transformed = "Some very long string".Remove().Starting(100).From(The.End).To(5).From(The.Beginning);
            transformed.Should().Be("very long string");

            transformed = "Some very long string".Remove().Starting(13).From(The.End).To(6).From(The.Beginning);
            transformed.Should().Be("Some  long string");

            transformed = "Some very long string".Remove().Starting(13).From(The.End).To(13).From(The.Beginning);
            transformed.Should().Be("Some verg string");
        }

        [TestMethod]
        public void RemoveStartingCharacterFromEndToCharacterFromEndInReverse()
        {
            string transformed = "Some very long string".Remove().Starting(13).From(The.End).To(6).From(The.End);
            transformed.Should().Be("Some vertring");

            transformed = "Some very long string".Remove().Starting(13).From(The.End).To(13).From(The.End);
            transformed.Should().Be("Some ver long string");
        }

        #endregion
    }
}
