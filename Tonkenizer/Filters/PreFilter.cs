using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tonkenizer.Filters
{
    public abstract class PreFilter
    {
        public PreFilter Next {
            get
            {
                return _next;
            }
            set
            {
                _next = value;
            }
        }

        private PreFilter _next;

        public PreFilter(PreFilter next)
        {
            _next = next;
        }

        public List<string> Filter(List<string> docs)
        {
            List<string> ret = new List<string>();
            ret = DoFilter(docs);
            if (ret != null && _next != null)
            {
                ret = _next.DoFilter(ret);
            }
            return ret;
        }

        protected abstract List<string> DoFilter(List<string> docs);
    }
}
