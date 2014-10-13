using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseSQL;
using ServiceRanking;

namespace TFIDFWeighting
{
    public class Representation : IRepresentation
    {

        public void CreateRepresentationFile(List<string[]> tokens, int docs, int[] categories, string filePath, float minWeight)
        {
            TFIDFMeasure tfdif = new TFIDFMeasure(tokens);
            CreateVSMFile(tfdif.TermWeight, docs,categories,filePath, minWeight);
        }

        private static void CreateVSMFile(float[][] weights, int docs, int[] categories, string filePath, float minWeight)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(filePath))
            {
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < docs; i++)
                {
                    builder.AppendFormat("{0} ", categories[i]);
                    for (int j = 0; j < weights.Length; j++)
                    {
                        if (weights[j][i] > minWeight)
                        {
                            builder.AppendFormat("{0}:{1} ", j + 1, weights[j][i]);
                        }
                    }
                    file.WriteLine(builder.ToString());
                    builder.Clear();
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
