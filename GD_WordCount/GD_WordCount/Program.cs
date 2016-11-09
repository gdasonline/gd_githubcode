using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GD_WordCount
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Accept the User Input
            Console.Write("Input:");
            string sentence = Console.ReadLine().ToLower();

            //Split Sentence into words
            string[] words = GetWordCollections(sentence);
            
            // Get Word Dictionary with their number count
            var WordCountDict = GetWordCountNumbers(words);

            //Write the Final Output
            Console.WriteLine("Output:");
            foreach (var word  in WordCountDict)
            {
                Console.WriteLine(word.Key + " "+  word.Value.ToString());

            }

            
        }

        public static string[] GetWordCollections ( string sentence)
        {


            //transform the sentence into array of  words 
            string[] source = sentence.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',', '"' }, StringSplitOptions.RemoveEmptyEntries);
            return source;

        }


        public static Dictionary<string,int> GetWordCountNumbers(string[] words)
        {

            // Calculate Word Count by their each group
            var WordGroupCounts = from word in words
                                  group word by word.ToLower()
                                         into wordcountdata
                                  select new { Word = wordcountdata.Key, Count = wordcountdata.Count() };

            //Make Word count dictionary
            var WordCountDict = WordGroupCounts.ToDictionary(wc => wc.Word, wc => wc.Count);
            return WordCountDict;

        }

    }
}
