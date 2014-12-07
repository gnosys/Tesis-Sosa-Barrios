using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Tonkenizer.Filters;
using Tonkenizer.Utils;

namespace Tonkenizer.Core
{
    public class Tokenizer : ITokenizer
    {
        private PreFilter _prefilter;
        private AroundFilter _aroundFilter;
        private Regex _delimiter;
        private Regex linkParser = new Regex(@"\b(?:https?://|www\.)\S+\b", RegexOptions.Compiled | RegexOptions.IgnoreCase);


        public Tokenizer(Regex delimiter, PreFilter prefilter, AroundFilter aroundFilter)
        {
            _delimiter = delimiter;
            _prefilter = prefilter;
            _aroundFilter = aroundFilter;
        }

        public IEnumerable<string[]> Tokenize(List<string> docs)
        {
            //here we pre process the docs
            List<string> preprocessedDocs =  _prefilter != null ? _prefilter.Filter(docs) : docs;

            List<string[]> tokensList = new List<string[]>();
            if (preprocessedDocs != null && preprocessedDocs.Count > 0)
            {
                foreach(string doc in preprocessedDocs)
                {
                    var links = linkParser.Matches(doc);
                    string docWithoutLinks = linkParser.Replace(doc, String.Empty);
                    List<string> currentTokens = new List<string>();
                    if (!String.IsNullOrWhiteSpace(docWithoutLinks))
                    {
                        currentTokens = Partition(docWithoutLinks).ToList();
                    }
                    foreach (Match link in links)
                    {
                        currentTokens.Add(link.Value);
                    }
                    if (!currentTokens.Any())
                    {
                        currentTokens.Add(String.Empty);
                    }
                    tokensList.Add(currentTokens.ToArray());
                }
            }
            return tokensList;
        }


        private string[] Partition(string input)
        {
            input = input.ToLower();//necessary or filter?
            String[] tokens = _delimiter.Split(input);
            ArrayList filter = new ArrayList();

            for (int i = 0; i < tokens.Length; i++)
            {
                MatchCollection mc = _delimiter.Matches(tokens[i]);
                if (mc.Count <= 0 && tokens[i].Trim().Length > 0)
                {
                    //here we filter the word
                    string filteredToken = _aroundFilter != null ? _aroundFilter.Filter(tokens[i]) : tokens[i];
                    if (filteredToken != null && filteredToken.Trim().Length > 0)
                    {
                        filter.Add(filteredToken);
                    }
                }
            }

            return StringUtils.ArrayListToArray(filter);
        }

    }
}
