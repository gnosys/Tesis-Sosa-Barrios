using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceRanking;

namespace Preprocessing
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            string[] docs = new string[3] {
										   "watching the King’s Speech",
										   "I like the King’s Speech",
										   "they decide to watch a movie"
			};

            //preprocessing
            Tokeniser tokeniser = new Tokeniser();

            string[][] tfidfInput = new string[3][];
            for (int i = 0; i < docs.Length; i++)
            {
                tfidfInput[i] = tokeniser.Partition(docs[i]);
            }
            TFIDFMeasure tfdif = new TFIDFMeasure(tfidfInput);


        }
    }
}
