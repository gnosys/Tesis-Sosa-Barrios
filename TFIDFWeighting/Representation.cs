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
        private DataBase db = null;

        public void CreateRepresentationFiles()
        {
            List<string[]> TFIDFInput = db.GetCurrentTokens();
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
