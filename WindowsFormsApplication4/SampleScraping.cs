using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Net;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication4
{
    class SampleScraping
    {
        /// <summary>
        /// 引数urlにアクセスした際に取得できるHTMLを返します。
        /// </summary>
        /// <param name="url">URL(アドレス)</param>
        /// <returns>取得したHTML</returns>
        public string GetHtml(string url)
        {
            // 指定されたURLに対してのRequestを作成します。
            var req = (HttpWebRequest)WebRequest.Create(url);

            // html取得文字列
            string html = "";

            // 指定したURLに対してReqestを投げてResponseを取得します。
            using (var res = (HttpWebResponse)req.GetResponse())
            using (var resSt = res.GetResponseStream())
            // 取得した文字列をUTF8でエンコードします。
            using (var sr = new StreamReader(resSt, Encoding.UTF8))
            {
                // HTMLを取得する。
                html = sr.ReadToEnd();
            }

            return html;
        }
        /// <summary>
        /// 正規化表現を使用してHTMLからタイトルを取得します。
        /// </summary>
        /// <param name="html">HTML文字列</param>
        /// <returns>HTML文字列から取得したタイトル</returns>
        public string GetTitle(string html)
        {

            // 正規化表現
            // 大文字小文字区別なし       : RegexOptions.IgnoreCase
            // 「.」を改行にも適応する設定: RegexOptions.Singleline
            var reg = new Regex(@"<title>(?<title>.*?)</title>",
                         RegexOptions.IgnoreCase | RegexOptions.Singleline);

            // html文字列内から条件にマッチしたデータを抜き取ります。
            var m = reg.Match(html);

            // 条件にマッチした文字列内からKey("title部分")にマッチした値を抜き取ります。
            return m.Groups["title"].Value;

        }
    }
}