using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseSQL
{
    public class TweetLevelCategory
    {

        public TweetLevelCategory()
        {
        }

        public int IdTweet { get; set; }
        public int IdCategory { get; set; }
        public int Level { get; set; }
    }
}
