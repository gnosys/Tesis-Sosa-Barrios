using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ServiceRanking;
using Tonkenizer.Core;
using Tonkenizer.Filters;
using Tonkenizer.Filters.AroundFilters;
using Tonkenizer.Filters.PreFilters;
using Tonkenizer.Utils;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //text corpus
            List<string> docs = new List<string>() {
										   "watching the King’s Speech",
										   "I like the King’s Speech",
										   "they decide to watch a movie",
                                           "hey! read this: http://www.imdb.com/title/tt0070511/"
			};
            //tokenizer delimiter
            Regex delimiter = new Regex("([ \\t{}():;. \n])");

            //chain of responsability: docs and words transformations
            PreFilter preFilter = new EmptyPreFilter(null);
            AroundFilter aroundFilter = new StemmingFilter(null);
            //AroundFilter aroundFilter = new StemmingFilter(new StopWordFilter(null));

            //preprocessing
            ITokenizer tokenizer = new Tokenizer(delimiter, preFilter, aroundFilter);
            var TFIDFInput = tokenizer.Tokenize(docs).ToList();

            //representation
            TFIDFMeasure tfdif = new TFIDFMeasure(TFIDFInput);
            var bow = StringUtils.ArrayListToArray(tfdif.Terms);
            CreateBOWFile(bow);
            CreateVSMFile(tfdif.TermWeight, TFIDFInput.Count);
        }

        private static void CreateVSMFile(float[][] weights, int docs)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"VSM.txt"))
            {
                for (int i = 0; i < docs; i++)
                {
                    StringBuilder builder = new StringBuilder();
                    for (int j = 0; j < weights.Length; j++)
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
