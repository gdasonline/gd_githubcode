using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GD_WordCount;

namespace UnitTestWordCount
{
    [TestClass]
    public class UnitTestWordCount
    {
        [TestMethod]
        public void CanTestSplitsToWords()
        {
            Console.WriteLine("Testing to split into words");
            string input = "This is a statement, and so is this.";
            string[] expectedwordsplit = { "This", "is", "a", "statement", "and", "so", "is", "this" };
            string[] actualwordsplit = Program.GetWordCollections(input);
            CollectionAssert.AreEqual(expectedwordsplit,actualwordsplit);

        }

        [TestMethod]
        public void CanTestWordCount()
        {
            Console.WriteLine("Testing count words");
            string input = "This is a statement, and so is this.";
            Dictionary<string, int> expctedcount = new Dictionary<string, int>
            {
                { "this", 2 },
                { "is", 2 },
                { "a", 1 },
                { "statement", 1},
                { "and", 1 },
                { "so", 1 }

            };

            string[] actualwordsplit = Program.GetWordCollections(input);
            Dictionary<string, int> actualcount = Program.GetWordCountNumbers(actualwordsplit);

            CollectionAssert.AreEqual(expctedcount, actualcount);

        }
    }
}
