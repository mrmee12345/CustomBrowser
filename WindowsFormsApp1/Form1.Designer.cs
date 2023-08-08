
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.Back = new System.Windows.Forms.Button();
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.Forward = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.Reload = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.NewTab = new System.Windows.Forms.Button();
            this.CloseTab = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(0, 0);
            this.webBrowser.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScriptErrorsSuppressed = true;
            this.webBrowser.Size = new System.Drawing.Size(1226, 613);
            this.webBrowser.TabIndex = 9;
            this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser10_DocumentCompleted);
            // 
            // Back
            // 
            this.Back.AutoSize = true;
            this.Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back.Location = new System.Drawing.Point(12, 15);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(33, 30);
            this.Back.TabIndex = 10;
            this.Back.Text = "<";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchBar
            // 
            this.SearchBar.Location = new System.Drawing.Point(179, 17);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(947, 26);
            this.SearchBar.TabIndex = 11;
            this.SearchBar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.SearchBar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchBar_KeyPress);
            // 
            // Forward
            // 
            this.Forward.AutoSize = true;
            this.Forward.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Forward.Location = new System.Drawing.Point(51, 15);
            this.Forward.Name = "Forward";
            this.Forward.Size = new System.Drawing.Size(28, 30);
            this.Forward.TabIndex = 12;
            this.Forward.Text = ">";
            this.Forward.UseVisualStyleBackColor = true;
            this.Forward.Click += new System.EventHandler(this.button2_Click);
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search.Location = new System.Drawing.Point(1132, 15);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 30);
            this.Search.TabIndex = 13;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.button3_Click);
            // 
            // Reload
            // 
            this.Reload.AutoSize = true;
            this.Reload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reload.Location = new System.Drawing.Point(98, 15);
            this.Reload.Name = "Reload";
            this.Reload.Size = new System.Drawing.Size(75, 30);
            this.Reload.TabIndex = 14;
            this.Reload.Text = "Reload";
            this.Reload.UseVisualStyleBackColor = true;
            this.Reload.Click += new System.EventHandler(this.button4_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Location = new System.Drawing.Point(12, 56);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1237, 646);
            this.tabControl.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.webBrowser);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1229, 613);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click_1);
            // 
            // NewTab
            // 
            this.NewTab.AutoSize = true;
            this.NewTab.Location = new System.Drawing.Point(1213, 15);
            this.NewTab.Name = "NewTab";
            this.NewTab.Size = new System.Drawing.Size(28, 30);
            this.NewTab.TabIndex = 16;
            this.NewTab.Text = "+";
            this.NewTab.UseVisualStyleBackColor = true;
            this.NewTab.Click += new System.EventHandler(this.NewTab_Click);
            // 
            // CloseTab
            // 
            this.CloseTab.AutoSize = true;
            this.CloseTab.Location = new System.Drawing.Point(1247, 15);
            this.CloseTab.Name = "CloseTab";
            this.CloseTab.Size = new System.Drawing.Size(30, 30);
            this.CloseTab.TabIndex = 17;
            this.CloseTab.Text = "X";
            this.CloseTab.UseVisualStyleBackColor = true;
            this.CloseTab.Click += new System.EventHandler(this.CloseTab_Click);
            // 
            // Form1
            // 
            this.AccessibleName = "o";
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1283, 729);
            this.Controls.Add(this.CloseTab);
            this.Controls.Add(this.NewTab);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Forward);
            this.Controls.Add(this.Reload);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.SearchBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "The PP browser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Forward;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Reload;
        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button NewTab;
        private System.Windows.Forms.Button CloseTab;
    }
}

