using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Net;
using System.IO.Compression;


namespace FileManager
{
    internal class BookInfo
    {
        public string nameOfBook;
        public string linkOfBook;
        public string authorOfBook;
        public string priceOfBook;
        public string dateOfBook;
        public string ratingOfBook;
        string sBookInfo;
        public BookInfo(Match bookInfo)
        {
            sBookInfo = bookInfo.Groups[0].Value;
            linkOfBook = GetLinkOfBook();
            nameOfBook = GetNameOfBook();
            authorOfBook = GetAuthorOfBook();
            priceOfBook = GetPriceOfBook();
            dateOfBook = GetDateOfBook();
            ratingOfBook = GetRatingOfBook();
        }
        private string GetRatingOfBook()
        {
            Regex regexRating = new Regex("icon-alt\">(.*?) out of 5");
            Match match = regexRating.Match(sBookInfo);
            return match.Groups[1].Value;
        }
        private string GetNameOfBook()
        {
            Regex regexName = new Regex("<span class=\"a-size-medium a-color-base a-text-normal\">(.*?)</span>");
            Match match = regexName.Match(sBookInfo);
            string result = match.Groups[1].Value;
            result = result.Replace("#x27;", "`");
            result = result.Replace("&amp;", "&");
            return result;
        }
        private string GetLinkOfBook()
        {
            Regex regexLink = new Regex("<a class=\"a-link-normal s-underline-text s-underline-link-text s-link-style a-text-normal\" href=\"(.*?)>");
            Match match = regexLink.Match(sBookInfo);
            return "www.amazon.com" + match.Groups[1].Value;
        }
        private string GetDateOfBook()
        {
            string result = "";
            Regex regexDate = new Regex("<span class=\"a-size-base a-color-secondary(.*?)a-text-normal\">(.*?)</span>");
            Match match = regexDate.Match(sBookInfo);
            if(match.Groups[2].Value == "")
            {

            }
            else
            {
                result = match.Groups[2].Value;
            }
            return result;
        }
        private string GetAuthorOfBook()
        {
            Regex regexAuthorWithHref = new Regex("a-size-base a-link-normal s-underline-text s-underline-link-text s-link-style\" href=\"(.*?)\">(.*?)</a>");

            Regex regexAuthorWithoutHref = new Regex("class=\"a-size-base\">(.*?)</span>");
            
            MatchCollection matchWithoutHref = regexAuthorWithoutHref.Matches(sBookInfo);
            MatchCollection matchWithHref = regexAuthorWithHref.Matches(sBookInfo);

            string result = "";

            foreach (Match withoutHref in matchWithoutHref)
            {
                result += withoutHref.Groups[1].Value;
            }

            foreach (Match withHref in matchWithHref)
            {
                result += withHref.Groups[2].Value;
            }
            result = result.Replace("&#x27", "");
            result = result.Replace(",", "");
            result = result.Replace("-", " ");
            result = result.Replace("by ", "");
            result = result.Replace("et al.", "");
            result = result.Trim(' ');
            return result;
        }
        private string GetPriceOfBook()
        {
            Regex regexPrice = new Regex("a-price-whole\">(.*?)<span");
            Match match = regexPrice.Match(sBookInfo);
            return match.Groups[1].Value;
        }
    }
}
