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
            this.Back = new System.Windows.Forms.Button();
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.Forward = new System.Windows.Forms.Button();
            this.Reload = new System.Windows.Forms.Button();
            this.NewTab = new System.Windows.Forms.Button();
            this.CloseTab = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.AutoSize = true;
            this.Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back.Location = new System.Drawing.Point(7, 21);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(28, 30);
            this.Back.TabIndex = 10;
            this.Back.Text = "<";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchBar
            // 
            this.SearchBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBar.BackColor = System.Drawing.SystemColors.InfoText;
            this.SearchBar.ForeColor = System.Drawing.SystemColors.Window;
            this.SearchBar.Location = new System.Drawing.Point(166, 23);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SearchBar.Size = new System.Drawing.Size(1031, 26);
            this.SearchBar.TabIndex = 11;
            this.SearchBar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.SearchBar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchBar_KeyPress);
            // 
            // Forward
            // 
            this.Forward.AutoSize = true;
            this.Forward.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Forward.Location = new System.Drawing.Point(40, 21);
            this.Forward.Name = "Forward";
            this.Forward.Size = new System.Drawing.Size(28, 30);
            this.Forward.TabIndex = 12;
            this.Forward.Text = ">";
            this.Forward.UseVisualStyleBackColor = true;
            this.Forward.Click += new System.EventHandler(this.button2_Click);
            // 
            // Reload
            // 
            this.Reload.AutoSize = true;
            this.Reload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reload.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Reload.Location = new System.Drawing.Point(74, 21);
            this.Reload.Name = "Reload";
            this.Reload.Size = new System.Drawing.Size(75, 30);
            this.Reload.TabIndex = 14;
            this.Reload.Text = "Reload";
            this.Reload.UseVisualStyleBackColor = true;
            this.Reload.Click += new System.EventHandler(this.button4_Click);
            // 
            // NewTab
            // 
            this.NewTab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NewTab.AutoSize = true;
            this.NewTab.Location = new System.Drawing.Point(1203, 21);
            this.NewTab.Name = "NewTab";
            this.NewTab.Size = new System.Drawing.Size(28, 30);
            this.NewTab.TabIndex = 16;
            this.NewTab.Text = "+";
            this.NewTab.UseVisualStyleBackColor = true;
            this.NewTab.Click += new System.EventHandler(this.NewTab_Click);
            // 
            // CloseTab
            // 
            this.CloseTab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseTab.AutoSize = true;
            this.CloseTab.Location = new System.Drawing.Point(1237, 21);
            this.CloseTab.Name = "CloseTab";
            this.CloseTab.Size = new System.Drawing.Size(30, 30);
            this.CloseTab.TabIndex = 17;
            this.CloseTab.Text = "X";
            this.CloseTab.UseVisualStyleBackColor = true;
            this.CloseTab.Click += new System.EventHandler(this.CloseTab_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Location = new System.Drawing.Point(7, 74);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1260, 643);
            this.tabControl.TabIndex = 18;
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
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1283, 729);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.CloseTab);
            this.Controls.Add(this.NewTab);
            this.Controls.Add(this.Reload);
            this.Controls.Add(this.Forward);
            this.Controls.Add(this.SearchBar);
            this.Controls.Add(this.Back);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "The PP browser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Forward;
        private System.Windows.Forms.Button Reload;
        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.Button NewTab;
        private System.Windows.Forms.Button CloseTab;
        private System.Windows.Forms.TabControl tabControl;
    }
}