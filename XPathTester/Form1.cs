using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Xml.XPath;
using System.Xml;

namespace XPathTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();
            wc.Encoding = Encoding.UTF8;

			if(string.IsNullOrEmpty(tbxUserAgent.Text))
			{ 
				wc.Headers.Add("user-agent", tbxUserAgent.Text);
			}

			if (string.IsNullOrEmpty(tbxCookie.Text))
			{
				//"ai_user=7OSii|2017-08-14T21:24:32.811Z; Slb_CookiePolicy=true; benficadp#lang=pt-PT; ASP.NET_SessionId=a3jw3uby40irkhbmgxmkmixg; ARRAffinity=0c1893ceb7315936dd8dce5382062c1695bae0bb25a74cbe99fae7245da3c4e7; TS01181c65=017e78a9ff5bc9bf3a4766e4d8f001b7fee1147a9ae5d766509122e3876b6fa9ed3ba4955a6701dd48be745265fe2b8c81e74698f8d0e21aa1fb099b046e56a93a93b352ba; visid_incap_1301582=Qsqu9adETd6MyhwSJh4tJVytlVkAAAAAQUIPAAAAAADUu85qoY+yXwTgSmZsYd/y; incap_ses_457_1301582=5RWaDQvmdVrsaHbZtJdXBkiJplkAAAAA0bn6Ob+BRXC42zX0e7qQMw==; _ga=GA1.2.1579848954.1502745873; _gid=GA1.2.564709534.1504085912; ai_session=cghpR|1504085912717|1504086005335.84; TSc5941052_27=08da0952caab20006242f5f876df25b0de08b9e52be2fed1279e49052ff1c13627a4eb89ceab1ab3088759f0721120001f09fb2d1810234df50a0340bfeea19d524256f67c06c683b628360df8646dfc; TS01f32fae=010716811d0d867638e99e83c4759477c940831f6b729add8876fae0dd27db307f21e1d38b93592608680f51864af3b01566292a9e"
				wc.Headers.Add("Cookie", tbxCookie.Text);
			}

			try
            {
                string html = wc.DownloadString(tbxURL.Text);

				if(html.StartsWith("<?xml"))
				{
					XmlDocument doc = new XmlDocument();
					doc.LoadXml(html);

					int count = doc.SelectNodes(tbxExpression.Text).Count;
					lblNodeCount.Text = count.ToString();

					XPathNavigator nav = doc.CreateNavigator();
					tbxValue.Text = nav.SelectSingleNode(tbxExpression.Text).Value;
				}
				else
				{ 
					HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
					doc.LoadHtml(html);

					int count = doc.DocumentNode.SelectNodes(tbxExpression.Text).Count;
					lblNodeCount.Text = count.ToString();

					XPathNavigator nav = doc.DocumentNode.CreateNavigator();
					tbxValue.Text = nav.SelectSingleNode(tbxExpression.Text).Value;
				}
			}
            catch (Exception ex)
            {
                tbxValue.Text = "==/No Value\\==" + Environment.NewLine +  "Exception: " + ex.Message;
            }
        }
    }
}
