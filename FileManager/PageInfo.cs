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
    internal class PageInfo
    {
        public BookInfo[] bookList;
        public PageInfo(string pageLink, int count)
        {
            bookList = new BookInfo[count];
            string link = pageLink;
            int counter = 0;
            for (int i = 1; i <= (count / 16) + 1; i++)
            {
                link = link.Replace(Convert.ToString(i - 1), Convert.ToString(i));
                MatchCollection match = GetBooksCollection(dataSite(link));
                foreach (Match m in match)
                {
                    if (counter < count)
                    {
                        bookList[counter] = new BookInfo(m);
                        counter++;
                    }
                    else break;
                }
            }
        }
        private string dataSite(string link)
        {
            HttpWebRequest request = WebRequest.Create(link) as HttpWebRequest;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                Stream receiveStream;

                if (response.ContentEncoding == "gzip")
                    receiveStream = new GZipStream(response.GetResponseStream(), CompressionMode.Decompress);
                else
                    receiveStream = response.GetResponseStream();
                StreamReader? readStream = null;
                if (string.IsNullOrWhiteSpace(response.CharacterSet))
                    readStream = new StreamReader(receiveStream);
                else
                    readStream = new StreamReader(receiveStream, Encoding.UTF8);

                string data = readStream.ReadToEnd();

                response.Close();

                readStream.Close();
                return data;
            }
            return null;
        }
        private MatchCollection GetBooksCollection(string data)
        {
            Regex regexListOfBooksInfo = new Regex("MAIN-SEARCH_RESULTS-(.*?)</div>$", RegexOptions.Multiline);
            MatchCollection match = regexListOfBooksInfo.Matches(data);
            return match;
        }
    }
}
