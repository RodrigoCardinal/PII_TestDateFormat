using NUnit.Framework;
namespace Library.Tests
{

    public class DateFormatterTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CorrectFormat()
        {
            string input ="14/09/2023";
            string expected = "2023-09-14";

            string actual = TestDateFormat.DateFormatter.ChangeFormat(input);

            Assert.That(actual, Is.EqualTo(expected));
        }
        
        [Test]
        public void WrongFormat()
        {
            string input ="14/09/20233";
            string expected = "";

            string actual = TestDateFormat.DateFormatter.ChangeFormat(input);

            Assert.That(actual, Is.EqualTo(expected));
        }

         [Test]
        public void TestBlankDate()
        {
            string input = "";
            string expected = "";

            string actual = TestDateFormat.DateFormatter.ChangeFormat(input);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}