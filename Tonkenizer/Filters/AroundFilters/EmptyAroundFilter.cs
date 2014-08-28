using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tonkenizer.Filters.AroundFilters
{
    public class EmptyAroundFilter : AroundFilter
    {
        public EmptyAroundFilter(AroundFilter next) : base(next) { }

        protected override string DoFilter(string doc)
        {
            return doc;
        }
    }
}
