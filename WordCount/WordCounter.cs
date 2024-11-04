using System;

namespace WordCount
{
    internal class WordCounter
    {
        public int CountWordOccurrences(string text, string word)
        {
            int count = 0;

            text = text.ToLower();
            word = word.ToLower();

            string[] words = text.Split(new char[] { ' ', '.', ',', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string w in words)
            {
                if (w.Contains(word))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
