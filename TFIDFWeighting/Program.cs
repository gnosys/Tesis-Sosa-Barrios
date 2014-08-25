using System.Collections.Generic;
using ServiceRanking;
using Stemming;
using System.Linq;

namespace Preprocessing
{
    class Program
    {
        static void Main(string[] args)
        {
            //text corpus
            string[] docs = new string[3] {
										   "watching the King’s Speech",
										   "I like the King’s Speech",
										   "they decide to watch a movie"
			};

            //preprocessing

            //1. TOKENIZING
            Tokeniser tokeniser = new Tokeniser();
            List<string[]> tfidfInput = new List<string[]>();
            for (int i = 0; i < docs.Length; i++)
            {
                tfidfInput.Add(tokeniser.Partition(docs[i]));
            }
            //2. Remove Stop words
            StopWordsHandler stopWordsHandler = new StopWordsHandler();
            List<string[]> tfidfInputWithoutStopWords = new List<string[]>();
            foreach (string[] tokens in tfidfInput)
            {
                tfidfInputWithoutStopWords.Add(tokens.Where(t => !stopWordsHandler.IsStopword(t)).ToArray());
            }
            //3. Stemming
            StemmerInterface stemmer = new PorterStemmer();
            foreach (string[] tokens in tfidfInputWithoutStopWords)
            {
                for (int i = 0; i < tokens.Length; i++)
                {
                    tokens[i] = stemmer.stemTerm(tokens[i]);
                }
            }

            //representation
            TFIDFMeasure tfdif = new TFIDFMeasure(tfidfInputWithoutStopWords);


        }
    }
}