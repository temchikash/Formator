using NUnit.Framework;

namespace Formator
{
    [TestFixture]
    public class UnitTest
    {
        [Test]
        public void TypographyText_Test1()
        {
            string input = "Hello,world!";
            string expected = "Hello, world!";

            string result = Formator.TypographyText(input);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void TypographyText_Test2()
        {
            string input = "Hello  world!";
            string expected = "Hello world!";

            string result = Formator.TypographyText(input);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void TypographyText_Test3()
        {
            string input = "This... is a test...";
            string expected = "This… is a test…";

            string result = Formator.TypographyText(input);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void TypographyText_Test4()
        {
            string input = "Formator (c) 2024";
            string expected = "Formator © 2024";

            string result = Formator.TypographyText(input);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void TypographyText_Test5()
        {
            string input = "This-is-a-test";
            string expected = "This - is - a - test";

            string result = Formator.TypographyText(input);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void TypographyText_Test6()
        {
            string input = "A sentence with    four spaces";
            string expected = "A sentence with не пиши 4 пробела подряд four spaces";

            string result = Formator.TypographyText(input);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void TypographyText_Test7()
        {
            string input = "No changes needed";
            string expected = "No changes needed";

            string result = Formator.TypographyText(input);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void TypographyText_Test8()
        {
            string input = "";
            string expected = "";

            string result = Formator.TypographyText(input);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void TypographyText_Test9()
        {
            string input = "Testing hyphen-word";
            string expected = "Testing hyphen - word";

            string result = Formator.TypographyText(input);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void TypographyText_Test10()
        {
            string input = "End with punctuation!";
            string expected = "End with punctuation!";

            string result = Formator.TypographyText(input);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
