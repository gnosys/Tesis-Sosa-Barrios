using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace Tonkenizer.Filters.PreFilters
{
    public class OnlyWordsPreFilter : PreFilter
    {

        private static Dictionary<string, string> defaultAbbreviationsTable = new Dictionary<string, string>()
        {
            {"BFK","Big Fat Kiss"},
            {"BUF","Big, Ugly, Fat"},
            {"bday","Birthday"},
            {"Swag","Boasting About One's Skills"},
            {"BCBG","Bon Chic Bon Genre"},
            {"BBB","Boring Beyond Belief"},
            {"Bootsie","Boring Person"},
            {"BF","Boyfriend"}
        };
        
        
        private bool _removeLinks;
        private bool _replaceAbbreviations;
        private Dictionary<string, string> _abbreviationsTable;


        public OnlyWordsPreFilter(PreFilter next, bool removeLinks, bool replaceAbbreviations, bool byDefault, string filename)
            : base(next) 
        {
            _removeLinks = removeLinks;
            _replaceAbbreviations = replaceAbbreviations;
            _abbreviationsTable = byDefault ? defaultAbbreviationsTable : CreateDictionaryFromFile(filename);
        }

        private Dictionary<string, string> CreateDictionaryFromFile(string filename)
        {
            string[] lines = File.ReadAllLines(filename);
            Dictionary<string, string> ret = new Dictionary<string, string>();
            foreach(string line in lines)
            {
                string[] splittedString = line.Split('\t');
                ret.Add(splittedString[0], splittedString[1]);
            }
            return ret;
        }

        protected override List<string> DoFilter(List<string> docs)
        {
            List<string> ret = new List<string>();
            Regex linkParser = new Regex(@"\b(?:https?://|www\.)\S+\b", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            Regex delimiter = new Regex("([ \\t{}():;. \n])", RegexOptions.Compiled | RegexOptions.IgnoreCase);

            foreach (string doc in docs)
            {
                string newDoc = doc;
                if (_removeLinks)
                {
                   newDoc = linkParser.Replace(doc, String.Empty);
                }
                if (_replaceAbbreviations)
                {
                    StringBuilder builder = new StringBuilder();
                    String[] tokens = delimiter.Split(newDoc);
                    foreach (string token in tokens)
                    {
                        if (defaultAbbreviationsTable.Keys.Contains(token))
                        {
                            builder.Append(defaultAbbreviationsTable[token]);
                        }
                        else
                        {
                            builder.Append(token);
                        }
                    }
                    newDoc = builder.ToString();
                }
                ret.Add(newDoc);
            }
            return ret;
        }

    }
}
