using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegEx_Morfolojik_Analiz_App
{
    internal class MorphologicalAnalyzer
    {
         internal List<string> AnalyzeMorphemes(string cleanedText)
        {
            // Implement your logic for morpheme analysis here
            // This method should return a list of morphemes
            List<string> morphemes = new List<string>();

            // Example: Identify common morphemes based on prefixes and suffixes
            var prefixMorphemes = new List<string> { "un", "pre" };
            var suffixMorphemes = new List<string> { "able", "ing" };

            foreach (var word in cleanedText.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))
            {
                foreach (var prefix in prefixMorphemes)
                {
                    if (word.StartsWith(prefix))
                    {
                        morphemes.Add(prefix);
                    }
                }

                foreach (var suffix in suffixMorphemes)
                {
                    if (word.EndsWith(suffix))
                    {
                        morphemes.Add(suffix);
                    }
                }
            }

            return morphemes;
        }

         internal List<string> AnalyzeRoots(string cleanedText)
        {
            // Implement your logic for root analysis here
            // This method should return a list of roots
            List<string> roots = new List<string>();

            // Example: Identify roots by removing common suffixes
            var suffixes = new List<string> { "ing", "ed" };

            foreach (var word in cleanedText.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))
            {
                string potentialRoot = word;

                foreach (var suffix in suffixes)
                {
                    if (word.EndsWith(suffix))
                    {
                        potentialRoot = word.Substring(0, word.Length - suffix.Length);
                    }
                }

                roots.Add(potentialRoot);
            }

            return roots;
        }

        public List<string> AnalyzeUniqueWords(string cleanedText)
        {
            // Split the cleaned text into words by spaces
            string[] words = cleanedText.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Use a HashSet to store unique words
            var uniqueWords = new HashSet<string>(words);

            return uniqueWords.ToList();
        }
    }
}