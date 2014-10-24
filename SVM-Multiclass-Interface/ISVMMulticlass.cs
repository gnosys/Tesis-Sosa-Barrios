using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVM_Multiclass_Interface
{
    public interface ISVMMulticlass
    {
        string Learn(string example_file, string model_file, int trainingPercentage);

        string Classify(string example_file, string model_file, string predictions_file, int trainingPercentage);
    }
}
