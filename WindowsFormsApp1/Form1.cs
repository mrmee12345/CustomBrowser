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
using CefSharp.WinForms;
using CefSharp;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private ChromiumWebBrowser browser;

        private string currentURL = "";

        //List<string> History = new List<string>();

        public Form1()
        {
            InitializeComponent();

            // Initialize CefSharp settings
            CefSettings settings = new CefSettings();
            Cef.Initialize(settings);

            browser = new ChromiumWebBrowser();
            browser.Size = new Size(1264, 660);
            browser.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right;
            browser.Dock = DockStyle.Fill;
            Controls.Add(browser);



            // Load a URL in the ChromiumWebBrowser
            browser.Load("https://www.duckduckgo.com");

            browser.LoadingStateChanged += Browser_LoadingStateChanged;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Cef.Shutdown();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Browser_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            browser.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (browser.CanGoBack)
            {
                browser.Back();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ChromiumWebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
            if (browser.CanGoForward)
            {
                browser.Forward();
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

        /*private void NewTab_Click(object sender, EventArgs e)
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
        }*/

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
                    browser.Load(inputText);
                }
                else
                {
                    // Invalid URL, perform a DuckDuckGo search
                    string searchUrl = "https://duckduckgo.com/?q=" + Uri.EscapeDataString(inputText);
                    browser.Load(searchUrl);
                }
            }
        }

        private void CloseTab_Click(object sender, EventArgs e)
        {
            //tabControl.TabPages.Remove(tabControl.SelectedTab);
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

        private void chromiumWebBrowser1_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {

        }
    }
}