using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preprocessing.TDFIFMeasure
{
    public class TermVector
    {
        public static float ComputeCosineSimilarity(float[] vector1, float[] vector2)
        {
            if (vector1.Length != vector2.Length)
                throw new Exception("DIFER LENGTH");


            float denom = (VectorLength(vector1) * VectorLength(vector2));
            if (denom == 0F)
                return 0F;
            else
                return (InnerProduct(vector1, vector2) / denom);

        }

        public static float InnerProduct(float[] vector1, float[] vector2)
        {

            if (vector1.Length != vector2.Length)
                throw new Exception("DIFFER LENGTH ARE NOT ALLOWED");


            float result = 0F;
            for (int i = 0; i < vector1.Length; i++)
                result += vector1[i] * vector2[i];

            return result;
        }

        public static float VectorLength(float[] vector)
        {
            float sum = 0.0F;
            for (int i = 0; i < vector.Length; i++)
                sum = sum + (vector[i] * vector[i]);

            return (float)Math.Sqrt(sum);
        }
    }
}
