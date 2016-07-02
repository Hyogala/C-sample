using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 開始ボタンクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            // 処理中に「取得中」とラベル表示します。
            // 予めURLのテキストボックス下に無記名のラベルを作成しておきます。
            // (Name)をlblViewにしておいてください。
            lblView2.Visible = true;         // 可視化
            lblView2.Text = "取得中";       // 「取得中」の文字列を表示することで処理中であることを明記します。
            lblView2.BringToFront();         // Objectを最善面に移動します。
            lblView2.Update();               // 表示を更新します。

            // 今回サンプルで作成を行ったクラスをインスタンス化します。
            var scr = new SampleScraping();

            // 画面上からHTMLを取得するサイトのURLを取得します。
            string url = txtUrl.Text;

            // htmlを取得するメソッドを実行し、画面描画します。
            string html = scr.GetHtml(url);
            txtHtml2.Text = html;

            // 取得したHTML内からタイトルを取得します。
            string title = scr.GetTitle(html);
            txtTitle2.Text = title;
            //komentoo
            Console.Write ("aああ");
            // 「取得中」の文言を不可視にします。
            lblView2.Visible = false;
        }


    }
}