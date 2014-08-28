using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tonkenizer.Filters
{
    public abstract class AroundFilter
    {
        private AroundFilter _next;

        public AroundFilter(AroundFilter next)
        {
            _next = next;
        }

        public string Filter(string word)
        {
            string ret = DoFilter(word);
            if(ret != null && _next != null)
            {
                ret = _next.Filter(ret);
            }
            return ret;
        }

        protected abstract string DoFilter(string doc);
    }
}
