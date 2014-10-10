using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVM_Multiclass_Interface
{
    public class SVMMulticlass : ISVMMulticlass
    {
        public string Learn(string example_file, string model_file)
        {
            // Start the child process.
            Process p = new Process();
            // Redirect the output stream of the child process.
            ProcessStartInfo myProcessStartInfo = new ProcessStartInfo("bin/svm_multiclass_learn.exe", String.Format("-c 1.0 {0} {1}", example_file, model_file));
            myProcessStartInfo.UseShellExecute = false;
            myProcessStartInfo.RedirectStandardOutput = true;
            p.StartInfo = myProcessStartInfo;
            p.Start();
            // Do not wait for the child process to exit before
            // reading to the end of its redirected stream.
            // p.WaitForExit();
            // Read the output stream first and then wait.
            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
            p.Close();
            return output;
        }

        public string Classify()
        {
            throw new NotImplementedException();
        }
    }
}
