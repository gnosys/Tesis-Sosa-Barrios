using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFIDFWeighting
{
    public static class StringUtils
    {
        public static string[] ArrayListToArray(ArrayList arraylist)
        {
            string[] array = new string[arraylist.Count];
            for (int i = 0; i < arraylist.Count; i++) array[i] = (string)arraylist[i];
            return array;
        }
    }
}
