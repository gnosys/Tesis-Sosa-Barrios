using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseSQL;
using ServiceRanking;

namespace TFIDFWeighting
{
    public class Representation : IRepresentation
    {

        public void CreateRepresentationFiles(List<string[]> tokens, int docs, int[] categories, string directoryFilePath, float minWeight, int trainingPercentage)
        {
            TFIDFMeasure tfdif = new TFIDFMeasure(tokens);
            CreateVSMFiles(tfdif.TermWeight, docs, categories, directoryFilePath, minWeight, trainingPercentage);
        }

        private static void CreateVSMFiles(float[][] weights, int docs, int[] categories, string directoryFilePath, float minWeight, int trainingPercentage)
        {
            int lastSlash = directoryFilePath.LastIndexOf('/');
            directoryFilePath = (lastSlash > -1) ? directoryFilePath.Substring(0, lastSlash) : directoryFilePath;
            string[] lines = new string[docs];

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
                lines[i] = builder.ToString();
                builder.Clear();
            }

            int learnLimit = docs * trainingPercentage / 100;
            File.WriteAllLines(String.Format(@"{0}\svm-learn.dat", directoryFilePath), lines.Take(learnLimit));
            File.WriteAllLines(String.Format(@"{0}\svm-classify.dat", directoryFilePath), lines.Skip(learnLimit));
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
