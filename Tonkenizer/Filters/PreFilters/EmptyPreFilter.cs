using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tonkenizer.Filters.PreFilters
{
    public class EmptyPreFilter : PreFilter
    {
        public EmptyPreFilter(PreFilter next) : base(next) { }

        protected override List<string> DoFilter(List<string> docs)
        {
            return docs;
        }
    }
}
