using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //List<string> History = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser.Navigate("www.duckduckgo.com");
            SearchBar.Text = "www.duckduckgo.com";
        }

        private void webBrowser14_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
            {
                web.Navigate(SearchBar.Text);
                //History.Add(SearchBar.Text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
            {
                if (web.CanGoBack)
                {
                    web.GoBack();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
            {
                if (web.CanGoForward)
                {
                    web.GoForward();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void webBrowser10_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabControl.SelectedTab.Text = webBrowser.DocumentTitle;
        }

        WebBrowser webTab = null;

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void NewTab_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Text = "New tab";
            tabControl.Controls.Add(tab);
            tabControl.SelectTab(tabControl.TabCount - 1);
            webTab = new WebBrowser()
            {
                ScriptErrorsSuppressed = true
            };

            webTab.Parent = tab;
            webTab.Dock = DockStyle.Fill;
            webTab.Navigate("www.duckduckgo.com");
            SearchBar.Text = "www.duckduckgo.com";
            webTab.DocumentCompleted += webTag_DocumentCompleted;
        }

        private void webTag_DocumentCompleted(Object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabControl.SelectedTab.Text = webTab.DocumentTitle;
        }

        private void SearchBar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)13)
            {
                WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
                if (web != null)
                {
                    web.Navigate(SearchBar.Text);
                }
            }
        }

        private void CloseTab_Click(object sender, EventArgs e)
        {
            tabControl.TabPages.Remove(tabControl.SelectedTab);
        }
    }
}
