using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFIDFWeighting
{
    public interface IRepresentation
    {
        void CreateRepresentationFiles(List<string[]> tokens, int docs, int[] categories, string directoryFilePath, float minWeight, int trainingPercentage);
    }
}
