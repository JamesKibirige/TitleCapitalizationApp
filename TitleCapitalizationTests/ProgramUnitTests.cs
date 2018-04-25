using Microsoft.VisualStudio.TestTools.UnitTesting;
using TitleCapitalizationApp;


namespace TitleCapitalizationTests
{
    [TestClass]
    public class ProgramUnitTests
    {
        [TestMethod]
        public void LowerCaseWord_HELLO_Returns_hello()
        {
            string word = "HELLO";
            string lowercaseWord = Program.LowerCaseWord(word);

            var result = string.Equals("hello", lowercaseWord);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CapitalizeWord_HELLO_Returns_Hello()
        {
            string word = "HELLO";
            string capsword = Program.CapitalizeWord(word);

            var result = string.Equals("Hello", capsword);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CapitalizeWord_james_Returns_James()
        {
            string word = "james";
            string capsword = Program.CapitalizeWord(word);

            var result = string.Equals("James", capsword);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CapitalizeWord_kIbIrIgE_Returns_Kibirige()
        {
            string word = "kIbIrIgE";
            string capsword = Program.CapitalizeWord(word);

            var result = string.Equals("Kibirige", capsword);

            Assert.IsTrue(result);
        }


        [TestMethod]
        //Provided Test Example 1 - "i love solving problems and it is fun"
        public void CapitalizeTitleCase_TestExample1()
        {
            string title = "i love solving problems and it is fun";
            string capsTitle = Program.CapitalizeTitle(title);

            var result = string.Equals("I Love Solving Problems and It Is Fun", capsTitle);

            Assert.IsTrue(result);
        }

        [TestMethod]
        //Provided Test Example 2 - "wHy DoeS A biRd Fly?"
        public void CapitalizeTitleCase_TestExample2()
        {
            string title = "wHy DoeS A biRd Fly?";
            string capsTitle = Program.CapitalizeTitle(title);

            var result = string.Equals("Why Does a Bird Fly?", capsTitle);

            Assert.IsTrue(result);
        }


        [TestMethod]
        //Test Example 3 - "why"
        public void CapitalizeTitleCase_TestExample3_SingleWordTitle()
        {
            string title = "why";
            string capsTitle = Program.CapitalizeTitle(title);

            var result = string.Equals("Why", capsTitle);

            Assert.IsTrue(result);
        }

        [TestMethod]
        //Test Example 4 - "" - Pass in empty string to Capitalize method
        public void CapitalizeTitleCase_TestExample4_EmptyStringTitle()
        {
            string title = "";
            string capsTitle = Program.CapitalizeTitle(title);

            var result = string.Equals("", capsTitle);

            Assert.IsTrue(result);
        }

        [TestMethod]
        //Test Example 5 - " " - Pass in a white space to Capitalize method
        public void CapitalizeTitleCase_TestExample5_WhitespaceStringTitle()
        {
            string title = " ";
            string capsTitle = Program.CapitalizeTitle(title);

            var result = string.Equals(" ", capsTitle);

            Assert.IsTrue(result);
        }
    }
}
