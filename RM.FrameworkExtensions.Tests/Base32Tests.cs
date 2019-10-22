namespace RM.FrameworkExtensions.Tests {
    using System.Text;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Base32Tests {

        [TestMethod]
        public void ShouldConvertASCIIStringOfCorrectLengthToCorrectBase32Version() {
            // Arrange
            var teststring = "\"this is a test string of the correct length\"";

            // Act
            var base32String = Base32.ToBase32String(Encoding.ASCII.GetBytes(teststring));

            // Assert
            Assert.AreEqual("EJ2GQ2LTEBUXGIDBEB2GK43UEBZXI4TJNZTSA33GEB2GQZJAMNXXE4TFMN2CA3DFNZTXI2BC", base32String);
        }


        [TestMethod]
        public void ShouldConvertBase32RepresentationToASCIIStringOfCorrectLength() {
            // Arrange
            var testbase32string = "EJ2GQ2LTEBUXGIDBEB2GK43UEBZXI4TJNZTSA33GEB2GQZJAMNXXE4TFMN2CA3DFNZTXI2BC";

            // Act
            var convertedstring = Base32.FromBase32String(testbase32string);

            // Assert
            Assert.AreEqual("\"this is a test string of the correct length\"", Encoding.ASCII.GetString(convertedstring));

        }

        [TestMethod]
        public void ShouldConvertUTF8StringOfCorrectLengthToCorrectBase32Version() {
            // Arrange
            var teststring = "\"this is a test string of the correct length\"";

            // Act
            var base32String = Base32.ToBase32String(Encoding.UTF8.GetBytes(teststring));

            // Assert
            Assert.AreEqual("EJ2GQ2LTEBUXGIDBEB2GK43UEBZXI4TJNZTSA33GEB2GQZJAMNXXE4TFMN2CA3DFNZTXI2BC", base32String);
        }

        [TestMethod]
        public void ShouldConvertBase32RepresentationToUTF8StringOfCorrectLength() {
            // Arrange
            var testbase32string = "EJ2GQ2LTEBUXGIDBEB2GK43UEBZXI4TJNZTSA33GEB2GQZJAMNXXE4TFMN2CA3DFNZTXI2BC";

            // Act
            var convertedstring = Base32.FromBase32String(testbase32string);

            // Assert
            Assert.AreEqual("\"this is a test string of the correct length\"", Encoding.UTF8.GetString(convertedstring));

        }


        [TestMethod]
        public void ShouldConvertASCIIStringOfIncorrectLengthToCorrectBase32VersionWithPadding() {
            // Arrange
            var teststring = "this test string is the incorrect length for base32";

            // Act
            var base32String = Base32.ToBase32String(Encoding.ASCII.GetBytes(teststring), true);

            // Assert
            Assert.AreEqual("ORUGS4ZAORSXG5BAON2HE2LOM4QGS4ZAORUGKIDJNZRW64TSMVRXIIDMMVXGO5DIEBTG64RAMJQXGZJTGI======", base32String);
        }


        [TestMethod]
        public void ShouldConvertBase32RepresentationToASCIIStringOfCorrectLengthWithPadding() {
            // Arrange
            var testbase32string = "ORUGS4ZAORSXG5BAON2HE2LOM4QGS4ZAORUGKIDJNZRW64TSMVRXIIDMMVXGO5DIEBTG64RAMJQXGZJTGI======";

            // Act
            var convertedstring = Base32.FromBase32String(testbase32string);

            // Assert
            Assert.AreEqual("this test string is the incorrect length for base32", Encoding.ASCII.GetString(convertedstring));

        }

        [TestMethod]
        public void ShouldConvertUTF8StringOfIncorrectLengthToCorrectBase32VersionWithPadding() {
            // Arrange
            var teststring = "this test string is the incorrect length for base32";

            // Act
            var base32String = Base32.ToBase32String(Encoding.UTF8.GetBytes(teststring), true);

            // Assert
            Assert.AreEqual("ORUGS4ZAORSXG5BAON2HE2LOM4QGS4ZAORUGKIDJNZRW64TSMVRXIIDMMVXGO5DIEBTG64RAMJQXGZJTGI======", base32String);
        }

        [TestMethod]
        public void ShouldConvertBase32RepresentationWithPaddingToUTF8StringOfCorrectLength() {
            // Arrange
            var testbase32string = "ORUGS4ZAORSXG5BAON2HE2LOM4QGS4ZAORUGKIDJNZRW64TSMVRXIIDMMVXGO5DIEBTG64RAMJQXGZJTGI";

            // Act
            var convertedstring = Base32.FromBase32String(testbase32string);

            // Assert
            Assert.AreEqual("this test string is the incorrect length for base32", Encoding.UTF8.GetString(convertedstring));

        }


        [TestMethod]
        public void ShouldConvertASCIIStringOfIncorrectLengthToCorrectBase32VersionWithoutPadding() {
            // Arrange
            var teststring = "this test string is the incorrect length for base32";

            // Act
            var base32String = Base32.ToBase32String(Encoding.ASCII.GetBytes(teststring), false);

            // Assert
            Assert.AreEqual("ORUGS4ZAORSXG5BAON2HE2LOM4QGS4ZAORUGKIDJNZRW64TSMVRXIIDMMVXGO5DIEBTG64RAMJQXGZJTGI", base32String);
        }


        [TestMethod]
        public void ShouldConvertBase32RepresentationToASCIIStringOfCorrectLengthWithoutPadding() {
            // Arrange
            var testbase32string = "ORUGS4ZAORSXG5BAON2HE2LOM4QGS4ZAORUGKIDJNZRW64TSMVRXIIDMMVXGO5DIEBTG64RAMJQXGZJTGI";

            // Act
            var convertedstring = Base32.FromBase32String(testbase32string);

            // Assert
            Assert.AreEqual("this test string is the incorrect length for base32", Encoding.ASCII.GetString(convertedstring));

        }

        [TestMethod]
        public void ShouldConvertUTF8StringOfIncorrectLengthToCorrectBase32VersionWithoutPadding() {
            // Arrange
            var teststring = "this test string is the incorrect length for base32";

            // Act
            var base32String = Base32.ToBase32String(Encoding.UTF8.GetBytes(teststring), false);

            // Assert
            Assert.AreEqual("ORUGS4ZAORSXG5BAON2HE2LOM4QGS4ZAORUGKIDJNZRW64TSMVRXIIDMMVXGO5DIEBTG64RAMJQXGZJTGI", base32String);
        }

        [TestMethod]
        public void ShouldConvertBase32RepresentationWithoutPaddingToUTF8StringOfCorrectLength() {
            // Arrange
            var testbase32string = "ORUGS4ZAORSXG5BAON2HE2LOM4QGS4ZAORUGKIDJNZRW64TSMVRXIIDMMVXGO5DIEBTG64RAMJQXGZJTGI";

            // Act
            var convertedstring = Base32.FromBase32String(testbase32string);

            // Assert
            Assert.AreEqual("this test string is the incorrect length for base32", Encoding.UTF8.GetString(convertedstring));

        }

    }
}