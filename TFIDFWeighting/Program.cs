using System.Collections.Generic;
using ServiceRanking;
using Stemming;
using System.Linq;
using Preprocessing.Utils;
using System.Text;

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
            var bow = StringUtils.ArrayListToArray(tfdif.Terms);
            CreateBOWFile(bow);
            CreateVSMFile(tfdif.TermWeight, tfidfInputWithoutStopWords.Count);
        }

        private static void CreateVSMFile(float[][] weights, int docs)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"VSM.txt"))
            {
                for(int i=0; i < docs; i++)
                {
                    StringBuilder builder = new StringBuilder(); 
                    for (int j = 0; j<weights.Length; j++)
                    {
                        if (weights[j][i] > 0)
                        {
                            builder.AppendFormat("{0}:{1} ", j + 1, weights[j][i]);
                        }
                    }
                    file.WriteLine(builder.ToString());
                }
            }
        }


        private static void CreateBOWFile(string[] words)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"BOW.txt"))
            {
                foreach (string line in words)
                {
                        file.WriteLine(line);
                }
            }
        }

    }
}