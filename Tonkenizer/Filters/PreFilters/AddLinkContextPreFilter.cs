using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace Tonkenizer.Filters.PreFilters
{

    class HtmlDocDetails
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string Keywords { get; set; }
    }

    public class AddLinkContextPreFilter : PreFilter
    {
        public AddLinkContextPreFilter(PreFilter next) : base(next) { }

        protected override List<string> DoFilter(List<string> docs)
        {
            List<string> ret = new List<string>();
            foreach (string doc in docs)
            {
                Regex linkParser = new Regex(@"\b(?:https?://|www\.)\S+\b", RegexOptions.Compiled | RegexOptions.IgnoreCase);
                StringBuilder builder = new StringBuilder();
                foreach (Match m in linkParser.Matches(doc))
                {
                    HtmlDocDetails detail = GetHtmlDetailsFromUrl(m.Value);
                    if (detail != null)
                    {
                        builder.AppendFormat("\n{0}, {1}, {2}", detail.Title, detail.Description, detail.Keywords);
                    }
                }
                ret.Add(String.Format("{0}. {1}", doc, builder.ToString()));
            }
            return ret;
        }

        private HtmlDocDetails GetHtmlDetailsFromUrl(String strUrl)
        {
            try
            {
                HtmlDocDetails docDetails = new HtmlDocDetails();

                //Get Meta Tags
                var webGet = new HtmlWeb();
                var document = webGet.Load(strUrl);
                var metaTags = document.DocumentNode.SelectNodes("//meta");
                if (metaTags != null)
                {
                    foreach (var tag in metaTags)
                    {
                        if (tag.Attributes["name"] != null && tag.Attributes["content"] != null && tag.Attributes["name"].Value == "description")
                        {
                            docDetails.Description = tag.Attributes["content"].Value;
                        }

                        if (tag.Attributes["name"] != null && tag.Attributes["content"] != null && tag.Attributes["name"].Value == "keywords")
                        {
                            docDetails.Keywords = tag.Attributes["content"].Value;
                        }
                    }
                }

                //To Get Title
                string pageSource = document.DocumentNode.WriteContentTo();
                docDetails.Title = Regex.Match(pageSource, @"\<title\b[^>]*\>\s*(?<Title>[\s\S]*?)\</title\>", RegexOptions.IgnoreCase).Groups["Title"].Value;


                return docDetails;
            }
            catch
            {
                return null;
            }
        }

    }
}
