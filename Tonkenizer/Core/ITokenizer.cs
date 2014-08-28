using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tonkenizer.Core
{
    public interface ITokenizer
    {
        IEnumerable<string[]> Tokenize(List<string> docs);
    }
}
