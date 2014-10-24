using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVM_Multiclass_Interface
{
    public class SVMMulticlass : ISVMMulticlass
    {
        public string Learn(string example_file, string model_file, int trainingPercentage)
        {
            // Start the child process.
            Process p = new Process();
            // Redirect the output stream of the child process.
            string[] lines = File.ReadAllLines(example_file);
            File.WriteAllLines(example_file + ".tmp", lines.Take(lines.Length * trainingPercentage / 100));
            ProcessStartInfo myProcessStartInfo = new ProcessStartInfo("svm_bin/svm_multiclass_learn.exe", String.Format("-c 1.0 {0} {1}", example_file + ".tmp", model_file));
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
            File.Delete(example_file + ".tmp");
            return output;
        }

        public string Classify(string example_file, string model_file,string predictions_file, int trainingPercentage)
        {
            // Start the child process.
            Process p = new Process();
            // Redirect the output stream of the child process.
            string[] lines = File.ReadAllLines(example_file);
            File.WriteAllLines(example_file + ".tmp", lines.Skip(lines.Length * trainingPercentage / 100));
            ProcessStartInfo myProcessStartInfo = new ProcessStartInfo("svm_bin/svm_multiclass_classify.exe", String.Format("{0} {1} {2}", example_file + ".tmp", model_file, predictions_file));
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
            File.Delete(example_file + ".tmp");
            return output;
        }
    }
}
