﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        private string currentURL = "";

        //List<string> History = new List<string>();

        public Form1()
        {
            InitializeComponent();
            SizeChanged += Form1_SizeChanged;
        }
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            // Update the size of the WebBrowser control to fit the form's client area
            webBrowser.Size = new Size(this.ClientSize.Width, this.ClientSize.Height);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser.Navigate("www.duckduckgo.com");
            //SearchBar.Text = "www.duckduckgo.com";
        }


        private void webBrowser10_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string newURL = webBrowser.Url.ToString();

            // Check if the new URL is different from the current URL
            if (newURL != currentURL)
            {
                currentURL = newURL;
                UpdateUI(); // Update the UI with the new URL
                tabControl.SelectedTab.Text = webBrowser.DocumentTitle;
            }
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
                e.Handled = true;

                string inputText = SearchBar.Text.Trim();

                // Check if the input is a valid URL
                if (Uri.TryCreate(inputText, UriKind.Absolute, out Uri uriResult) && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps))
                {
                    // Valid URL, navigate to it
                    WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
                    if (web != null)
                    {
                        web.Navigate(inputText);
                    }
                }
                else
                {
                    // Invalid URL, perform a DuckDuckGo search
                    string searchUrl = "https://duckduckgo.com/?q=" + Uri.EscapeDataString(inputText);
                    WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
                    if (web != null)
                    {
                        web.Navigate(searchUrl);
                    }
                }
            }
        }

        private void CloseTab_Click(object sender, EventArgs e)
        {
            tabControl.TabPages.Remove(tabControl.SelectedTab);
        }
        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            // The e.Url parameter contains the target URL.
            string targetUrl = e.Url.ToString();
            // You can update UI or perform actions based on the targetUrl.
        }

        private void UpdateUI()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(UpdateUI));
                return;
            }

            // Update UI elements here
            SearchBar.Text = currentURL;
        }
    }
}
